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
            panel1 = new Panel();
            lstSuggestions = new ListBox();
            lblDetails = new Label();
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
            panel1.Controls.Add(lstSuggestions);
            panel1.Controls.Add(lblDetails);
            panel1.Controls.Add(exitbtn);
            panel1.Controls.Add(btnIdentifyPlant);
            panel1.Controls.Add(btnUpload);
            panel1.Controls.Add(pictureBox);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(970, 587);
            panel1.TabIndex = 0;
            // 
            // lstSuggestions
            // 
            lstSuggestions.FormattingEnabled = true;
            lstSuggestions.Location = new Point(327, 6);
            lstSuggestions.Name = "lstSuggestions";
            lstSuggestions.Size = new Size(417, 244);
            lstSuggestions.TabIndex = 3;
            lstSuggestions.SelectedIndexChanged += lstSuggestions_SelectedIndexChanged_1;
            // 
            // lblDetails
            // 
            lblDetails.AutoSize = true;
            lblDetails.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDetails.Location = new Point(13, 349);
            lblDetails.Name = "lblDetails";
            lblDetails.Size = new Size(0, 38);
            lblDetails.TabIndex = 2;
            // 
            // exitbtn
            // 
            exitbtn.Location = new Point(873, 6);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(94, 29);
            exitbtn.TabIndex = 1;
            exitbtn.Text = "button1";
            exitbtn.UseVisualStyleBackColor = true;
            exitbtn.Click += exitbtn_Click;
            // 
            // btnIdentifyPlant
            // 
            btnIdentifyPlant.Location = new Point(193, 282);
            btnIdentifyPlant.Name = "btnIdentifyPlant";
            btnIdentifyPlant.Size = new Size(94, 29);
            btnIdentifyPlant.TabIndex = 1;
            btnIdentifyPlant.Text = "button1";
            btnIdentifyPlant.UseVisualStyleBackColor = true;
            btnIdentifyPlant.Click += btnIdentifyPlant_Click;
            // 
            // btnUpload
            // 
            btnUpload.Location = new Point(13, 282);
            btnUpload.Name = "btnUpload";
            btnUpload.Size = new Size(94, 29);
            btnUpload.TabIndex = 1;
            btnUpload.Text = "button1";
            btnUpload.UseVisualStyleBackColor = true;
            btnUpload.Click += btnUpload_Click;
            // 
            // pictureBox
            // 
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
        private ListBox lstSuggestions;
        private Label lblDetails;
        private Button btnIdentifyPlant;
        private Button btnUpload;
        private Button exitbtn;
    }
}