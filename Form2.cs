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
        private bool isVoiceEnabled = true;

        public Form2()
        {
            InitializeComponent();
            MakeFormRounded();
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
        private void MakeFormRounded()
        {
            // Set the form's border style to None to remove the default border
            this.FormBorderStyle = FormBorderStyle.None;

            // Define the radius of the rounded corners
            int radius = 30;

            // Create a GraphicsPath to define the form shape
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();

            // Create a rounded rectangle path
            path.AddArc(0, 0, radius, radius, 180, 90); // top-left corner
            path.AddArc(this.Width - radius - 1, 0, radius, radius, 270, 90); // top-right corner
            path.AddArc(this.Width - radius - 1, this.Height - radius - 1, radius, radius, 0, 90); // bottom-right corner
            path.AddArc(0, this.Height - radius - 1, radius, radius, 90, 90); // bottom-left corner
            path.CloseAllFigures(); // Close the path to create a full rounded rectangle

            // Set the form’s region to the defined path
            this.Region = new Region(path);
        }

        // Optional: Allow resizing of the form (with rounded corners)
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            MakeFormRounded(); // Reapply the rounded corners when the form is resized
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
        //private void LoadUserControl(UserControl userControl, Button clickedButton)
        //{
        //    mainPanel.Controls.Clear();
        //    userControl.Dock = DockStyle.Fill;
        //    mainPanel.Controls.Add(userControl);

        //    if (activeButton != null)
        //    {
        //        activeButton.BackColor = Color.FromArgb(224, 239, 204);
        //    }


        //    clickedButton.BackColor = Color.LightGreen;
        //    activeButton = clickedButton;
        //}
        private async void LoadUserControl(UserControl userControl, Button clickedButton)
        {
            if (mainPanel.Controls.Count > 0)
            {
                var currentControl = mainPanel.Controls[0];

                // Fade out effect (better performance)
                for (int i = 100; i >= 0; i -= 10)
                {
                    currentControl.BackColor = Color.FromArgb(i * 255 / 100, currentControl.BackColor);
                    await Task.Delay(10);
                }

                mainPanel.Controls.Clear();
                currentControl.Dispose(); // Release memory
            }

            // Prevent flickering
            mainPanel.SuspendLayout();

            // Add the new control
            userControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(userControl);
            userControl.BringToFront();

            // Resume layout updates
            mainPanel.ResumeLayout();
            mainPanel.Refresh();  // Ensure the UI updates

            // Fade in effect (smooth transition)
            for (int i = 0; i <= 100; i += 10)
            {
                userControl.BackColor = Color.FromArgb(i * 255 / 100, userControl.BackColor);
                await Task.Delay(10);
            }

            // Highlight the active button
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
                toggleVoiceBtn.BackColor = Color.Green; // Green when enabled
            }

            isVoiceEnabled = !isVoiceEnabled;
        }
    }
}
