﻿using System;
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
    public partial class result : UserControl
    {
        public event EventHandler ResultDoubleClicked;
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
        public result()
        {
            InitializeComponent();
            DoubleBuffered = true;

            // Attach double-click event to UserControl
            this.DoubleClick += result_DoubleClick;

            // Attach double-click event to all child controls
            foreach (Control control in this.Controls)
            {
                control.DoubleClick += result_DoubleClick;
            }
        }

        private void result_DoubleClick(object sender, EventArgs e)
        {
            ResultDoubleClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
