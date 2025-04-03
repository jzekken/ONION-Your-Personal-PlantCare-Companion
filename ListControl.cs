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
    public partial class ListControl : UserControl
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;
        string newInfo = "";
        public ListControl()
        {
            InitializeComponent();

            InitializeDatabase();
            LoadPlants();

        }
        private void InitializeDatabase()
        {
            try
            {

                myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\ACER ASPIRE 3\\source\\repos\\ONION-Your-Personal-PlantCare-Companion\\Resources\\PlantData.accdb\"");

                string query = @"SELECT Plants.PlantID, Plants.PlantName, Plants.WateringFrequency, Plants.FertilizationSchedule, Plants.PlantImage FROM Plants;";

                da = new OleDbDataAdapter(query, myConn);
                ds = new DataSet();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing database: " + ex.Message);
            }
        }
        private void HandlePlantControlEvents()
        {
            foreach (Plantdata plantControl in flowLayoutPanel1.Controls)
            {
                plantControl.UpdateClicked += (s, e) =>
                {
                    string plantID = plantControl.PlantID;
                    MessageBox.Show($"Update plant with ID: {plantID}");

                    // Open the AddPlant form in edit mode
                    AddPlant editForm = new AddPlant(plantID);
                    editForm.ShowDialog();

                    LoadPlants();  // Reload after update
                };

                plantControl.DeleteClicked += (s, e) =>
                {
                    string plantID = plantControl.PlantID;

                    try
                    {
                        using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\ACER ASPIRE 3\\source\\repos\\ONION-Your-Personal-PlantCare-Companion\\Resources\\PlantData.accdb\""))
                        {
                            conn.Open();
                            string query = "DELETE FROM Plants WHERE PlantID = ?";
                            using (OleDbCommand cmd = new OleDbCommand(query, conn))
                            {
                                cmd.Parameters.AddWithValue("@PlantID", plantID);
                                cmd.ExecuteNonQuery();
                            }
                        }

                        MessageBox.Show($"Plant with ID {plantID} deleted successfully.");
                        LoadPlants();  // Reload the plant list
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting plant: " + ex.Message);
                    }
                };
            }
        }
        private void button1_Click(object sender, EventArgs e) //add button
        {
            AddPlant addForm = new AddPlant();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                LoadPlants();  // Refresh the list when a plant is added
            }
        }
        private void LoadPlants()
        {
            try
            {
                flowLayoutPanel1.Controls.Clear();
                ds.Clear();

                using (myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\ACER ASPIRE 3\\source\\repos\\ONION-Your-Personal-PlantCare-Companion\\Resources\\PlantData.accdb\""))
                {
                    myConn.Open();
                    da.Fill(ds, "Plants");

                    foreach (DataRow row in ds.Tables["Plants"].Rows)
                    {
                        Plantdata plantControl = new Plantdata
                        {
                            PlantID = row["PlantID"].ToString(),
                            PlantName = $"Plant: {row["PlantName"]}",
                            WateringFrequency = row["WateringFrequency"].ToString(),
                            FertilizationSchedule = row["FertilizationSchedule"].ToString()
                        };

                        //Load the plant image
                        if (row["PlantImage"] != DBNull.Value)
                        {
                            byte[] imageBytes = (byte[])row["PlantImage"];
                            using (MemoryStream ms = new MemoryStream(imageBytes))
                            {
                                plantControl.PlantImage = Image.FromStream(ms);
                            }
                        }

                        //Button event handlers
                        plantControl.UpdateClicked += (s, e) =>
                        {
                            string plantID = plantControl.PlantID;

                            // Open the AddPlant form in edit mode with the plant ID
                            AddPlant editForm = new AddPlant(plantID);

                            if (editForm.ShowDialog() == DialogResult.OK)
                            {
                                LoadPlants();
                            }
                        };

                        plantControl.DeleteClicked += (s, e) =>
                        {
                            string plantID = plantControl.PlantID;

                            try
                            {
                                using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\ACER ASPIRE 3\\source\\repos\\ONION-Your-Personal-PlantCare-Companion\\Resources\\PlantData.accdb\""))
                                {
                                    conn.Open();
                                    string query = "DELETE FROM Plants WHERE PlantID = ?";
                                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                                    {
                                        cmd.Parameters.AddWithValue("@PlantID", plantID);
                                        cmd.ExecuteNonQuery();
                                    }
                                }

                                MessageBox.Show($"Plant with ID {plantID} deleted successfully.");
                                LoadPlants();
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error deleting plant: " + ex.Message);
                            }
                        };

                        // Add the plant control
                        flowLayoutPanel1.Controls.Add(plantControl);
                    }
                    lblPlantCount.Text = $"Total Plants: {ds.Tables["Plants"].Rows.Count}";
                }
                SetupSearchAutoComplete();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading plants: " + ex.Message);
            }
        }
        private void SetupSearchAutoComplete()
        {
            txtSearchPlant.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSearchPlant.AutoCompleteSource = AutoCompleteSource.CustomSource;

            var autoCompleteCollection = new AutoCompleteStringCollection();

            if (ds != null && ds.Tables.Contains("Plants"))
            {
                foreach (DataRow row in ds.Tables["Plants"].Rows)
                {
                    autoCompleteCollection.Add(row["PlantName"].ToString());
                }
            }

            txtSearchPlant.AutoCompleteCustomSource = autoCompleteCollection;
        }

        private void flowLayoutPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Control control = flowLayoutPanel1.GetChildAtPoint(e.Location);

                if (control is Plantdata plant && plant.ContextMenuStrip != null)
                {
                    plant.ContextMenuStrip.Show(Cursor.Position);
                }
            }
        }

        private void txtSearchPlant_TextChanged(object sender, EventArgs e)
        {
            if (ds == null || !ds.Tables.Contains("Plants")) return;

            string searchText = txtSearchPlant.Text.ToLower();
            flowLayoutPanel1.Controls.Clear();

            foreach (DataRow row in ds.Tables["Plants"].Rows)
            {
                string plantName = row["PlantName"].ToString().ToLower();

                if (plantName.Contains(searchText))
                {
                    Plantdata plantControl = new Plantdata
                    {
                        PlantID = row["PlantID"].ToString(),
                        PlantName = $"Plant: {row["PlantName"]}",
                        WateringFrequency = row["WateringFrequency"].ToString(),
                        FertilizationSchedule = row["FertilizationSchedule"].ToString()
                    };

                    // Load plant image
                    if (row["PlantImage"] != DBNull.Value)
                    {
                        byte[] imageBytes = (byte[])row["PlantImage"];
                        using (MemoryStream ms = new MemoryStream(imageBytes))
                        {
                            plantControl.PlantImage = Image.FromStream(ms);
                        }
                    }

                    flowLayoutPanel1.Controls.Add(plantControl);
                }
            }
        }
    }
}
