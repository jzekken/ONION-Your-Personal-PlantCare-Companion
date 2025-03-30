namespace ONION_Your_Personal_PlantCare_Companion
{
    partial class AddPlant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPlant));
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            txtFertilization = new TextBox();
            txtWaterFreq = new TextBox();
            txtPlantName = new TextBox();
            picPlantPreview = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)picPlantPreview).BeginInit();
            SuspendLayout();
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(308, 170);
            button3.Name = "button3";
            button3.Size = new Size(49, 41);
            button3.TabIndex = 31;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Location = new Point(263, 392);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 32;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(17, 392);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 33;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtFertilization
            // 
            txtFertilization.Location = new Point(130, 316);
            txtFertilization.Name = "txtFertilization";
            txtFertilization.Size = new Size(227, 27);
            txtFertilization.TabIndex = 28;
            // 
            // txtWaterFreq
            // 
            txtWaterFreq.Location = new Point(145, 278);
            txtWaterFreq.Name = "txtWaterFreq";
            txtWaterFreq.Size = new Size(212, 27);
            txtWaterFreq.TabIndex = 29;
            // 
            // txtPlantName
            // 
            txtPlantName.Location = new Point(129, 234);
            txtPlantName.Name = "txtPlantName";
            txtPlantName.Size = new Size(228, 27);
            txtPlantName.TabIndex = 30;
            // 
            // picPlantPreview
            // 
            picPlantPreview.Location = new Point(17, 29);
            picPlantPreview.Name = "picPlantPreview";
            picPlantPreview.Size = new Size(340, 182);
            picPlantPreview.SizeMode = PictureBoxSizeMode.StretchImage;
            picPlantPreview.TabIndex = 27;
            picPlantPreview.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 319);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 24;
            label3.Text = "Fertilization:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 278);
            label2.Name = "label2";
            label2.Size = new Size(105, 20);
            label2.TabIndex = 25;
            label2.Text = "Watering Freq:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 237);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 26;
            label1.Text = "Plant Name:";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(375, 450);
            panel1.TabIndex = 34;
            // 
            // AddPlant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 239, 204);
            ClientSize = new Size(375, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtFertilization);
            Controls.Add(txtWaterFreq);
            Controls.Add(txtPlantName);
            Controls.Add(picPlantPreview);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddPlant";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddPlant";
            ((System.ComponentModel.ISupportInitialize)picPlantPreview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button3;
        private Button button2;
        private Button button1;
        private TextBox txtFertilization;
        private TextBox txtWaterFreq;
        private TextBox txtPlantName;
        private PictureBox picPlantPreview;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel1;
    }
}