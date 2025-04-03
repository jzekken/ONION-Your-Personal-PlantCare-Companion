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
    public partial class HomeControl1 : UserControl
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        DataSet? ds;
        public HomeControl1()
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

                string query = @"SELECT 
                                p.PlantID, 
                                p.PlantName, 
                                p.WateringFrequency, 
                                p.FertilizationSchedule, 
                                p.PlantImage, 
                                p.LastWatered,
                                p.LastFertilized,
                                h.HealthValue
                            FROM 
                                (Plants AS p
                            INNER JOIN 
                                HealthHistory AS h
                            ON p.PlantID = h.PlantID)
                            WHERE 
                                h.RecordedDate = 
                                (SELECT MAX(RecordedDate) FROM HealthHistory WHERE PlantID = p.PlantID);
                            ";
                    
                da = new OleDbDataAdapter(query, myConn);
                ds = new DataSet();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error initializing database: " + ex.Message);
            }
        }
        private async void LoadPlants()
        {
            try
            {
                flowLayoutPanel1.Controls.Clear();
                ds.Clear();

                await Task.Run(() =>
                {
                    myConn.Open();
                    da.Fill(ds, "Plants");
                    myConn.Close();
                });

                foreach (DataRow row in ds.Tables["Plants"].Rows)
                {
                    homeplant plantControl = new homeplant
                    {
                        PlantName = row["PlantName"].ToString(),
                        HealthPercentage = Convert.ToInt32(row["HealthValue"]),
                        PlantImage = row["PlantImage"] != DBNull.Value ? Image.FromStream(new MemoryStream((byte[])row["PlantImage"])) : null,
                        LastWatered = Convert.ToDateTime(row["LastWatered"]),
                        LastFertilized = Convert.ToDateTime(row["LastFertilized"])
                    };

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
