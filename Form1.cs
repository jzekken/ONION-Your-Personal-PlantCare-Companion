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
            
            pictureBox2.Visible = false;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            
            MakeFormRounded();
        }
        private void MakeFormRounded()
        {
            
            int radius = 30;

            
            using (GraphicsPath path = new GraphicsPath())
            {
                
                path.AddArc(0, 0, radius, radius, 180, 90); 
                path.AddArc(this.Width - radius - 1, 0, radius, radius, 270, 90); 
                path.AddArc(this.Width - radius - 1, this.Height - radius - 1, radius, radius, 0, 90);
                path.AddArc(0, this.Height - radius - 1, radius, radius, 90, 90); 
                path.CloseAllFigures(); 
                
                this.Region = new Region(path);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            
            MakeFormRounded();
        }
        private void PlaySound(string filePath)
        {
            using (var audioFileReader = new AudioFileReader(filePath))
            using (var outputDevice = new WaveOutEvent())
            {
                outputDevice.Init(audioFileReader);
                outputDevice.Play();

                
                while (outputDevice.PlaybackState == PlaybackState.Playing)
                {
                    Application.DoEvents();  
                }
            }
        }
        private void InitializeVoiceRecognition()
        {
            try
            {
                
                model = new Model(Path.Combine(Application.StartupPath, "VoskModel"));

                
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

                        if (result.Contains("hey onion") || result.Contains("wake up"))
                        {
                            
                            Invoke(new Action(() =>
                            {
                                pictureBox2.Visible = true;
                            }));

                            PlaySound(@"C:\Users\ACER ASPIRE 3\source\repos\ONION-Your-Personal-PlantCare-Companion\Resources\onion.wav");


                            
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
                
                pictureBox2.Visible = true;
                PlaySound(@"C:\Users\ACER ASPIRE 3\source\repos\ONION-Your-Personal-PlantCare-Companion\Resources\onion.wav");
                

                Form2 newform = new Form2();
                newform.Show();
                this.Hide();
                StopVoiceRecognition();
            }
        }
    }
}
