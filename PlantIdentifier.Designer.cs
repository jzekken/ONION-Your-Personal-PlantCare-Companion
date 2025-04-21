namespace ONION_Your_Personal_PlantCare_Companion
{
    partial class PlantIdentifier
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlantIdentifier));
            panel1 = new Panel();
            lblHealth = new Label();
            lblTaxonomy = new Label();
            lblConfidence = new Label();
            lblScientificName = new Label();
            lblCommonName = new Label();
            exitbtn = new Button();
            btnIdentifyPlant = new Button();
            btnUpload = new Button();
            pictureBox = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(224, 239, 204);
            panel1.Controls.Add(lblHealth);
            panel1.Controls.Add(lblTaxonomy);
            panel1.Controls.Add(lblConfidence);
            panel1.Controls.Add(lblScientificName);
            panel1.Controls.Add(lblCommonName);
            panel1.Controls.Add(exitbtn);
            panel1.Controls.Add(btnIdentifyPlant);
            panel1.Controls.Add(btnUpload);
            panel1.Controls.Add(pictureBox);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(970, 587);
            panel1.TabIndex = 0;
            // 
            // lblHealth
            // 
            lblHealth.AutoSize = true;
            lblHealth.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblHealth.Location = new Point(318, 329);
            lblHealth.Name = "lblHealth";
            lblHealth.Size = new Size(0, 38);
            lblHealth.TabIndex = 2;
            // 
            // lblTaxonomy
            // 
            lblTaxonomy.AutoSize = true;
            lblTaxonomy.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTaxonomy.Location = new Point(13, 329);
            lblTaxonomy.Name = "lblTaxonomy";
            lblTaxonomy.Size = new Size(0, 38);
            lblTaxonomy.TabIndex = 2;
            // 
            // lblConfidence
            // 
            lblConfidence.AutoSize = true;
            lblConfidence.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblConfidence.Location = new Point(318, 135);
            lblConfidence.Name = "lblConfidence";
            lblConfidence.Size = new Size(0, 38);
            lblConfidence.TabIndex = 2;
            // 
            // lblScientificName
            // 
            lblScientificName.AutoSize = true;
            lblScientificName.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblScientificName.Location = new Point(318, 70);
            lblScientificName.Name = "lblScientificName";
            lblScientificName.Size = new Size(0, 38);
            lblScientificName.TabIndex = 2;
            // 
            // lblCommonName
            // 
            lblCommonName.AutoSize = true;
            lblCommonName.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCommonName.Location = new Point(318, 6);
            lblCommonName.Name = "lblCommonName";
            lblCommonName.Size = new Size(0, 38);
            lblCommonName.TabIndex = 2;
            // 
            // exitbtn
            // 
            exitbtn.FlatAppearance.BorderSize = 0;
            exitbtn.FlatStyle = FlatStyle.Flat;
            exitbtn.Image = (Image)resources.GetObject("exitbtn.Image");
            exitbtn.Location = new Point(931, 3);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(36, 41);
            exitbtn.TabIndex = 1;
            exitbtn.UseVisualStyleBackColor = true;
            exitbtn.Click += exitbtn_Click;
            // 
            // btnIdentifyPlant
            // 
            btnIdentifyPlant.FlatStyle = FlatStyle.Flat;
            btnIdentifyPlant.Image = (Image)resources.GetObject("btnIdentifyPlant.Image");
            btnIdentifyPlant.Location = new Point(193, 282);
            btnIdentifyPlant.Name = "btnIdentifyPlant";
            btnIdentifyPlant.Size = new Size(94, 44);
            btnIdentifyPlant.TabIndex = 1;
            btnIdentifyPlant.Text = "Identify";
            btnIdentifyPlant.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIdentifyPlant.UseVisualStyleBackColor = true;
            btnIdentifyPlant.Click += btnIdentifyPlant_Click;
            // 
            // btnUpload
            // 
            btnUpload.FlatStyle = FlatStyle.Flat;
            btnUpload.Image = (Image)resources.GetObject("btnUpload.Image");
            btnUpload.Location = new Point(13, 282);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(113, 44);
            btnUpload.TabIndex = 1;
            btnUpload.Text = "Upload";
            btnUpload.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // pictureBox
            // 
            pictureBox.Image = (Image)resources.GetObject("pictureBox.Image");
            pictureBox.Location = new Point(13, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(274, 247);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            // 
            // PlantIdentifier
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(180, 213, 137);
            ClientSize = new Size(994, 611);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PlantIdentifier";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PlantIdentifier";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox;
        private Label lblCommonName;
        private Button btnIdentifyPlant;
        private Button btnUpload;
        private Button exitbtn;
        private Label lblHealth;
        private Label lblTaxonomy;
        private Label lblConfidence;
        private Label lblScientificName;
    }
}