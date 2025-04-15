namespace ONION_Your_Personal_PlantCare_Companion
{
    partial class TalkControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TalkControl));
            panel1 = new Panel();
            attachbtn = new Button();
            toggleVoiceBtn = new Button();
            button1 = new Button();
            btnSend = new Button();
            txtUserInput = new TextBox();
            panelContainer = new TableLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(228, 239, 231);
            panel1.Controls.Add(attachbtn);
            panel1.Controls.Add(toggleVoiceBtn);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btnSend);
            panel1.Controls.Add(txtUserInput);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 533);
            panel1.Name = "panel1";
            panel1.Size = new Size(1012, 125);
            panel1.TabIndex = 0;
            // 
            // attachbtn
            // 
            attachbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            attachbtn.FlatAppearance.BorderSize = 0;
            attachbtn.FlatStyle = FlatStyle.Flat;
            attachbtn.Image = (Image)resources.GetObject("attachbtn.Image");
            attachbtn.Location = new Point(761, 62);
            attachbtn.Name = "attachbtn";
            attachbtn.Size = new Size(30, 25);
            attachbtn.TabIndex = 1;
            attachbtn.UseVisualStyleBackColor = true;
            attachbtn.Click += attachbtn_Click;
            // 
            // toggleVoiceBtn
            // 
            toggleVoiceBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            toggleVoiceBtn.FlatAppearance.BorderSize = 0;
            toggleVoiceBtn.FlatStyle = FlatStyle.Flat;
            toggleVoiceBtn.Image = (Image)resources.GetObject("toggleVoiceBtn.Image");
            toggleVoiceBtn.Location = new Point(797, 62);
            toggleVoiceBtn.Name = "toggleVoiceBtn";
            toggleVoiceBtn.Size = new Size(30, 25);
            toggleVoiceBtn.TabIndex = 1;
            toggleVoiceBtn.UseVisualStyleBackColor = true;
            toggleVoiceBtn.Visible = false;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(982, 100);
            button1.Name = "button1";
            button1.Size = new Size(30, 25);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSend.BackColor = Color.Transparent;
            btnSend.FlatAppearance.BorderSize = 0;
            btnSend.FlatStyle = FlatStyle.Flat;
            btnSend.Image = (Image)resources.GetObject("btnSend.Image");
            btnSend.Location = new Point(833, 60);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(80, 29);
            btnSend.TabIndex = 0;
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += button1_Click;
            // 
            // txtUserInput
            // 
            txtUserInput.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtUserInput.Location = new Point(108, 17);
            txtUserInput.Multiline = true;
            txtUserInput.Name = "txtUserInput";
            txtUserInput.Size = new Size(819, 82);
            txtUserInput.TabIndex = 0;
            // 
            // panelContainer
            // 
            panelContainer.AutoScroll = true;
            panelContainer.AutoSize = true;
            panelContainer.BackColor = Color.FromArgb(228, 239, 231);
            panelContainer.ColumnCount = 2;
            panelContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panelContainer.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Padding = new Padding(5, 0, 5, 0);
            panelContainer.RowCount = 1;
            panelContainer.RowStyles.Add(new RowStyle());
            panelContainer.Size = new Size(1012, 533);
            panelContainer.TabIndex = 1;
            // 
            // TalkControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panelContainer);
            Controls.Add(panel1);
            Name = "TalkControl";
            Size = new Size(1012, 658);
            Load += TalkControl_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnSend;
        private TextBox txtUserInput;
        private TableLayoutPanel panelContainer;
        private Button button1;
        private Button toggleVoiceBtn;
        private Button attachbtn;
    }
}
