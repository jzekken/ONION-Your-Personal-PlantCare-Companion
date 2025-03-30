namespace ONION_Your_Personal_PlantCare_Companion
{
    partial class result
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(result));
            lblScientificName = new Label();
            lblCommonName = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblScientificName
            // 
            lblScientificName.AutoSize = true;
            lblScientificName.Font = new Font("Leelawadee UI", 9F);
            lblScientificName.Location = new Point(71, 36);
            lblScientificName.Name = "lblScientificName";
            lblScientificName.Size = new Size(116, 20);
            lblScientificName.TabIndex = 1;
            lblScientificName.Text = "Scientific Name:";
            // 
            // lblCommonName
            // 
            lblCommonName.AutoSize = true;
            lblCommonName.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCommonName.Location = new Point(68, 13);
            lblCommonName.Name = "lblCommonName";
            lblCommonName.Size = new Size(140, 23);
            lblCommonName.TabIndex = 2;
            lblCommonName.Text = "Common Name:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 59);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // result
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(lblScientificName);
            Controls.Add(lblCommonName);
            Name = "result";
            Size = new Size(435, 65);
            DoubleClick += result_DoubleClick;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblScientificName;
        private Label lblCommonName;
        private PictureBox pictureBox1;
    }
}
