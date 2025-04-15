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

namespace ONION_Your_Personal_PlantCare_Companion
{
    public partial class PlantIdentifier : Form
    {
        private List<(string commonName, string sciName, double confidence)> _suggestions = new();
        private string _imagePath;
        private readonly HttpClient _client;

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

            await LoadSuggestionsAsync(_imagePath);
        }
        private async Task LoadSuggestionsAsync(string imagePath)
        {
            var apiUrl = "https://api.plant.id/v2/identify";

            using (var content = new MultipartFormDataContent())
            {
                _client.DefaultRequestHeaders.Clear();
                _client.DefaultRequestHeaders.Add("Api-Key", "YgqYVC2GqcMGNNEyeqoxbIrA9HIzBlNZrDpXH7RB8votwVo1Ad");

                var fileContent = new ByteArrayContent(File.ReadAllBytes(imagePath));
                fileContent.Headers.Add("Content-Type", "image/jpeg");
                content.Add(fileContent, "images", Path.GetFileName(imagePath));

                var response = await _client.PostAsync(apiUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var json = JObject.Parse(jsonString);
                    var suggestions = json["suggestions"];

                    _suggestions.Clear();
                    lstSuggestions.Items.Clear();

                    foreach (var s in suggestions)
                    {
                        string commonName = (string)s["plant_details"]?["common_names"]?.First ?? "N/A";
                        string sciName = (string)s["plant_details"]?["scientific_name"] ?? "Unknown";
                        double confidence = (double?)s["probability"] ?? 0;

                        _suggestions.Add((commonName, sciName, confidence));
                        lstSuggestions.Items.Add($"{sciName} ({Math.Round(confidence * 100, 2)}%)");
                    }
                }
                else
                {
                    MessageBox.Show("API Error: " + response.ReasonPhrase);
                }
            }
        }
        
        private async Task<string> IdentifyPlantAsync(string imagePath)
        {
            var apiUrl = "https://api.plant.id/v2/identify";

            using (var content = new MultipartFormDataContent())
            {
                _client.DefaultRequestHeaders.Clear(); // clear any previous headers
                _client.DefaultRequestHeaders.Add("Api-Key", "YgqYVC2GqcMGNNEyeqoxbIrA9HIzBlNZrDpXH7RB8votwVo1Ad"); // replace with your actual key

                var fileContent = new ByteArrayContent(File.ReadAllBytes(imagePath));
                fileContent.Headers.Add("Content-Type", "image/jpeg");
                content.Add(fileContent, "images", Path.GetFileName(imagePath));

                var response = await _client.PostAsync(apiUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    var json = JObject.Parse(jsonString);
                    string plantName = (string)json["suggestions"]?[0]?["plant_name"];
                    return plantName ?? "Unknown";
                }
                else
                {
                    return "Error: " + response.ReasonPhrase;
                }
            }
        }

        private void exitbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void lstSuggestions_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int index = lstSuggestions.SelectedIndex;
            if (index >= 0 && index < _suggestions.Count)
            {
                var selected = _suggestions[index];
                lblDetails.Text = //$"Common Name: {selected.commonName}\n" +
                                  $"Scientific Name: {selected.sciName}\n" +
                                  $"Confidence: {Math.Round(selected.confidence * 100, 2)}%";
            }
        }
    }
}
