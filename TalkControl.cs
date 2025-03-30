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

        private List<(string sender, string message)> chatHistory = new List<(string, string)>();
        private readonly string historyFilePath = Path.Combine(Application.StartupPath, "chatHistory.json");
        public TalkControl()
        {
            InitializeComponent();
            LoadChatHistory();
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
            chatHistory.Add(("You", userMessage));  // Save to history
            SaveChatHistory();
            txtUserInput.Clear();

            string botResponse = await GetAIResponse(userMessage);
            AddIncomingMessage(botResponse);
            chatHistory.Add(("Onion", botResponse));  // Save to history
            SaveChatHistory();
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
                // Prepare the chat history for context
                var chatContext = new List<object>();

                // Add the previous conversation history (last 10 exchanges)
                foreach (var (sender, msg) in chatHistory.TakeLast(10))  // Renamed 'message' to 'msg'
                {
                    chatContext.Add(new
                    {
                        role = sender == "You" ? "user" : "model",
                        parts = new[] { new { text = msg } }  // Use 'msg' here
                    });
                }

                // Add the current user message
                chatContext.Add(new
                {
                    role = "user",
                    parts = new[] { new { text = userMessage } }
                });

                // Prepare the request body
                var requestBody = new { contents = chatContext };

                var content = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(API_URL, content);
                string jsonResponse = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Response: {jsonResponse}");

                if (!response.IsSuccessStatusCode)
                    return $"Error: {response.StatusCode} - {jsonResponse}";

                dynamic result = JsonConvert.DeserializeObject(jsonResponse);

                // Extract the AI's response message
                string aiResponse = result?.candidates?[0]?.content?.parts?[0]?.text ?? "No response.";
                aiResponse = System.Text.RegularExpressions.Regex.Replace(aiResponse, @"[*_`]", "");  // Clean up formatting
                return aiResponse;
            }
            catch (Exception ex)
            {
                return $"Exception: {ex.Message}";
            }
        }



        //private async Task<string> GetAIResponse(string userMessage)
        //{
        //    try
        //    {
        //        var requestBody = new
        //        {
        //            contents = new[]
        //            {
        //        new { parts = new[] { new { text = userMessage } } }
        //    }
        //        };

        //        var content = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json");

        //        HttpResponseMessage response = await client.PostAsync(API_URL, content);
        //        string jsonResponse = await response.Content.ReadAsStringAsync();
        //        Console.WriteLine($"Response: {jsonResponse}");  // Debugging ina

        //        if (!response.IsSuccessStatusCode)
        //            return $"Error: {response.StatusCode} - {jsonResponse}";

        //        dynamic result = JsonConvert.DeserializeObject(jsonResponse);
        //        string message = result?.candidates?[0]?.content?.parts?[0]?.text ?? "No response.";
        //        message = System.Text.RegularExpressions.Regex.Replace(message, @"[*_`]", "");
        //        return message;
        //    }
        //    catch (Exception ex)
        //    {
        //        return $"Exception: {ex.Message}";
        //    }
        //}

        private void TalkControl_Load(object sender, EventArgs e)
        {
            DisplayChatHistory();
        }
        private void SaveChatHistory()
        {
            try
            {
                string json = JsonConvert.SerializeObject(chatHistory, Formatting.Indented);
                File.WriteAllText(historyFilePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save chat history: {ex.Message}");
            }
        }

        private void LoadChatHistory()
        {
            try
            {
                if (File.Exists(historyFilePath))
                {
                    string json = File.ReadAllText(historyFilePath);
                    chatHistory = JsonConvert.DeserializeObject<List<(string sender, string message)>>(json) ?? new List<(string, string)>();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load chat history: {ex.Message}");
            }
        }
        private void DisplayChatHistory()
        {
            panelContainer.Controls.Clear();
            panelContainer.RowCount = 0;

            foreach (var (sender, message) in chatHistory)
            {
                if (sender == "You")
                {
                    AddOutgoingMessage(message);
                }
                else
                {
                    AddIncomingMessage(message);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to clear the chat history?",
                                "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                chatHistory.Clear();
                SaveChatHistory();
                DisplayChatHistory();
                MessageBox.Show("Chat history cleared.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
