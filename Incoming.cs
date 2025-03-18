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
    public partial class Incoming : UserControl
    {
        public Incoming()
        {
            InitializeComponent();
        }
        public string Message
        {
            get
            {
                return label1.Text;
            }
            set { label1.Text = value;
                AdjustHeight();
            }
        }
        void AdjustHeight()
        {
            pictureBox1.Location = new Point(4, 3);
            label1.Height = Utils.GetHeight(label1)+10;

            poisonUserControl1.Height = label1.Top + pictureBox1.Top + label1.Height;

            this.Height = poisonUserControl1.Bottom + 10;
        }

        public Image Avatar { get => pictureBox1.Image; set => pictureBox1.Image = value;}

        private void Incomming_Resize(object sender, EventArgs e) {
            AdjustHeight();
        }
    }
}
