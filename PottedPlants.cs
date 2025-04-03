using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONION_Your_Personal_PlantCare_Companion
{
    public partial class PottedPlants : UserControl
    {
        private Plant plantData;
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ACER ASPIRE 3\Source\Repos\ONION-Your-Personal-PlantCare-Companion\Resources\PlantData.accdb;";
        public PottedPlants()
        {
            InitializeComponent();
            this.Size = new Size(155, 155);
            this.MaximumSize = new Size(155, 155);
            this.MinimumSize = new Size(155, 155);
        }
        public void SetPlantData(Plant plant)
        {
            this.plantData = plant;

            plantNameLabel.Text = plant.PlantName;

            CheckPlantCareStatus();
        }
        private void CheckPlantCareStatus()
        {
            if (NeedsWatering() || NeedsFertilizing())
            {
                exclamationPictureBox.Visible = true;
            }
            else
            {
                exclamationPictureBox.Visible = false;
            }
        }
        private bool CanWater()
        {
            // Ensure that the plant needs watering (24 hours since the last watering)
            return (DateTime.Now - plantData.LastWatered).TotalDays >= 1;
        }

        private bool CanFertilize()
        {
            // Ensure that the plant needs fertilizing (24 hours since the last fertilization)
            return (DateTime.Now - plantData.LastFertilized).TotalDays >= 1;
        }
        private bool NeedsWatering()
        {
            return (DateTime.Now - plantData.LastWatered).TotalDays >= plantData.WateringFrequency;
        }

        private bool NeedsFertilizing()
        {
            return (DateTime.Now - plantData.LastFertilized).TotalDays >= plantData.FertilizationFrequency;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CanWater())
            {
                plantData.LastWatered = DateTime.Now;
                SavePlantAction("Watered");
                CheckPlantCareStatus();
                MessageBox.Show("Plant watered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The plant was watered within the last 24 hours. No need to water it now.", "Action Not Needed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SavePlantAction(string actionType)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();

                    // Determine the column to update based on action type
                    string columnToUpdate = actionType == "Watered" ? "LastWatered" : "LastFertilized";
                    string updateQuery = $"UPDATE Plants SET {columnToUpdate} = ? WHERE PlantID = ?";

                    using (OleDbCommand updateCmd = new OleDbCommand(updateQuery, conn))
                    {
                        // Explicitly setting parameter types for OleDb
                        updateCmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now;
                        updateCmd.Parameters.Add("?", OleDbType.Integer).Value = plantData.PlantID;
                        updateCmd.ExecuteNonQuery();
                    }

                    // Insert into HealthHistory table
                    string insertQuery = "INSERT INTO HealthHistory (PlantID, RecordedDate, ActionType) VALUES (?, ?, ?)";

                    using (OleDbCommand insertCmd = new OleDbCommand(insertQuery, conn))
                    {
                        // Explicitly setting parameter types for OleDb
                        insertCmd.Parameters.Add("?", OleDbType.Integer).Value = plantData.PlantID;
                        insertCmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now;
                        insertCmd.Parameters.Add("?", OleDbType.VarChar).Value = actionType;
                        insertCmd.ExecuteNonQuery();
                    }
                }

                // Refresh plant status in UI
                CheckPlantCareStatus();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving plant action: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CanFertilize())
            {
                plantData.LastFertilized = DateTime.Now;
                SavePlantAction("Fertilized");
                MessageBox.Show("Plant fertilized successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The plant was fertilized within the last 24 hours. No need to fertilize it now.", "Action Not Needed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
