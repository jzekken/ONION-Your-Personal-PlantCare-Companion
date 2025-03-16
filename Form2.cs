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
    public partial class Form2 : Form
    {
        private Button activeButton;

        public Form2()
        {
            InitializeComponent();
            LoadUserControl(new HomeControl1(), homebtn);
        }
        private void LoadUserControl(UserControl userControl, Button clickedButton)
        {
            mainPanel.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(userControl);

            if (activeButton != null)
            {
                activeButton.BackColor = Color.FromArgb(240, 240, 240);
            }


            clickedButton.BackColor = Color.LightGreen;
            activeButton = clickedButton;
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new HomeControl1(), homebtn);
        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new SearchControl(), searchbtn);
        }

        private void talkbtn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new TalkControl(), talkbtn);

        }

        private void listbtn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new ListControl(), listbtn);
        }

        private void gardenbtn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new GardenControl(), gardenbtn);
        }

        private void aboutbtn_Click(object sender, EventArgs e)
        {
            LoadUserControl(new AboutControl(), aboutbtn);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
