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

    public partial class SearchControl : UserControl
    {
        private readonly PlantService plantService = new PlantService();

        public SearchControl()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string query = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(query)) return;

            List<Plant> plants = await plantService.SearchPlantsAsync(query);

            lstResults.Items.Clear();
            if (plants.Count == 0)
            {
                MessageBox.Show("No plants found. Try a different search term.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (var plant in plants)
            {
                var listViewItem = new ListViewItem(plant.CommonName);
                listViewItem.SubItems.Add(plant.ScientificName);
                lstResults.Items.Add(listViewItem);
            }
        }
    }
}
