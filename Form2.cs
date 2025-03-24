using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vosk;
using NAudio.Wave;

namespace ONION_Your_Personal_PlantCare_Companion
{
    public partial class Form2 : Form
    {
        private Button activeButton;
        private WaveInEvent waveIn;
        private VoskRecognizer recognizer;
        private Model model;

        public Form2()
        {
            InitializeComponent();
            LoadUserControl(new HomeControl1(), homebtn);
            InitializeVoiceRecognition();
        }
        private void InitializeVoiceRecognition()
        {
            try
            {
                // Load Vosk model from the VoskModel folder
                model = new Model(Path.Combine(Application.StartupPath, "VoskModel"));

                // Set up microphone input
                waveIn = new WaveInEvent
                {
                    DeviceNumber = 0,
                    WaveFormat = new WaveFormat(16000, 1)
                };

                recognizer = new VoskRecognizer(model, 16000.0f);

                waveIn.DataAvailable += (sender, e) =>
                {
                    if (recognizer.AcceptWaveform(e.Buffer, e.BytesRecorded))
                    {
                        string result = recognizer.Result();
                        Console.WriteLine($"Recognized: {result}");
                        HandleVoiceCommand(result);
                    }
                };

                waveIn.StartRecording();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing voice recognition: {ex.Message}");
            }
        }
        private void HandleVoiceCommand(string command)
        {
            // Convert the recognized command to lowercase
            command = command.ToLower();

            // Use Invoke to ensure UI updates happen on the main thread
            if (InvokeRequired)
            {
                Invoke(new Action(() => HandleVoiceCommand(command)));
                return;
            }

            if (command.Contains("open ai") || command.Contains("a i"))
            {
                LoadUserControl(new TalkControl(), talkbtn);  // Open the Talk tab
            }
            else if (command.Contains("open home") || command.Contains("home"))
            {
                LoadUserControl(new HomeControl1(), homebtn);
            }
            else if (command.Contains("open search") || command.Contains("search"))
            {
                LoadUserControl(new SearchControl(), searchbtn);
            }
            else if (command.Contains("open talk"))
            {
                LoadUserControl(new TalkControl(), talkbtn);
            }
            else if (command.Contains("open list") || command.Contains("list"))
            {
                LoadUserControl(new ListControl(), listbtn);
            }
            else if (command.Contains("open garden") || command.Contains("garden"))
            {
                LoadUserControl(new GardenControl(), gardenbtn);
            }
            else if (command.Contains("open about") || command.Contains("about"))
            {
                LoadUserControl(new AboutControl(), aboutbtn);
            }
            else if (command.Contains("exit") || command.Contains("close"))
            {
                Application.Exit();
            }
            else if (command.Contains("minimize") || command.Contains("reduce"))
            {
                this.WindowState = FormWindowState.Minimized;
            }
            else if (command.Contains("maximize") || command.Contains("expand"))
            {
                this.WindowState = FormWindowState.Maximized;
            }else if(command.Contains("normal") || command.Contains("return"))
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        private void LoadUserControl(UserControl userControl, Button clickedButton)
        {
            mainPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(userControl);

            if (activeButton != null)
            {
                activeButton.BackColor = Color.FromArgb(224, 239, 204);
            }


            clickedButton.BackColor = Color.LightGreen;
            activeButton = clickedButton;
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new HomeControl1(), homebtn);
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new SearchControl(), searchbtn);
        }

        private void talkbtn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new TalkControl(), talkbtn);

        }

        private void listbtn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ListControl(), listbtn);
        }

        private void gardenbtn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new GardenControl(), gardenbtn);
        }

        private void aboutbtn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new AboutControl(), aboutbtn);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minbtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void maxbtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            waveIn?.StopRecording();
            waveIn?.Dispose();
            model?.Dispose();
            base.OnFormClosing(e);
        }
    }
}
