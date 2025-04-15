using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONION_Your_Personal_PlantCare_Companion
{
    public partial class Doubleclick : Form
    {

        public Doubleclick(string plantName, Image plantImage, DateTime lastWatered, DateTime lastFertilized)
        {
            InitializeComponent(); 
            lblName.Text = plantName;

            picImage.Image = plantImage; 
            lblLastWatered.Text = "Last Watered: " + lastWatered.ToString("MM/dd/yyyy");
            lblLastFertilized.Text = "Last Fertilized: " + lastFertilized.ToString("MM/dd/yyyy");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
