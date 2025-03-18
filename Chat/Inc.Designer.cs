namespace ONION_Your_Personal_PlantCare_Companion.Chat
{
    partial class Inc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inc));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            poisonUserControl1 = new ReaLTaiizor.Controls.PoisonUserControl();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.PaleGreen;
            label1.Font = new Font("Leelawadee UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(144, 26);
            label1.Name = "label1";
            label1.Size = new Size(434, 105);
            label1.TabIndex = 5;
            label1.Text = "Hello World";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(19, 8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(79, 82);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // poisonUserControl1
            // 
            poisonUserControl1.BackColor = Color.PaleGreen;
            poisonUserControl1.Location = new Point(130, 8);
            poisonUserControl1.Name = "poisonUserControl1";
            poisonUserControl1.Size = new Size(465, 139);
            poisonUserControl1.TabIndex = 3;
            poisonUserControl1.UseSelectable = true;
            // 
            // Inc
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(poisonUserControl1);
            Name = "Inc";
            Size = new Size(615, 155);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.PoisonUserControl poisonUserControl1;
    }
}
