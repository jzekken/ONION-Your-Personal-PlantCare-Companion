namespace ONION_Your_Personal_PlantCare_Companion
{
    partial class PlantDetails
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblCommonName = new Label();
            pictureBox1 = new PictureBox();
            lblScientificName = new Label();
            lblWateringFrequency = new Label();
            lblFertilizationFrequency = new Label();
            lblDescription = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblCommonName
            // 
            lblCommonName.AutoSize = true;
            lblCommonName.Font = new Font("Leelawadee UI", 16.2F);
            lblCommonName.Location = new Point(247, 110);
            lblCommonName.Name = "lblCommonName";
            lblCommonName.Size = new Size(91, 38);
            lblCommonName.TabIndex = 0;
            lblCommonName.Text = "label1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(21, 48);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 220);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // lblScientificName
            // 
            lblScientificName.AutoSize = true;
            lblScientificName.Font = new Font("Leelawadee UI", 16.2F);
            lblScientificName.Location = new Point(247, 148);
            lblScientificName.Name = "lblScientificName";
            lblScientificName.Size = new Size(91, 38);
            lblScientificName.TabIndex = 0;
            lblScientificName.Text = "label1";
            // 
            // lblWateringFrequency
            // 
            lblWateringFrequency.AutoSize = true;
            lblWateringFrequency.Font = new Font("Leelawadee UI", 16.2F);
            lblWateringFrequency.Location = new Point(247, 186);
            lblWateringFrequency.Name = "lblWateringFrequency";
            lblWateringFrequency.Size = new Size(91, 38);
            lblWateringFrequency.TabIndex = 0;
            lblWateringFrequency.Text = "label1";
            // 
            // lblFertilizationFrequency
            // 
            lblFertilizationFrequency.AutoSize = true;
            lblFertilizationFrequency.Font = new Font("Leelawadee UI", 16.2F);
            lblFertilizationFrequency.Location = new Point(247, 224);
            lblFertilizationFrequency.Name = "lblFertilizationFrequency";
            lblFertilizationFrequency.Size = new Size(91, 38);
            lblFertilizationFrequency.TabIndex = 0;
            lblFertilizationFrequency.Text = "label1";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Leelawadee UI", 16.2F);
            lblDescription.Location = new Point(21, 287);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(91, 38);
            lblDescription.TabIndex = 0;
            lblDescription.Text = "label1";
            // 
            // PlantDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(lblDescription);
            Controls.Add(lblFertilizationFrequency);
            Controls.Add(lblWateringFrequency);
            Controls.Add(lblScientificName);
            Controls.Add(lblCommonName);
            Name = "PlantDetails";
            Size = new Size(1012, 665);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCommonName;
        private PictureBox pictureBox1;
        private Label lblScientificName;
        private Label lblWateringFrequency;
        private Label lblFertilizationFrequency;
        private Label lblDescription;
    }
}
