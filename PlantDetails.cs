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
    public partial class PlantDetails : UserControl
    {
        public string CommonName
        {
            get => lblCommonName.Text;
            set => lblCommonName.Text = $"Common Name: {value}";
        }

        public string ScientificName
        {
            get => lblScientificName.Text;
            set => lblScientificName.Text = $"Scientific Name: {value}";
        }

        public string WateringFrequency
        {
            get => lblWateringFrequency.Text;
            set => lblWateringFrequency.Text = $"Watering: {value}";
        }

        public string FertilizationFrequency
        {
            get => lblFertilizationFrequency.Text;
            set => lblFertilizationFrequency.Text = $"Fertilizing: {value}";
        }

        public string Description
        {
            get => lblDescription.Text;
            set => lblDescription.Text = $"Description: {value}";
        }

        public PlantDetails()
        {
            InitializeComponent();
        }
    }
}
