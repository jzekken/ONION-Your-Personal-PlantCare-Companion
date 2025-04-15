namespace ONION_Your_Personal_PlantCare_Companion
{
    partial class Form2
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            panel1 = new Panel();
            minbtn = new Button();
            maxbtn = new Button();
            button7 = new Button();
            lblDateTime = new Label();
            label1 = new Label();
            panel2 = new Panel();
            toggleVoiceBtn = new Button();
            pictureBox1 = new PictureBox();
            aboutbtn = new Button();
            gardenbtn = new Button();
            listbtn = new Button();
            label3 = new Label();
            talkbtn = new Button();
            searchbtn = new Button();
            homebtn = new Button();
            label2 = new Label();
            mainPanel = new Panel();
            fadeInTimer = new System.Windows.Forms.Timer(components);
            timer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(180, 213, 137);
            panel1.Controls.Add(minbtn);
            panel1.Controls.Add(maxbtn);
            panel1.Controls.Add(button7);
            panel1.Controls.Add(lblDateTime);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1280, 44);
            panel1.TabIndex = 0;
            // 
            // minbtn
            // 
            minbtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            minbtn.FlatAppearance.BorderSize = 0;
            minbtn.FlatStyle = FlatStyle.Flat;
            minbtn.Image = (Image)resources.GetObject("minbtn.Image");
            minbtn.Location = new Point(1175, -1);
            minbtn.Name = "minbtn";
            minbtn.Size = new Size(30, 32);
            minbtn.TabIndex = 1;
            minbtn.UseVisualStyleBackColor = true;
            minbtn.Click += minbtn_Click;
            // 
            // maxbtn
            // 
            maxbtn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            maxbtn.FlatAppearance.BorderSize = 0;
            maxbtn.FlatStyle = FlatStyle.Flat;
            maxbtn.Image = (Image)resources.GetObject("maxbtn.Image");
            maxbtn.Location = new Point(1211, 9);
            maxbtn.Name = "maxbtn";
            maxbtn.Size = new Size(30, 32);
            maxbtn.TabIndex = 1;
            maxbtn.UseVisualStyleBackColor = true;
            maxbtn.Click += maxbtn_Click;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.Location = new Point(1247, 12);
            button7.Name = "button7";
            button7.Size = new Size(30, 25);
            button7.TabIndex = 1;
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateTime.Location = new Point(250, 11);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Padding = new Padding(10, 0, 0, 0);
            lblDateTime.Size = new Size(87, 28);
            lblDateTime.TabIndex = 0;
            lblDateTime.Text = "ONION";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee UI", 13.8F, FontStyle.Bold);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Padding = new Padding(10, 0, 0, 0);
            label1.Size = new Size(101, 31);
            label1.TabIndex = 0;
            label1.Text = "ONION";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 239, 204);
            panel2.Controls.Add(toggleVoiceBtn);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(aboutbtn);
            panel2.Controls.Add(gardenbtn);
            panel2.Controls.Add(listbtn);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(talkbtn);
            panel2.Controls.Add(searchbtn);
            panel2.Controls.Add(homebtn);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 44);
            panel2.Name = "panel2";
            panel2.Size = new Size(250, 676);
            panel2.TabIndex = 1;
            // 
            // toggleVoiceBtn
            // 
            toggleVoiceBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            toggleVoiceBtn.FlatStyle = FlatStyle.Flat;
            toggleVoiceBtn.Location = new Point(154, 430);
            toggleVoiceBtn.Name = "toggleVoiceBtn";
            toggleVoiceBtn.Size = new Size(94, 26);
            toggleVoiceBtn.TabIndex = 2;
            toggleVoiceBtn.Text = "Disable Voice";
            toggleVoiceBtn.UseVisualStyleBackColor = true;
            toggleVoiceBtn.Click += toggleVoiceBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Bottom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 456);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 220);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // aboutbtn
            // 
            aboutbtn.Dock = DockStyle.Top;
            aboutbtn.FlatAppearance.BorderSize = 0;
            aboutbtn.FlatStyle = FlatStyle.Flat;
            aboutbtn.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            aboutbtn.Image = (Image)resources.GetObject("aboutbtn.Image");
            aboutbtn.ImageAlign = ContentAlignment.MiddleLeft;
            aboutbtn.Location = new Point(0, 336);
            aboutbtn.Name = "aboutbtn";
            aboutbtn.Padding = new Padding(10, 5, 10, 5);
            aboutbtn.Size = new Size(250, 50);
            aboutbtn.TabIndex = 6;
            aboutbtn.Text = " About";
            aboutbtn.TextAlign = ContentAlignment.MiddleLeft;
            aboutbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            aboutbtn.UseVisualStyleBackColor = true;
            aboutbtn.Click += aboutbtn_Click;
            // 
            // gardenbtn
            // 
            gardenbtn.Dock = DockStyle.Top;
            gardenbtn.FlatAppearance.BorderSize = 0;
            gardenbtn.FlatStyle = FlatStyle.Flat;
            gardenbtn.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gardenbtn.Image = (Image)resources.GetObject("gardenbtn.Image");
            gardenbtn.ImageAlign = ContentAlignment.MiddleLeft;
            gardenbtn.Location = new Point(0, 286);
            gardenbtn.Name = "gardenbtn";
            gardenbtn.Padding = new Padding(10, 5, 10, 5);
            gardenbtn.Size = new Size(250, 50);
            gardenbtn.TabIndex = 5;
            gardenbtn.Text = " Garden View";
            gardenbtn.TextAlign = ContentAlignment.MiddleLeft;
            gardenbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            gardenbtn.UseVisualStyleBackColor = true;
            gardenbtn.Click += gardenbtn_Click;
            // 
            // listbtn
            // 
            listbtn.Dock = DockStyle.Top;
            listbtn.FlatAppearance.BorderSize = 0;
            listbtn.FlatStyle = FlatStyle.Flat;
            listbtn.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listbtn.Image = (Image)resources.GetObject("listbtn.Image");
            listbtn.ImageAlign = ContentAlignment.MiddleLeft;
            listbtn.Location = new Point(0, 236);
            listbtn.Name = "listbtn";
            listbtn.Padding = new Padding(10, 5, 10, 5);
            listbtn.Size = new Size(250, 50);
            listbtn.TabIndex = 4;
            listbtn.Text = " List of Plants";
            listbtn.TextAlign = ContentAlignment.MiddleLeft;
            listbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            listbtn.UseVisualStyleBackColor = true;
            listbtn.Click += listbtn_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Top;
            label3.Font = new Font("Leelawadee UI", 12F, FontStyle.Bold);
            label3.Location = new Point(0, 193);
            label3.Name = "label3";
            label3.Padding = new Padding(10, 10, 10, 5);
            label3.Size = new Size(98, 43);
            label3.TabIndex = 3;
            label3.Text = "Library";
            // 
            // talkbtn
            // 
            talkbtn.Dock = DockStyle.Top;
            talkbtn.FlatAppearance.BorderSize = 0;
            talkbtn.FlatStyle = FlatStyle.Flat;
            talkbtn.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            talkbtn.Image = (Image)resources.GetObject("talkbtn.Image");
            talkbtn.ImageAlign = ContentAlignment.MiddleLeft;
            talkbtn.Location = new Point(0, 143);
            talkbtn.Name = "talkbtn";
            talkbtn.Padding = new Padding(10, 5, 10, 5);
            talkbtn.Size = new Size(250, 50);
            talkbtn.TabIndex = 2;
            talkbtn.Text = " Talk to ONION.AI";
            talkbtn.TextAlign = ContentAlignment.MiddleLeft;
            talkbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            talkbtn.UseVisualStyleBackColor = true;
            talkbtn.Click += talkbtn_Click;
            // 
            // searchbtn
            // 
            searchbtn.Dock = DockStyle.Top;
            searchbtn.FlatAppearance.BorderSize = 0;
            searchbtn.FlatStyle = FlatStyle.Flat;
            searchbtn.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchbtn.Image = (Image)resources.GetObject("searchbtn.Image");
            searchbtn.ImageAlign = ContentAlignment.MiddleLeft;
            searchbtn.Location = new Point(0, 93);
            searchbtn.Name = "searchbtn";
            searchbtn.Padding = new Padding(10, 5, 10, 5);
            searchbtn.Size = new Size(250, 50);
            searchbtn.TabIndex = 1;
            searchbtn.Text = " Search For Plants";
            searchbtn.TextAlign = ContentAlignment.MiddleLeft;
            searchbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            searchbtn.UseVisualStyleBackColor = true;
            searchbtn.Click += searchbtn_Click;
            // 
            // homebtn
            // 
            homebtn.Dock = DockStyle.Top;
            homebtn.FlatAppearance.BorderSize = 0;
            homebtn.FlatStyle = FlatStyle.Flat;
            homebtn.Font = new Font("Leelawadee UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            homebtn.Image = (Image)resources.GetObject("homebtn.Image");
            homebtn.ImageAlign = ContentAlignment.MiddleLeft;
            homebtn.Location = new Point(0, 43);
            homebtn.Name = "homebtn";
            homebtn.Padding = new Padding(10, 5, 10, 5);
            homebtn.Size = new Size(250, 50);
            homebtn.TabIndex = 0;
            homebtn.Text = " Home";
            homebtn.TextAlign = ContentAlignment.MiddleLeft;
            homebtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            homebtn.UseVisualStyleBackColor = true;
            homebtn.Click += homebtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Leelawadee UI", 12F, FontStyle.Bold);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(10, 10, 10, 5);
            label2.Size = new Size(114, 43);
            label2.TabIndex = 0;
            label2.Text = "Discover";
            // 
            // mainPanel
            // 
            mainPanel.AutoScroll = true;
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(250, 44);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(1030, 676);
            mainPanel.TabIndex = 2;
            // 
            // fadeInTimer
            // 
            fadeInTimer.Interval = 30;
            fadeInTimer.Tick += fadeInTimer_Tick;
            // 
            // timer
            // 
            timer.Tick += timer_Tick;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(1280, 720);
            ControlBox = false;
            Controls.Add(mainPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MinimumSize = new Size(800, 600);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private Label label2;
        private Button aboutbtn;
        private Button gardenbtn;
        private Button listbtn;
        private Label label3;
        private Button talkbtn;
        private Button searchbtn;
        private Button homebtn;
        private Button button7;
        private Panel mainPanel;
        private Button minbtn;
        private Button maxbtn;
        private PictureBox pictureBox1;
        private Button toggleVoiceBtn;
        private System.Windows.Forms.Timer fadeInTimer;
        private Label lblDateTime;
        private System.Windows.Forms.Timer timer;
    }
}