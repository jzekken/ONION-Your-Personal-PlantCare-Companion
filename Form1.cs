

namespace ONION_Your_Personal_PlantCare_Companion
{
    public partial class Form1 : Form
    {
        private int clickCount = 0;
        
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clickCount++;

            if (clickCount == 1)
            {
                Form2 newform = new Form2();
                newform.Show();
                this.Hide();
            }
        }
    }
}
