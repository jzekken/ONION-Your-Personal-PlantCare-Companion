namespace ONION_Your_Personal_PlantCare_Companion
{
    partial class Plantdata
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Plantdata));
            picPlant = new PictureBox();
            lblPlantName = new Label();
            lblWateringFrequency = new Label();
            lblFertilizationSchedule = new Label();
            btnUpdate = new Button();
            btnDelete = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)picPlant).BeginInit();
            SuspendLayout();
            // 
            // picPlant
            // 
            picPlant.Image = (Image)resources.GetObject("picPlant.Image");
            picPlant.Location = new Point(3, 5);
            picPlant.Name = "picPlant";
            picPlant.Size = new Size(274, 221);
            picPlant.SizeMode = PictureBoxSizeMode.StretchImage;
            picPlant.TabIndex = 0;
            picPlant.TabStop = false;
            // 
            // lblPlantName
            // 
            lblPlantName.AutoSize = true;
            lblPlantName.BackColor = Color.Transparent;
            lblPlantName.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPlantName.Location = new Point(3, 229);
            lblPlantName.Name = "lblPlantName";
            lblPlantName.Size = new Size(66, 25);
            lblPlantName.TabIndex = 1;
            lblPlantName.Text = "Plant: ";
            // 
            // lblWateringFrequency
            // 
            lblWateringFrequency.AutoSize = true;
            lblWateringFrequency.BackColor = Color.Transparent;
            lblWateringFrequency.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblWateringFrequency.Location = new Point(3, 254);
            lblWateringFrequency.Name = "lblWateringFrequency";
            lblWateringFrequency.Size = new Size(188, 25);
            lblWateringFrequency.TabIndex = 1;
            lblWateringFrequency.Text = "Watering Frequency:";
            // 
            // lblFertilizationSchedule
            // 
            lblFertilizationSchedule.AutoSize = true;
            lblFertilizationSchedule.BackColor = Color.Transparent;
            lblFertilizationSchedule.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFertilizationSchedule.Location = new Point(3, 279);
            lblFertilizationSchedule.Name = "lblFertilizationSchedule";
            lblFertilizationSchedule.Size = new Size(201, 25);
            lblFertilizationSchedule.TabIndex = 1;
            lblFertilizationSchedule.Text = "Fertilization Schedule:";
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Transparent;
            btnUpdate.FlatAppearance.BorderSize = 0;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Image = (Image)resources.GetObject("btnUpdate.Image");
            btnUpdate.Location = new Point(247, 5);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(30, 25);
            btnUpdate.TabIndex = 2;
            btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Transparent;
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Image = (Image)resources.GetObject("btnDelete.Image");
            btnDelete.Location = new Point(247, 201);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(30, 25);
            btnDelete.TabIndex = 2;
            btnDelete.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(280, 315);
            panel1.TabIndex = 3;
            // 
            // Plantdata
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(lblFertilizationSchedule);
            Controls.Add(lblWateringFrequency);
            Controls.Add(lblPlantName);
            Controls.Add(picPlant);
            Controls.Add(panel1);
            Name = "Plantdata";
            Size = new Size(280, 315);
            ((System.ComponentModel.ISupportInitialize)picPlant).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picPlant;
        private Label lblPlantName;
        private Label lblWateringFrequency;
        private Label lblFertilizationSchedule;
        private Button btnUpdate;
        private Button btnDelete;
        private Panel panel1;
    }
}
