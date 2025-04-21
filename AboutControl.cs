using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace ONION_Your_Personal_PlantCare_Companion
{
    public partial class AboutControl : UserControl
    {
        public AboutControl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://www.facebook.com/cold.takoyaki",
                UseShellExecute = true
            });
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Process.Start(new ProcessStartInfo
            {
                FileName = "https://github.com/jzekken",
                UseShellExecute = true
            });
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://discord.com/users/746288261491851304", 
                UseShellExecute = true
            });
        }
    }
}
