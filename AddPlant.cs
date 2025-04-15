using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Xml.Linq;

namespace ONION_Your_Personal_PlantCare_Companion
{
    public partial class AddPlant : Form
    {
        private OleDbConnection conn;
        private string plantID = string.Empty;
        private string imagePath = string.Empty;
        public AddPlant()
        {
            InitializeComponent();
            InitializeDatabase();
        }
        public AddPlant(string id) : this()  
        {
            plantID = id;

            if (!string.IsNullOrEmpty(plantID))
            {
                LoadPlantData(plantID);
            }
        }
        
        private void InitializeDatabase()
        {
            string connString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\ACER ASPIRE 3\\source\\repos\\ONION-Your-Personal-PlantCare-Companion\\Resources\\PlantData.accdb\"";
            conn = new OleDbConnection(connString);
        }
        private void LoadPlantData(string id)
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM Plants WHERE PlantID = ?";

                using (var cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PlantID", id);
                    var reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtPlantName.Text = reader["PlantName"].ToString();
                        txtWaterFreq.Text = reader["WateringFrequency"].ToString();
                        txtFertilization.Text = reader["FertilizationSchedule"].ToString();

                        
                        if (reader["PlantImage"] != DBNull.Value)
                        {
                            byte[] imageBytes = (byte[])reader["PlantImage"];

                            if (imageBytes.Length > 0)   
                            {
                                using (var ms = new MemoryStream(imageBytes))
                                {
                                    try
                                    {
                                        picPlantPreview.Image = Image.FromStream(ms);  
                                    }
                                    catch (Exception)
                                    {
                                        MessageBox.Show("Invalid image format.");
                                        picPlantPreview.Image = Image.FromFile("C:\\Users\\ACER ASPIRE 3\\Source\\Repos\\ONION-Your-Personal-PlantCare-Companion\\Resources\\default_plant.png");   // Clear the image if invalid
                                    }
                                }
                            }
                            else
                            {
                                picPlantPreview.Image = Image.FromFile("C:\\Users\\ACER ASPIRE 3\\Source\\Repos\\ONION-Your-Personal-PlantCare-Companion\\Resources\\default_plant.png"); ;  // Set to null if no image data
                            }
                        }
                        else
                        {
                            picPlantPreview.Image = Image.FromFile("C:\\Users\\ACER ASPIRE 3\\Source\\Repos\\ONION-Your-Personal-PlantCare-Companion\\Resources\\default_plant.png"); ;  // Handle null image
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading plants: {ex.Message}");
            }
            finally
            {
                conn.Close();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPlantName.Text) ||
        string.IsNullOrEmpty(txtWaterFreq.Text) ||
        string.IsNullOrEmpty(txtFertilization.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            try
            {
                conn.Open();

                string query;
                bool isNewPlant = string.IsNullOrEmpty(plantID);

                if (isNewPlant)
                {
                    query = "INSERT INTO Plants (PlantName, WateringFrequency, FertilizationSchedule, PlantImage) " +
                            "VALUES (?, ?, ?, ?)";
                }
                else
                {
                    query = "UPDATE Plants SET PlantName = ?, WateringFrequency = ?, FertilizationSchedule = ?, PlantImage = ? " +
                            "WHERE PlantID = ?";
                }

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("?", txtPlantName.Text);
                    cmd.Parameters.AddWithValue("?", Convert.ToInt32(txtWaterFreq.Text));  
                    cmd.Parameters.AddWithValue("?", Convert.ToInt32(txtFertilization.Text));  

                    if (!string.IsNullOrEmpty(imagePath))
                    {
                        byte[] imageBytes = File.ReadAllBytes(imagePath);
                        cmd.Parameters.AddWithValue("?", imageBytes);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("?", DBNull.Value);
                    }

                    if (!isNewPlant)
                    {
                        cmd.Parameters.AddWithValue("?", Convert.ToInt32(plantID));  
                    }

                    cmd.ExecuteNonQuery();
                }

                if (isNewPlant)
                {
                    
                    string getIdQuery = "SELECT MAX(PlantID) FROM Plants";
                    int newPlantID = 0;

                    using (OleDbCommand cmd = new OleDbCommand(getIdQuery, conn))
                    {
                        object result = cmd.ExecuteScalar();
                        if (result != DBNull.Value)
                        {
                            newPlantID = Convert.ToInt32(result);
                        }
                        else
                        {
                            MessageBox.Show("Error retrieving new PlantID.");
                            return;
                        }
                    }

                    
                    string healthQuery = "INSERT INTO HealthHistory (PlantID, HealthValue, RecordedDate) VALUES (?, ?, ?)";

                    using (OleDbCommand cmd = new OleDbCommand(healthQuery, conn))
                    {
                        cmd.Parameters.AddWithValue("?", newPlantID);
                        cmd.Parameters.AddWithValue("?", 100); 
                        cmd.Parameters.AddWithValue("?", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")); 
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show(isNewPlant ? "Plant added successfully." : "Plant updated successfully.");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    imagePath = ofd.FileName;
                    picPlantPreview.Image = Image.FromFile(imagePath);  
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
