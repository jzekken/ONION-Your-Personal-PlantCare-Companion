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
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;


namespace ONION_Your_Personal_PlantCare_Companion
{
    public partial class HomeControl1 : BaseUserControl
    {

        public HomeControl1()
        {
            InitializeComponent();
            LoadPlants();

        }

        private async void LoadPlants()
        {
            try
            {
                flowLayoutPanel1.Controls.Clear();
                ds.Clear();

                string query = @"SELECT 
                                p.PlantID, 
                                p.PlantName, 
                                p.WateringFrequency, 
                                p.FertilizationSchedule, 
                                p.PlantImage, 
                                p.LastWatered, 
                                p.LastFertilized, 
                                h.HealthChange
                            FROM 
                                Plants AS p
                            INNER JOIN 
                                HealthHistory AS h ON p.PlantID = h.PlantID
                            WHERE 
                                h.ActionType = 'Health Updated' AND 
                                h.RecordedDate = (
                                    SELECT MAX(h2.RecordedDate)
                                    FROM HealthHistory AS h2
                                    WHERE h2.PlantID = p.PlantID AND h2.ActionType = 'Health Updated'
                                );
                            ";

                DataTable plantsTable = await FetchDataAsync(query);


                foreach (DataRow row in plantsTable.Rows)
                {
                    homeplant plantControl = new homeplant
                    {
                        PlantName = row["PlantName"]?.ToString() ?? "Unknown Plant",
                        HealthPercentage = row["HealthChange"] != DBNull.Value ? Convert.ToInt32(row["HealthChange"]) : 0,
                        PlantImage = row["PlantImage"] != DBNull.Value ? Image.FromStream(new MemoryStream((byte[])row["PlantImage"])) : null,
                        LastWatered = row["LastWatered"] != DBNull.Value ? Convert.ToDateTime(row["LastWatered"]) : DateTime.MinValue,
                        LastFertilized = row["LastFertilized"] != DBNull.Value ? Convert.ToDateTime(row["LastFertilized"]) : DateTime.MinValue
                    };
                    plantControl.PlantID = row["PlantID"] != DBNull.Value ? Convert.ToInt32(row["PlantID"]) : 0;

                    flowLayoutPanel1.Controls.Add(plantControl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading plants: " + ex.Message);
            }
        }

        
    }

}
