
using Vosk;
using NAudio.Wave;
namespace ONION_Your_Personal_PlantCare_Companion
{
    public partial class Form1 : Form
    {
        private int clickCount = 0;
        private WaveInEvent waveIn;
        private VoskRecognizer recognizer;
        private Model model;

        public Form1()
        {
            InitializeComponent();
            InitializeVoiceRecognition();
            pictureBox2.Visible = false; // Ensure the PictureBox is initially hidden
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

                waveIn.DataAvailable += async (sender, e) =>
                {
                    if (recognizer.AcceptWaveform(e.Buffer, e.BytesRecorded))
                    {
                        string result = recognizer.Result();
                        Console.WriteLine($"Recognized: {result}");

                        if (result.Contains("hey onion") || result.Contains("wake up") || result.Contains("without you cover"))
                        {
                            // Show the wake-up animation
                            Invoke(new Action(() =>
                            {
                                pictureBox2.Visible = true;
                            }));

                            // Wait for the animation to complete (e.g., 2 seconds)
                            await Task.Delay(4500);

                            // Open the next form
                            Invoke(new Action(() =>
                            {
                                var nextForm = new Form2();
                                nextForm.Show();
                                this.Hide();
                                StopVoiceRecognition();
                            }));
                        }
                    }
                };

                waveIn.StartRecording();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing voice recognition: {ex.Message}");
            }
        }

        private void StopVoiceRecognition()
        {
            waveIn?.StopRecording();
            waveIn?.Dispose();
            model?.Dispose();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopVoiceRecognition();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            clickCount++;

            if (clickCount == 1)
            {
                // Show the wake-up animation
                pictureBox2.Visible = true;

                // Wait for the animation to complete (e.g., 2 seconds)
                await Task.Delay(4500);

                Form2 newform = new Form2();
                newform.Show();
                this.Hide();
                StopVoiceRecognition();
            }
        }
    }
}
