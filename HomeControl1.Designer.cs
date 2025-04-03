namespace ONION_Your_Personal_PlantCare_Companion
{
    partial class HomeControl1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeControl1));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            plantdata1 = new Plantdata();
            plantdata2 = new Plantdata();
            plantdata3 = new Plantdata();
            plantdata4 = new Plantdata();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1030, 294);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(20, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(257, 255);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(283, 21);
            label1.Name = "label1";
            label1.Size = new Size(175, 60);
            label1.TabIndex = 4;
            label1.Text = "ONION";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Leelawadee UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonShadow;
            label2.Location = new Point(286, 81);
            label2.Name = "label2";
            label2.Size = new Size(319, 25);
            label2.TabIndex = 5;
            label2.Text = "Your Personal PlantCare Companion";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Leelawadee UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(286, 116);
            label3.Name = "label3";
            label3.Size = new Size(705, 160);
            label3.TabIndex = 6;
            label3.Text = resources.GetString("label3.Text");
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(plantdata1);
            flowLayoutPanel1.Controls.Add(plantdata2);
            flowLayoutPanel1.Controls.Add(plantdata3);
            flowLayoutPanel1.Controls.Add(plantdata4);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 294);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1030, 382);
            flowLayoutPanel1.TabIndex = 2;
            flowLayoutPanel1.WrapContents = false;
            // 
            // plantdata1
            // 
            plantdata1.FertilizationSchedule = "Fertilization: Fertilization: Fertilization Schedule:";
            plantdata1.Location = new Point(3, 3);
            plantdata1.Name = "plantdata1";
            plantdata1.PlantID = null;
            plantdata1.PlantName = "Plant: ";
            plantdata1.Size = new Size(288, 243);
            plantdata1.TabIndex = 0;
            plantdata1.WateringFrequency = "Watering: Watering: Watering Frequency:";
            // 
            // plantdata2
            // 
            plantdata2.FertilizationSchedule = "Fertilization: Fertilization: Fertilization: Fertilization Schedule:";
            plantdata2.Location = new Point(297, 3);
            plantdata2.Name = "plantdata2";
            plantdata2.PlantID = null;
            plantdata2.PlantName = "Plant: ";
            plantdata2.Size = new Size(288, 243);
            plantdata2.TabIndex = 1;
            plantdata2.WateringFrequency = "Watering: Watering: Watering: Watering Frequency:";
            // 
            // plantdata3
            // 
            plantdata3.FertilizationSchedule = "Fertilization: Fertilization: Fertilization: Fertilization Schedule:";
            plantdata3.Location = new Point(591, 3);
            plantdata3.Name = "plantdata3";
            plantdata3.PlantID = null;
            plantdata3.PlantName = "Plant: ";
            plantdata3.Size = new Size(288, 243);
            plantdata3.TabIndex = 2;
            plantdata3.WateringFrequency = "Watering: Watering: Watering: Watering Frequency:";
            // 
            // plantdata4
            // 
            plantdata4.FertilizationSchedule = "Fertilization: Fertilization: Fertilization: Fertilization: Fertilization Schedule:";
            plantdata4.Location = new Point(885, 3);
            plantdata4.Name = "plantdata4";
            plantdata4.PlantID = null;
            plantdata4.PlantName = "Plant: ";
            plantdata4.Size = new Size(288, 243);
            plantdata4.TabIndex = 2;
            plantdata4.WateringFrequency = "Watering: Watering: Watering: Watering: Watering Frequency:";
            // 
            // HomeControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "HomeControl1";
            Size = new Size(1030, 676);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Plantdata plantdata1;
        private Plantdata plantdata2;
        private Plantdata plantdata3;
        private PictureBox pictureBox1;
        private Plantdata plantdata4;
    }
}
