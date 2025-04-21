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

    public partial class Form2 : BaseForm
    {
        private Button activeButton;
        private WaveInEvent waveIn;
        private VoskRecognizer recognizer;
        private Model model;
        private bool isVoiceEnabled = true;

        public Form2()
        {
            InitializeComponent();
            this.Opacity = 0;
            fadeInTimer.Start();
            timer.Interval = 1000; // 1000 milliseconds = 1 second
            timer.Tick += timer_Tick;
            timer.Start(); // Start the timer

            // Optional: Set initial date and time
            lblDateTime.Text = DateTime.Now.ToString("F");
            EnableDoubleBuffering();
            LoadUserControl(new HomeControl1(), homebtn);
            InitializeVoiceRecognition();
        }
        private void EnableDoubleBuffering()
        {
            mainPanel.GetType().GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic)
                .SetValue(mainPanel, true, null);
        }

        private async void InitializeVoiceRecognition()
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
                LoadUserControl(new TalkControl(), talkbtn);
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
            else if (command.Contains("open list") || command.Contains("list of plants"))
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
            }
            else if (command.Contains("normal") || command.Contains("return"))
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private async void LoadUserControl(UserControl userControl, Button clickedButton)
        {
            if (mainPanel.Controls.Count > 0)
            {
                var currentControl = mainPanel.Controls[0];


                for (int i = 100; i >= 0; i -= 25)
                {
                    currentControl.BackColor = Color.FromArgb(i * 255 / 100, currentControl.BackColor);
                    await Task.Delay(5);
                }

                mainPanel.Controls.Clear();
                currentControl.Dispose();
            }

            mainPanel.SuspendLayout();
            userControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(userControl);
            userControl.BringToFront();
            mainPanel.ResumeLayout();
            mainPanel.Refresh();


            for (int i = 0; i <= 100; i += 25)
            {
                userControl.BackColor = Color.FromArgb(i * 255 / 100, userControl.BackColor);
                await Task.Delay(5);
            }


            if (activeButton != null)
                activeButton.BackColor = Color.FromArgb(224, 239, 204);

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

        private void toggleVoiceBtn_Click(object sender, EventArgs e)
        {
            if (isVoiceEnabled)
            {
                waveIn.StopRecording();
                toggleVoiceBtn.Text = "Enable Voice";
                toggleVoiceBtn.BackColor = Color.Red; // Red when disabled
            }
            else
            {
                waveIn.StartRecording();
                toggleVoiceBtn.Text = "Disable Voice";
                toggleVoiceBtn.BackColor = Color.FromArgb(224, 239, 204);
            }

            isVoiceEnabled = !isVoiceEnabled;
        }

        private void fadeInTimer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.02; // Adjust this value for faster/slower fade
            }
            else
            {
                fadeInTimer.Stop(); // Stop the timer once the form is fully visible
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("F");
        }
    }
}
