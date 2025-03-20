using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONION_Your_Personal_PlantCare_Companion
{
    public partial class TalkControl : UserControl
    {
        private static readonly HttpClient client = new HttpClient();
        private const string API_KEY = "AIzaSyD4M-16yXP2gaFFNKHS1EJqDpzatCqXJqM";  
        private const string API_URL = "https://generativelanguage.googleapis.com/v1beta/models/gemini-2.0-flash:generateContent?key=" + API_KEY;
        public TalkControl()
        {
            InitializeComponent();
            
        }

        private void inc1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //addOutgoing(txtUserInput.Text);  
            //txtUserInput.Text = string.Empty;
            //string userMessage = txtUserInput.Text.Trim();
            //if (string.IsNullOrEmpty(userMessage)) return;

            //rtbChat.AppendText($"You: {userMessage}\n");
            //txtUserInput.Clear();

            //string botResponse = await GetAIResponse(userMessage);
            //rtbChat.AppendText($"Onion: {botResponse}\n");

            string userMessage = txtUserInput.Text.Trim();
            if (string.IsNullOrEmpty(userMessage)) return;

            AddOutgoingMessage(userMessage);  // Show user's message as a bubble
            txtUserInput.Clear();

            string botResponse = await GetAIResponse(userMessage);
            AddIncomingMessage(botResponse);
        }
        private void AddIncomingMessage(string message)
        {
            var bubble = new Chat.IncomingBubble();
            bubble.Message = message;

            panelContainer.Invoke((MethodInvoker)delegate
            {
                bubble.Anchor = AnchorStyles.Left;
                panelContainer.RowCount++;
                panelContainer.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                panelContainer.Controls.Add(bubble, 0, panelContainer.RowCount - 1);
                panelContainer.PerformLayout();
                panelContainer.ScrollControlIntoView(bubble);
            });
        }


        private void AddOutgoingMessage(string message)
        {
            var bubble = new Chat.OutgoingBubble();
            bubble.Message = message;

            panelContainer.Invoke((MethodInvoker)delegate
            {
                bubble.Anchor = AnchorStyles.Right;
                panelContainer.RowCount++;
                panelContainer.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                panelContainer.Controls.Add(bubble, 1, panelContainer.RowCount - 1);
                panelContainer.PerformLayout();
                panelContainer.ScrollControlIntoView(bubble);
            });
        }


        private async Task<string> GetAIResponse(string userMessage)
        {
            try
            {
                var requestBody = new
                {
                    contents = new[]
                    {
                new { parts = new[] { new { text = userMessage } } }
            }
                };

                var content = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(API_URL, content);
                string jsonResponse = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Response: {jsonResponse}");  // Debugging ina

                if (!response.IsSuccessStatusCode)
                    return $"Error: {response.StatusCode} - {jsonResponse}";

                dynamic result = JsonConvert.DeserializeObject(jsonResponse);
                string message = result?.candidates?[0]?.content?.parts?[0]?.text ?? "No response.";
                message = System.Text.RegularExpressions.Regex.Replace(message, @"[*_`]", "");
                return message;
            }
            catch (Exception ex)
            {
                return $"Exception: {ex.Message}";
            }
        }
    }
}
