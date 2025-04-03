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
        private void LoadPlants()
        {
            try
            {
                
                flowLayoutPanel1.Controls.Clear();
                ds.Clear();

                
                myConn.Open();
                da.Fill(ds, "Plants");

                
                foreach (DataRow row in ds.Tables["Plants"].Rows)
                {
                    
                    homeplant plantControl = new homeplant
                    {
                        PlantName = row["PlantName"].ToString(),
                        HealthPercentage = Convert.ToInt32(row["HealthValue"]) 
                    };

                    
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
            catch (Exception ex)
            {
                MessageBox.Show("Error loading plants: " + ex.Message);
            }
            finally
            {
                
                if (myConn.State == ConnectionState.Open)
                {
                    myConn.Close();
                }
            }
        }


    }

}
