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

            double daysSinceHealthCheck = (DateTime.Now - plantData.LastHealthCheck).TotalDays;

            if (daysSinceHealthCheck >= 1)
            {
                double overdueWater = (DateTime.Now - plantData.LastWatered).TotalDays - plantData.WateringFrequency;
                double overdueFertilizer = (DateTime.Now - plantData.LastFertilized).TotalDays - plantData.FertilizationSchedule;

                int totalDecay = 0;

                if (overdueWater > 0)
                    totalDecay += (int)Math.Floor(overdueWater);

                if (overdueFertilizer > 0)
                    totalDecay += (int)Math.Floor(overdueFertilizer);

                if (totalDecay > 0)
                {
                    ApplyHealthDecay(totalDecay);
                    UpdatePlantHealthInDatabase();
                }
            }

            CheckPlantCareStatus();
            UpdatePlantImage();
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
            return (DateTime.Now - plantData.LastFertilized).TotalDays >= plantData.FertilizationSchedule;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CanWater())
            {
                plantData.LastWatered = DateTime.Now;
                SavePlantAction("Watered");
                RegenerateHealth();  // Regenerate health after watering
                UpdatePlantHealthInDatabase();  // Update health and insert history
                  
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

                    string columnToUpdate = actionType == "Watered" ? "LastWatered" : "LastFertilized";
                    string updateQuery = $"UPDATE Plants SET {columnToUpdate} = ? WHERE PlantID = ?";

                    using (OleDbCommand updateCmd = new OleDbCommand(updateQuery, conn))
                    {
                        updateCmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now;
                        updateCmd.Parameters.Add("?", OleDbType.Integer).Value = plantData.PlantID;
                        updateCmd.ExecuteNonQuery();
                    }

                    string insertQuery = "INSERT INTO HealthHistory (PlantID, RecordedDate, ActionType) VALUES (?, ?, ?)";

                    using (OleDbCommand insertCmd = new OleDbCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.Add("?", OleDbType.Integer).Value = plantData.PlantID;
                        insertCmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now;
                        insertCmd.Parameters.Add("?", OleDbType.VarChar).Value = actionType;
                        insertCmd.ExecuteNonQuery();
                    }
                }

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
                RegenerateHealth();
                UpdatePlantHealthInDatabase();
                MessageBox.Show("Plant fertilized successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("The plant was fertilized within the last 24 hours. No need to fertilize it now.", "Action Not Needed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void RegenerateHealth()
        {
            if (plantData.Health < 100)
            {
                plantData.Health += 10;  // Example: Increase health by 10% after watering/fertilizing
                if (plantData.Health > 100)
                {
                    plantData.Health = 100;  // Cap health to 100%
                }
            }
        }

        private void ApplyHealthDecay(int amount)
        {
            plantData.Health -= amount * 5;
            if (plantData.Health < 0)
            {
                plantData.Health = 0;
            }
        }
        private void UpdatePlantHealthInDatabase()
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();

                    string updateQuery = "UPDATE Plants SET Health = ?, LastHealthCheck = ? WHERE PlantID = ?";
                    using (OleDbCommand updateCmd = new OleDbCommand(updateQuery, conn))
                    {
                        updateCmd.Parameters.Add("?", OleDbType.Integer).Value = plantData.Health;
                        updateCmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now;
                        updateCmd.Parameters.Add("?", OleDbType.Integer).Value = plantData.PlantID;
                        updateCmd.ExecuteNonQuery();
                    }

                    string insertHistoryQuery = "INSERT INTO HealthHistory (PlantID, ActionType, HealthChange, RecordedDate) VALUES (?, ?, ?, ?)";
                    using (OleDbCommand insertCmd = new OleDbCommand(insertHistoryQuery, conn))
                    {
                        insertCmd.Parameters.Add("?", OleDbType.Integer).Value = plantData.PlantID;
                        insertCmd.Parameters.Add("?", OleDbType.VarChar).Value = "Health Updated";
                        insertCmd.Parameters.Add("?", OleDbType.Integer).Value = plantData.Health;
                        insertCmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now;
                        insertCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating plant health and inserting history: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void UpdatePlantImage()
        {
            seedlingPictureBox.Visible = false;
            babyPlantPictureBox.Visible = false;
            healthyPlantPictureBox.Visible = false;
            unhealthyPlantPictureBox.Visible = false;
            deadPlantPictureBox.Visible = false;

            double plantAge = (DateTime.Now - plantData.DatePlanted).TotalDays;
            if (plantAge < 30)
            {
                seedlingPictureBox.Visible = true;
            }
            else if (plantAge < 60)
            {
                babyPlantPictureBox.Visible = true;
            }
            else
            {
                healthyPlantPictureBox.Visible = true;
            }

            if (plantData.Health >= 80)
            {
                healthyPlantPictureBox.Visible = true;
            }
            else if (plantData.Health >= 50)
            {
                unhealthyPlantPictureBox.Visible = true;
            }
            else
            {
                deadPlantPictureBox.Visible = true;
            }
        }
    }
}
