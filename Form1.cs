using System.Windows.Forms;
using Vosk;
using NAudio.Wave;
using System.Drawing.Drawing2D;
using System.Threading.Tasks;
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
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            // After the form is fully loaded, set the rounded corners
            MakeFormRounded();
        }
        private void MakeFormRounded()
        {
            // Define the radius of the rounded corners (adjust as needed)
            int radius = 30;

            // Create a GraphicsPath to define the form shape
            using (GraphicsPath path = new GraphicsPath())
            {
                // Create a rounded rectangle path for 375x450 form
                path.AddArc(0, 0, radius, radius, 180, 90); // top-left corner
                path.AddArc(this.Width - radius - 1, 0, radius, radius, 270, 90); // top-right corner
                path.AddArc(this.Width - radius - 1, this.Height - radius - 1, radius, radius, 0, 90); // bottom-right corner
                path.AddArc(0, this.Height - radius - 1, radius, radius, 90, 90); // bottom-left corner
                path.CloseAllFigures(); // Close the path to create a full rounded rectangle

                // Set the form’s region to the defined path (this will apply the rounded corners)
                this.Region = new Region(path);
            }
        }

        // Optional: Allow resizing of the form (with rounded corners)
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            // Reapply the rounded corners when the form is resized
            MakeFormRounded();
        }
        private void PlaySound(string filePath)
        {
            using (var audioFileReader = new AudioFileReader(filePath))
            using (var outputDevice = new WaveOutEvent())
            {
                outputDevice.Init(audioFileReader);
                outputDevice.Play();

                // Wait until the sound finishes playing
                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    Application.DoEvents();  // Allow the UI to update during playback
                }
            }
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

                            PlaySound(@"C:\Users\ACER ASPIRE 3\source\repos\ONION-Your-Personal-PlantCare-Companion\Resources\onion.wav");


                            // Wait for the animation to complete (e.g., 2 seconds)
                            //await Task.Delay(4500);

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
                PlaySound(@"C:\Users\ACER ASPIRE 3\source\repos\ONION-Your-Personal-PlantCare-Companion\Resources\onion.wav");
                // Wait for the animation to complete (e.g., 2 seconds)
                //await Task.Delay(4500);

                Form2 newform = new Form2();
                newform.Show();
                this.Hide();
                StopVoiceRecognition();
            }
        }
    }
}
