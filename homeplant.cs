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
    public partial class homeplant : UserControl
    {
        public homeplant()
        {
            InitializeComponent();
        }
        public string PlantName
        {
            get => lblPlantName.Text;
            set => lblPlantName.Text = value;
        }

        public int HealthPercentage
        {
            set
            {
                if (value < 0) value = 0; // Clip to 0 if less than 0
                if (value > 100) value = 100; // Clip to 100 if greater than 100
                progressBar.Value = value;
            }
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
    }
}
