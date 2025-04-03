namespace ONION_Your_Personal_PlantCare_Companion
{
    partial class PottedPlants
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PottedPlants));
            panel1 = new Panel();
            plantNameLabel = new Label();
            exclamationPictureBox = new PictureBox();
            button2 = new Button();
            button1 = new Button();
            plantPictureBox = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)exclamationPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)plantPictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(plantNameLabel);
            panel1.Controls.Add(exclamationPictureBox);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(plantPictureBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(149, 149);
            panel1.TabIndex = 0;
            // 
            // plantNameLabel
            // 
            plantNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            plantNameLabel.BackColor = Color.Transparent;
            plantNameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            plantNameLabel.Location = new Point(3, 82);
            plantNameLabel.Name = "plantNameLabel";
            plantNameLabel.Size = new Size(143, 27);
            plantNameLabel.TabIndex = 3;
            plantNameLabel.Text = "label1";
            plantNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // exclamationPictureBox
            // 
            exclamationPictureBox.BackColor = Color.Transparent;
            exclamationPictureBox.Image = (Image)resources.GetObject("exclamationPictureBox.Image");
            exclamationPictureBox.Location = new Point(97, 3);
            exclamationPictureBox.Name = "exclamationPictureBox";
            exclamationPictureBox.Size = new Size(49, 53);
            exclamationPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            exclamationPictureBox.TabIndex = 2;
            exclamationPictureBox.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Tan;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(73, 112);
            button2.Name = "button2";
            button2.Size = new Size(48, 33);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DeepSkyBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(19, 112);
            button1.Name = "button1";
            button1.Size = new Size(48, 33);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // plantPictureBox
            // 
            plantPictureBox.BackColor = Color.Transparent;
            plantPictureBox.Image = (Image)resources.GetObject("plantPictureBox.Image");
            plantPictureBox.Location = new Point(23, 0);
            plantPictureBox.Name = "plantPictureBox";
            plantPictureBox.Size = new Size(103, 106);
            plantPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            plantPictureBox.TabIndex = 0;
            plantPictureBox.TabStop = false;
            // 
            // PottedPlants
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "PottedPlants";
            Size = new Size(149, 149);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)exclamationPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)plantPictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox plantPictureBox;
        private Button button2;
        private Button button1;
        private PictureBox exclamationPictureBox;
        private Label plantNameLabel;
    }
}
