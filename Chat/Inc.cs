using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONION_Your_Personal_PlantCare_Companion.Chat
{
    public partial class Inc : UserControl
    {
        public Inc()
        {
            InitializeComponent();
            this.Resize += Incomming_Resize;
        }

        public string Message
        {
            get => label1.Text;
            set
            {
                label1.Text = value;
                AdjustHeight();
            }
        }

        void AdjustHeight()
        {
            pictureBox1.Location = new Point(4, 3);

            // Ensure label resizes correctly
            label1.AutoSize = false;
            label1.Width = poisonUserControl1.Width - 20;  // Ensures alignment
            label1.Height = Utils.GetHeight(label1) + 10;

            // Match poisonUserControl1 width to label1
            poisonUserControl1.Width = label1.Width + 20; // Adjust padding
            poisonUserControl1.Height = label1.Height + 10;
            poisonUserControl1.Location = new Point(label1.Left - 10, label1.Top - 5);

            // Set the height of the whole control
            this.Height = poisonUserControl1.Bottom + 10;
        }

        public Image Avatar
        {
            get => pictureBox1.Image;
            set => pictureBox1.Image = value;
        }

        private void Incomming_Resize(object sender, EventArgs e)
        {
            AdjustHeight();
        }
    }
}
