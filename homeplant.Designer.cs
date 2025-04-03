namespace ONION_Your_Personal_PlantCare_Companion
{
    partial class homeplant
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
            picPlant = new PictureBox();
            lblPlantName = new Label();
            lblHealth = new Label();
            progressBar = new SiticoneNetCoreUI.SiticoneHLineProgress();
            ((System.ComponentModel.ISupportInitialize)picPlant).BeginInit();
            SuspendLayout();
            // 
            // picPlant
            // 
            picPlant.Location = new Point(14, 18);
            picPlant.Name = "picPlant";
            picPlant.Size = new Size(255, 215);
            picPlant.SizeMode = PictureBoxSizeMode.StretchImage;
            picPlant.TabIndex = 0;
            picPlant.TabStop = false;
            // 
            // lblPlantName
            // 
            lblPlantName.AutoSize = true;
            lblPlantName.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold);
            lblPlantName.Location = new Point(14, 245);
            lblPlantName.Name = "lblPlantName";
            lblPlantName.Padding = new Padding(0, 5, 0, 5);
            lblPlantName.Size = new Size(51, 30);
            lblPlantName.TabIndex = 1;
            lblPlantName.Text = "label1";
            // 
            // lblHealth
            // 
            lblHealth.AutoSize = true;
            lblHealth.Font = new Font("Leelawadee UI", 9F, FontStyle.Bold);
            lblHealth.Location = new Point(14, 275);
            lblHealth.Name = "lblHealth";
            lblHealth.Padding = new Padding(0, 5, 0, 5);
            lblHealth.Size = new Size(59, 30);
            lblHealth.TabIndex = 1;
            lblHealth.Text = "Health:";
            // 
            // progressBar
            // 
            progressBar.BackgroundOpacity = 20;
            progressBar.BottomLeftRadius = 0F;
            progressBar.BottomRightRadius = 0F;
            progressBar.EnableGlow = true;
            progressBar.EnablePulseAnimation = true;
            progressBar.GradientDirection = SiticoneNetCoreUI.Helpers.Enum.GradientDirection.Vertical;
            progressBar.HighlightOpacity = 40;
            progressBar.Location = new Point(14, 308);
            progressBar.Name = "progressBar";
            progressBar.PrimaryColor = Color.FromArgb(128, 255, 128);
            progressBar.PulseColor = Color.FromArgb(255, 255, 255);
            progressBar.PulseDuration = 1000;
            progressBar.PulseMaxOpacity = 100;
            progressBar.SecondaryColor = Color.FromArgb(0, 192, 0);
            progressBar.Size = new Size(255, 19);
            progressBar.SyncCornerRadius = false;
            progressBar.TabIndex = 2;
            progressBar.Text = "siticonehLineProgress1";
            progressBar.TopLeftRadius = 0F;
            progressBar.TopRightRadius = 0F;
            progressBar.Value = 100D;
            // 
            // homeplant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Snow;
            Controls.Add(progressBar);
            Controls.Add(lblHealth);
            Controls.Add(lblPlantName);
            Controls.Add(picPlant);
            Name = "homeplant";
            Size = new Size(288, 382);
            DoubleClick += homeplant_DoubleClick;
            MouseDoubleClick += homeplant_MouseDoubleClick;
            ((System.ComponentModel.ISupportInitialize)picPlant).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox picPlant;
        private Label lblPlantName;
        private Label label3;
        private Label lblHealth;
        private SiticoneNetCoreUI.SiticoneHLineProgress progressBar;
    }
}
