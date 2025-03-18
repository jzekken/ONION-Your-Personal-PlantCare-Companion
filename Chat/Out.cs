using ReaLTaiizor.Controls;
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
    public partial class Out : UserControl
    {
        public Out()
        {
            InitializeComponent();
            this.Resize += new EventHandler(Out_Resize);
        }
        public string Message
        {
            get
            {
                return label1.Text;
            }
            set
            {
                label1.Text = value;
                AdjustHeight();
            }
        }
        void AdjustHeight()
        {
            //label1.AutoSize = false;
            //label1.MaximumSize = new Size(this.Width - pictureBox1.Width - 50, 0); // Limit width
            //label1.TextAlign = ContentAlignment.MiddleRight;


            //Size textSize = TextRenderer.MeasureText(label1.Text, label1.Font, label1.MaximumSize, TextFormatFlags.WordBreak);
            //label1.Size = textSize;


            //poisonUserControl1.Width = label1.Width + 20;
            //poisonUserControl1.Height = label1.Height + 15;


            //label1.Location = new Point(10, 5);


            //poisonUserControl1.Location = new Point(this.Width - poisonUserControl1.Width - pictureBox1.Width - 15, 3);


            //pictureBox1.Location = new Point(this.Width - pictureBox1.Width - 10, 3);


            //this.Height = poisonUserControl1.Bottom + 10;

            pictureBox1.Location = new Point(4, 3);

            // Ensure label resizes correctly
            label1.AutoSize = false;
            label1.MaximumSize = new Size(this.Width - pictureBox1.Width - 50, 0); // Limit width
            label1.TextAlign = ContentAlignment.MiddleRight;

            // Measure text size properly
            Size textSize = TextRenderer.MeasureText(label1.Text, label1.Font, label1.MaximumSize, TextFormatFlags.WordBreak);
            label1.Size = textSize;

            // Adjust bubble to wrap text properly
            poisonUserControl1.Width = label1.Width + 20;
            poisonUserControl1.Height = label1.Height + 15;

            // Align text inside the bubble
            label1.Location = new Point(10, 5);

            // Position the bubble on the right side
            poisonUserControl1.Location = new Point(this.Width - poisonUserControl1.Width - pictureBox1.Width - 15, 3);

            // Position avatar correctly (right side)
            pictureBox1.Location = new Point(this.Width - pictureBox1.Width - 10, 3);

            // Set correct control height
            this.Height = poisonUserControl1.Bottom + 10;
        }

        public Image Avatar { get => pictureBox1.Image; set => pictureBox1.Image = value; }

        private void Incomming_Resize(object sender, EventArgs e)
        {
            AdjustHeight();
        }

        private void Out_Resize(object sender, EventArgs e)
        {
            AdjustHeight(); // Ensure resizing works
        }
    }
}
