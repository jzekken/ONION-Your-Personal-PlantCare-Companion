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
using Vosk;
using NAudio.Wave;

namespace ONION_Your_Personal_PlantCare_Companion
{

    public partial class TalkControl : UserControl
    {
        private static readonly HttpClient client = new HttpClient();
        private readonly string API_URL = "https://generativelanguage.googleapis.com/v1beta/models/gemini-2.0-flash:generateContent?key=" + Properties.Settings.Default.GoogleAPIKey;



        private List<(string sender, string message)> chatHistory = new List<(string, string)>();
        private readonly string historyFilePath = Path.Combine(Application.StartupPath, "chatHistory.json");

        private WaveInEvent waveIn;
        private VoskRecognizer recognizer;
        private Model model;
        private bool isListening = false;
        public TalkControl()
        {
            InitializeComponent();
            LoadChatHistory();
            
        }
        private async Task InitializeVoiceRecognition()
        {
            try
            {
                await Task.Run(() =>
                {
                    model = new Model(Path.Combine(Application.StartupPath, "VoskModel"));
                    recognizer = new VoskRecognizer(model, 16000.0f);
                });

                waveIn = new WaveInEvent
                {
                    DeviceNumber = 0,
                    WaveFormat = new WaveFormat(16000, 1)
                };

                waveIn.DataAvailable += (sender, e) =>
                {
                    if (recognizer.AcceptWaveform(e.Buffer, e.BytesRecorded))
                    {
                        string result = recognizer.Result();
                        Console.WriteLine($"Recognized: {result}");
                        UpdateTextbox(result);
                    }
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing voice recognition: {ex.Message}");
            }
        }

        private void UpdateTextbox(string recognizedText)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => UpdateTextbox(recognizedText)));
                return;
            }

            // Extract the recognized text from the result
            var resultJson = JsonConvert.DeserializeObject<dynamic>(recognizedText);
            string text = resultJson?.text ?? string.Empty; // Get the recognized text
            text = text.Trim().ToLower();

            // List of trigger keywords for sending
            var sendCommands = new[] { "send", "transmit", "submit", "go", "okay", "confirm" };
            var attachCommands = new[] { "hey onion what plant is this", "identify this plant", "what plant is this" };
            var clearCommands = new[] { "clear message", "delete chat", "erase chat" };
            if (sendCommands.Contains(text))
            {
                btnSend.PerformClick(); // Trigger send
                txtUserInput.Clear();   // Optional: clear input after voice-send
            }
            else if (attachCommands.Contains(text))
            {
                attachbtn.PerformClick();
                txtUserInput.Clear();
            }
            else if (clearCommands.Contains(text))
            {
                clearbtn.PerformClick();
                txtUserInput.Clear();
            }
            else
            {
                txtUserInput.Text = text; // Just update the input
            }
        }



        private async void button1_Click(object sender, EventArgs e)
        {


            string userMessage = txtUserInput.Text.Trim();
            if (string.IsNullOrEmpty(userMessage)) return;

            AddOutgoingMessage(userMessage);
            chatHistory.Add(("You", userMessage));
            SaveChatHistory();
            txtUserInput.Clear();

            string botResponse = await GetAIResponse(userMessage);
            AddIncomingMessage(botResponse);
            chatHistory.Add(("Onion", botResponse));
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

                var chatContext = new List<object>();


                foreach (var (sender, msg) in chatHistory.TakeLast(10))
                {
                    chatContext.Add(new
                    {
                        role = sender == "You" ? "user" : "model",
                        parts = new[] { new { text = msg } }
                    });
                }


                chatContext.Add(new
                {
                    role = "user",
                    parts = new[] { new { text = userMessage } }
                });


                var requestBody = new { contents = chatContext };

                var content = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(API_URL, content);
                string jsonResponse = await response.Content.ReadAsStringAsync();
                Console.WriteLine($"Response: {jsonResponse}");

                if (!response.IsSuccessStatusCode)
                    return $"Error: {response.StatusCode} - {jsonResponse}";

                dynamic result = JsonConvert.DeserializeObject(jsonResponse);


                string aiResponse = result?.candidates?[0]?.content?.parts?[0]?.text ?? "No response.";
                aiResponse = System.Text.RegularExpressions.Regex.Replace(aiResponse, @"[*_`]", "");  // Clean up formatting
                return aiResponse;
            }
            catch (Exception ex)
            {
                return $"Exception: {ex.Message}";
            }
        }

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

        

        private void attachbtn_Click(object sender, EventArgs e)
        {
            PlantIdentifier plantIdentifier = new PlantIdentifier();
            plantIdentifier.ShowDialog();
        }



        private async void toggleVoiceBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (!isListening)
                {
                    if (recognizer == null)
                    {
                        await InitializeVoiceRecognition();
                    }

                    waveIn.StartRecording();
                    toggleVoiceBtn.BackColor = Color.Red;
                    
                    isListening = true;
                }
                else
                {
                    waveIn.StopRecording();
                    toggleVoiceBtn.BackColor = Color.FromArgb(228, 239, 231);
                    isListening = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while toggling voice recording: {ex.Message}");
            }
        }

        private void clearbtn_Click(object sender, EventArgs e)
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
