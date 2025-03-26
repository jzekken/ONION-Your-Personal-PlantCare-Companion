using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONION_Your_Personal_PlantCare_Companion
{
    public partial class Plantdata : UserControl
    {
        public event EventHandler UpdateClicked;
        public event EventHandler DeleteClicked;
        public Plantdata()
        {
            InitializeComponent();
            btnUpdate.Click += BtnUpdate_Click;
            btnDelete.Click += BtnDelete_Click;
        }

        public string PlantID { get; set; }
        public string PlantName
        {
            get => lblPlantName.Text;  
            set => lblPlantName.Text = value;
        }

        public string WateringFrequency
        {
            get => lblWateringFrequency.Text;
            set => lblWateringFrequency.Text = $"Watering: {value}";
        }

        public string FertilizationSchedule
        {
            get => lblFertilizationSchedule.Text;
            set => lblFertilizationSchedule.Text = $"Fertilization: {value}";
        }
        public object PlantImage
        {
            set
            {
                if (value is Image img)
                {
                    picPlant.Image = img;
                }
                else if (value is byte[] imageBytes && imageBytes.Length > 0)
                {
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        picPlant.Image = Image.FromStream(ms);
                    }
                }
                else
                {
                    picPlant.Image = LoadDefaultPlantImage();
                }
            }
        }


        // Load embedded default image
        private Image LoadDefaultPlantImage()
        {
            var assembly = Assembly.GetExecutingAssembly();
            string resourceName = "ONION_Your_Personal_PlantCare_Companion.Resources.default_plant.png";  

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream != null)
                {
                    return Image.FromStream(stream);
                }
            }

            
            return new Bitmap(100, 100);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            UpdateClicked?.Invoke(this, EventArgs.Empty);
        }

        
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(
                "Are you sure you want to delete this plant?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.Yes)
            {
                DeleteClicked?.Invoke(this, EventArgs.Empty);
            }
        }
        

   
    }
}
