using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveChartsCore.SkiaSharpView.WinForms;
using LiveChartsCore;
using SkiaSharp;
using LiveChartsCore.SkiaSharpView.Painting;
using LiveChartsCore.SkiaSharpView;
using System.Data.OleDb;

namespace ONION_Your_Personal_PlantCare_Companion
{
    public partial class Doubleclick : Form
    {
        private int plantID;
        public Doubleclick(int plantID, string plantName, Image plantImage, DateTime lastWatered, DateTime lastFertilized, int healthPercentage)
        {
            InitializeComponent();
            this.plantID = plantID;
            lblName.Text = plantName;
            picImage.Image = plantImage;
            lblLastWatered.Text = "Last Watered: " + lastWatered.ToString("MM/dd/yyyy");
            lblLastFertilized.Text = "Last Fertilized: " + lastFertilized.ToString("MM/dd/yyyy");
            progressBar.Value = healthPercentage;

            LoadHealthData(plantID);
        }

        private async void LoadHealthData(int plantID)
        {
            // Updated SQL query to fetch relevant health data
            string query = @"
        SELECT 
            h.RecordedDate, 
            h.HealthChange
        FROM 
            HealthHistory AS h
        WHERE 
            h.PlantID = ? AND 
            h.RecordedDate >= DateAdd('d', -7, Now()) AND
            h.HealthChange > 0 
        ORDER BY 
            h.RecordedDate DESC;";

            try
            {
                // Fetch data asynchronously using FetchDataAsync
                DataTable healthData = await FetchDataAsync(query, plantID);

                if (healthData.Rows.Count == 0)
                {
                    MessageBox.Show("No data available for this plant.");
                    return;
                }

                // Prepare the data for the chart
                var dates = healthData.AsEnumerable()
                    .Select(row => row.Field<DateTime>("RecordedDate").ToString("MM/dd/yyyy"))
                    .Reverse()  // Reverse to show from oldest to newest on the X-axis
                    .ToList();

                var healthChanges = healthData.AsEnumerable()
                    .Select(row => row.Field<int>("HealthChange"))
                    .Reverse()  // Reverse to match the date order
                    .ToList();

                // Debugging: Check if data is being fetched correctly
                Console.WriteLine("Dates: " + string.Join(", ", dates));
                Console.WriteLine("Health Changes: " + string.Join(", ", healthChanges));

                // Create a new LineSeries to plot the data
                var lineSeries = new LineSeries<int>
                {
                    Values = healthChanges, // The health changes to plot on the Y-axis
                    Stroke = new SolidColorPaint(SKColors.Green), // Color for the line
                    Fill = null // No fill for the area
                };

                // Add the LineSeries to the chart
                cartesianChart1.Series = new ISeries[] { lineSeries };

                // Set the X-Axis (dates) and Y-Axis (health percentage)
                cartesianChart1.XAxes = new List<Axis>
        {
            new Axis
            {
                Name = "Date",
                Labels = dates // The dates will be the labels on the X-axis
            }
        };

                cartesianChart1.YAxes = new List<Axis>
        {
            new Axis
            {
                Name = "Health",
                MinLimit = 0, // Min limit for health
                MaxLimit = 100 // Max limit for health
            }
        };
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading health data: " + ex.Message);
            }
        }


        // Method to fetch data from the database
        private async Task<DataTable> FetchDataAsync(string query, int plantID)
        {
            using (var connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\"C:\\Users\\ACER ASPIRE 3\\source\\repos\\ONION-Your-Personal-PlantCare-Companion\\Resources\\PlantData.accdb\""))
            {
                await connection.OpenAsync();
                var command = new OleDbCommand(query, connection);

                // Add parameter for plantID
                command.Parameters.AddWithValue("?", plantID);

                // Execute the query and return the result as DataTable
                var dataTable = new DataTable();
                using (var reader = await command.ExecuteReaderAsync())
                {
                    dataTable.Load(reader);
                }

                return dataTable;
            }
        }




        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
