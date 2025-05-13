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

namespace ONION_Your_Personal_PlantCare_Companion
{
    public partial class SearchControl : BaseUserControl
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ACER ASPIRE 3\Source\Repos\ONION-Your-Personal-PlantCare-Companion\Resources\PlantData.accdb;";

        public SearchControl()
        {
            InitializeComponent();
            lblCommonName.Text = "";
            lblScientificName.Text = "";
            lblWateringFrequency.Text = "";
            lblFertilizationFrequency.Text = "";
            lblDescription.Text = "";
            lblTemperature.Text = "";
            lblSunlight.Text = "";
            lblSoil.Text = "";
            lblHeight.Text = "";
            lblGrowthRate.Text = "";
            lblFlowering.Text = "";
            lblHumidity.Text = "";
            lblPruning.Text = "";
            flowLayoutPanel2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchText = searchTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(searchText))
            {
                
                searchContainer.BringToFront();
                LoadSearchResults(searchText);
            }
        }
        private void LoadSearchResults(string search)
        {
            
            searchContainer.Controls.Clear();
            searchContainer.BringToFront();

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                string query = "SELECT PlantID, CommonName, ScientificName FROM PlantDS " +
                               "WHERE CommonName LIKE @search OR ScientificName LIKE @search;";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@search", "%" + search + "%");

                    conn.Open();
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        bool hasResults = false;

                        while (reader.Read())
                        {
                            hasResults = true;
                            var resultItem = new result
                            {
                                CommonName = reader["CommonName"].ToString(),
                                ScientificName = reader["ScientificName"].ToString()
                            };

                            string plantID = reader["PlantID"].ToString();
                            resultItem.ResultDoubleClicked += (s, args) =>
                            {
                                ShowPlantDetails(plantID);
                                searchContainer.Controls.Clear();
                                searchTextBox.Clear();
                                searchContainer.SendToBack();
                            };

                            searchContainer.Controls.Add(resultItem);
                        }
                        if (!hasResults)
                        {
                            Label noResultsLabel = new Label
                            {
                                Text = "No plants found.",
                                AutoSize = true,
                                Font = new Font("Arial", 12, FontStyle.Italic),
                                ForeColor = Color.Gray,
                                Dock = DockStyle.Top,
                                TextAlign = ContentAlignment.MiddleCenter
                            };

                            searchContainer.Controls.Add(noResultsLabel);
                        }
                    }
                }
            }
        }
        private void ShowPlantDetails(string plantID)
        {
            
            string query = @"SELECT PlantID, CommonName, ScientificName, 
                             WateringFrequency, FertilizationFrequency, Description,
                             OptimalTemperature, SunlightRequirement, SoilType, Height, 
                             GrowthRate, FloweringSeason, Humidity, PruningRequirements, PlantImage
                          FROM PlantDS
                          WHERE PlantID = @PlantID";

            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();
                using (OleDbCommand command = new OleDbCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@PlantID", plantID);
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            flowLayoutPanel2.Visible = true;
                            lblCommonName.Text = $"Common Name: {reader["CommonName"] ?? "N/A"}";
                            lblScientificName.Text = $"Scientific Name: {reader["ScientificName"] ?? "N/A"}";
                            lblWateringFrequency.Text = $"Watering: {reader["WateringFrequency"] ?? "N/A"}";
                            lblFertilizationFrequency.Text = $"Fertilizing: {reader["FertilizationFrequency"] ?? "N/A"}";
                            lblDescription.Text = $"Description: {reader["Description"] ?? "N/A"}";
                            lblTemperature.Text = $"Optimal Temperature: {reader["OptimalTemperature"] ?? "N/A"}";
                            lblSunlight.Text = $"Sunlight Requirement: {reader["SunlightRequirement"] ?? "N/A"}";
                            lblSoil.Text = $"Soil Type: {reader["SoilType"] ?? "N/A"}";
                            lblHeight.Text = $"Height: {reader["Height"] ?? "N/A"}";
                            lblGrowthRate.Text = $"Growth Rate: {reader["GrowthRate"] ?? "N/A"}";
                            lblFlowering.Text = $"Flowering Season: {reader["FloweringSeason"] ?? "N/A"}";
                            lblHumidity.Text = $"Humidity: {reader["Humidity"] ?? "N/A"}";
                            lblPruning.Text = $"Pruning Requirements: {reader["PruningRequirements"] ?? "N/A"}";
                           
                            if (!(reader["PlantImage"] is DBNull))
                            {
                                byte[] imageData = (byte[])reader["PlantImage"];

                                using (MemoryStream ms = new MemoryStream(imageData))
                                {
                                    pictureBox1.Image = Image.FromStream(ms); 
                                }
                            }
                            else
                            {
                                pictureBox1.Image = null;
                            }
                        }
                    }
                }
            }
        }
    }
}
