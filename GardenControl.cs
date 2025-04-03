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
    public partial class GardenControl : UserControl
    {
        private string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\ACER ASPIRE 3\Source\Repos\ONION-Your-Personal-PlantCare-Companion\Resources\PlantData.accdb;";
        public GardenControl()
        {
            InitializeComponent();
            LoadPlants();
        }

        public void LoadPlants()
        {
            int[] validCols = { 1, 2, 3 }; 
            int[] validRows = { 1, 2, 3 }; 
            int plantCount = 0;

            List<Plant> plants = GetStoredPlants();
            tableLayoutPanel1.Controls.Clear();

            for (int r = 0; r < validRows.Length; r++)
            {
                for (int c = 0; c < validCols.Length; c++)
                {
                    if (plantCount < plants.Count)
                    {
                        PottedPlants plantControl = new PottedPlants();
                        plantControl.SetPlantData(plants[plantCount]);
                        tableLayoutPanel1.Controls.Add(plantControl, validCols[c], validRows[r]);
                        plantCount++;
                    }
                    else
                    {
                        PictureBox placeholder = new PictureBox
                        {
                            Image = LoadBlankPlateImage(),
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Dock = DockStyle.Fill
                        };
                        tableLayoutPanel1.Controls.Add(placeholder, validCols[c], validRows[r]);
                    }
                }
            }
        }

        private List<Plant> GetStoredPlants()
        {
            List<Plant> plants = new List<Plant>();

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                string query = "SELECT PlantID, PlantName, LastWatered, LastFertilized, WateringFrequency, FertilizationSchedule FROM Plants\r\n";
                OleDbCommand cmd = new OleDbCommand(query, conn);

                conn.Open();
                OleDbDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Plant plant = new Plant
                    {
                        PlantID = reader.GetInt32(0),
                        PlantName = reader.GetString(1),
                        LastWatered = reader.IsDBNull(2) ? DateTime.MinValue : reader.GetDateTime(2),
                        LastFertilized = reader.IsDBNull(3) ? DateTime.MinValue : reader.GetDateTime(3),
                        WateringFrequency = reader.IsDBNull(4) ? 0 : Convert.ToInt32(reader[4]),
                        FertilizationFrequency = reader.IsDBNull(5) ? 0 : Convert.ToInt32(reader[5]),
                       

                    };
                    plants.Add(plant);
                }

                reader.Close();
            }

            return plants;
        }
        

        private Image LoadBlankPlateImage()
        {
            string imagePath = Path.Combine(Application.StartupPath, "Resources", "BlankPlate.png");
            return File.Exists(imagePath) ? Image.FromFile(imagePath) : null;
        }
    }
}
