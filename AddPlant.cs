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
        //private void LoadPlantData()
        //{
        //    if (string.IsNullOrEmpty(plantID)) return;

        //    try
        //    {
        //        conn.Open();
        //        string query = "SELECT * FROM Plants WHERE PlantID = @PlantID";

        //        using (OleDbCommand cmd = new OleDbCommand(query, conn))
        //        {
        //            cmd.Parameters.AddWithValue("@PlantID", plantID);
        //            using (OleDbDataReader reader = cmd.ExecuteReader())
        //            {
        //                if (reader.Read())
        //                {
        //                    txtPlantName.Text = reader["PlantName"].ToString();
        //                    txtWaterFreq.Text = reader["WateringFrequency"].ToString();
        //                    txtFertilization.Text = reader["FertilizationSchedule"].ToString();
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error loading plant data: " + ex.Message);
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}
        //public AddPlant(string plantID) : this()   // Call the default constructor
        //{
        //    this.plantID = plantID;  // Assign the ID
        //    LoadPlantData();         // Load plant info into textboxes
        //}
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

                if (string.IsNullOrEmpty(plantID))   
                {
                    query = "INSERT INTO Plants (PlantName, WateringFrequency, FertilizationSchedule, PlantImage) " +
                            "VALUES (@name, @water, @fertilize, @image)";
                }
                else   
                {
                    query = "UPDATE Plants SET PlantName = @name, WateringFrequency = @water, FertilizationSchedule = @fertilize, PlantImage = @image " +
                            "WHERE PlantID = @id";
                }

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", txtPlantName.Text);
                    cmd.Parameters.AddWithValue("@water", txtWaterFreq.Text);
                    cmd.Parameters.AddWithValue("@fertilize", txtFertilization.Text);

                    
                    if (!string.IsNullOrEmpty(imagePath))  
                    {
                        byte[] imageBytes = File.ReadAllBytes(imagePath);
                        cmd.Parameters.AddWithValue("@image", imageBytes);
                    }
                    else  
                    {
                        cmd.Parameters.AddWithValue("@image", DBNull.Value);
                    }

                    if (!string.IsNullOrEmpty(plantID))   
                    {
                        cmd.Parameters.AddWithValue("@id", plantID);
                    }

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show(string.IsNullOrEmpty(plantID) ? "Plant added successfully." : "Plant updated successfully.");
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
        private void UpdatePlant()
        {
            try
            {
                conn.Open();

                // ✅ Fetch existing image if no new image is selected
                byte[] imageBytes = null;

                if (!string.IsNullOrEmpty(imagePath))  // New image selected
                {
                    imageBytes = File.ReadAllBytes(imagePath);
                }
                else  // No new image, fetch the existing one
                {
                    string queryImage = "SELECT PlantImage FROM Plants WHERE PlantID = ?";

                    using (var cmdImage = new OleDbCommand(queryImage, conn))
                    {
                        cmdImage.Parameters.AddWithValue("@PlantID", plantID);
                        var reader = cmdImage.ExecuteReader();

                        if (reader.Read() && reader["PlantImage"] != DBNull.Value)
                        {
                            imageBytes = (byte[])reader["PlantImage"];
                        }
                        else
                        {
                            // 🌟 Use a default image if none exists
                            imageBytes = File.ReadAllBytes("C:\\Users\\ACER ASPIRE 3\\Source\\Repos\\ONION-Your-Personal-PlantCare-Companion\\Resources\\default_plant.png");
                        }
                    }
                }

                // ✅ Update the plant details with existing or new image
                string query = "UPDATE Plants SET PlantName = ?, WateringFrequency = ?, FertilizationSchedule = ?, PlantImage = ? WHERE PlantID = ?";

                using (var cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@PlantName", txtPlantName.Text);
                    cmd.Parameters.AddWithValue("@WateringFrequency", txtWaterFreq.Text);
                    cmd.Parameters.AddWithValue("@FertilizationSchedule", txtFertilization.Text);

                    if (imageBytes != null && imageBytes.Length > 0)
                    {
                        cmd.Parameters.AddWithValue("@PlantImage", imageBytes);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@PlantImage", DBNull.Value);
                    }

                    cmd.Parameters.AddWithValue("@PlantID", plantID);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Plant updated successfully.");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating plant: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
