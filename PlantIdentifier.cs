using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using AForge.Video;
using AForge.Video.DirectShow;

namespace ONION_Your_Personal_PlantCare_Companion
{
    public partial class PlantIdentifier : Form
    {

        private string _imagePath;
        private readonly HttpClient _client;
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        private Bitmap currentFrame;
        private bool isCameraRunning = false;
        public PlantIdentifier()
        {
            InitializeComponent();
            _client = new HttpClient();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;",
                Title = "Select a Plant Image"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _imagePath = openFileDialog.FileName;
                pictureBox.ImageLocation = _imagePath;
            }
        }

        private async void btnIdentifyPlant_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_imagePath))
            {
                MessageBox.Show("Please select an image to upload.");
                return;
            }

            await IdentifyPlantAsync(_imagePath);
        }



        private async Task IdentifyPlantAsync(string imagePath)
        {
            var apiUrl = "https://api.plant.id/v2/identify";

            using (var content = new MultipartFormDataContent())
            {
                _client.DefaultRequestHeaders.Clear();
                _client.DefaultRequestHeaders.Add("Api-Key", Properties.Settings.Default.PlantIDApiKey);

                var fileContent = new ByteArrayContent(File.ReadAllBytes(imagePath));
                fileContent.Headers.Add("Content-Type", "image/jpeg");
                content.Add(fileContent, "images", Path.GetFileName(imagePath));

                
                var plantDetailsArray = new JArray
        {
            "common_names",
            "url",
            "taxonomy",
            "health_assessment"
        };

                var plantDetailsJson = plantDetailsArray.ToString();
                content.Add(new StringContent(plantDetailsJson, Encoding.UTF8, "application/json"), "plant_details");

                
                content.Add(new StringContent("en"), "plant_language");

                var response = await _client.PostAsync(apiUrl, content);

                if (!response.IsSuccessStatusCode)
                {
                    string errorContent = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"API Error: {response.StatusCode}\n\n{errorContent}");
                    return;
                }

                string responseBody = await response.Content.ReadAsStringAsync();
                JObject json = JObject.Parse(responseBody);

                
                var suggestion = json["suggestions"]?.FirstOrDefault();
                var details = suggestion?["plant_details"];

                string sciName = (string)suggestion?["plant_name"] ?? "Unknown";
                string commonName = details?["common_names"]?.FirstOrDefault()?.ToString() ?? "N/A";

                var taxonomy = details?["taxonomy"];
                string taxonomyStr = taxonomy != null
                    ? $"Kingdom: {taxonomy["kingdom"]}\nPhylum: {taxonomy["phylum"]}\nClass: {taxonomy["class"]}\nOrder: {taxonomy["order"]}\nFamily: {taxonomy["family"]}\nGenus: {taxonomy["genus"]}"
                    : "Not available";

                var health = details?["health_assessment"];
                string healthStr = health != null
                    ? $"Is Healthy: {health["is_healthy"]}\nDiseases: {string.Join(", ", health["diseases"]?.Select(d => d["name"]))}"
                    : "Health Status: Not available";

                
                double confidence = (double?)suggestion?["probability"] ?? 0;
                string confidenceStr = $"Confidence: {Math.Round(confidence * 100, 2)}%";

               
                lblCommonName.Text = $"Common Name: {commonName}";
                lblScientificName.Text = $"Scientific Name: {sciName}";
                lblTaxonomy.Text = taxonomyStr;
                lblHealth.Text = healthStr;
                lblConfidence.Text = confidenceStr; 
            }
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cambtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isCameraRunning)
                {
                    videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                    if (videoDevices.Count == 0)
                    {
                        MessageBox.Show("No camera found!");
                        return;
                    }

                    videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                    videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);
                    videoSource.Start();
                    isCameraRunning = true;
                }
                else
                {
                    if (currentFrame != null)
                    {
                        
                        string tempPath = Path.Combine(Path.GetTempPath(), "captured_plant.jpg");
                        currentFrame.Save(tempPath, System.Drawing.Imaging.ImageFormat.Jpeg);

                        
                        _imagePath = tempPath;

                        
                        pictureBox.Image = (Bitmap)currentFrame.Clone();
                    }

                    if (videoSource != null && videoSource.IsRunning)
                    {
                        videoSource.SignalToStop();
                        videoSource.NewFrame -= video_NewFrame;
                    }

                    isCameraRunning = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Camera error: " + ex.Message);
            }
        }
        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            currentFrame = (Bitmap)eventArgs.Frame.Clone();
            pictureBox.Image = (Bitmap)currentFrame.Clone();
        }
    }
}
