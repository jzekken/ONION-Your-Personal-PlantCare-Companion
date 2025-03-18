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
            btnSend = new Button();
            txtUserInput = new TextBox();
            panelContainer = new FlowLayoutPanel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnSend);
            panel1.Controls.Add(txtUserInput);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 533);
            panel1.Name = "panel1";
            panel1.Size = new Size(1012, 125);
            panel1.TabIndex = 0;
            // 
            // btnSend
            // 
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
            txtUserInput.Location = new Point(108, 17);
            txtUserInput.Multiline = true;
            txtUserInput.Name = "txtUserInput";
            txtUserInput.Size = new Size(819, 82);
            txtUserInput.TabIndex = 0;
            // 
            // panelContainer
            // 
            panelContainer.AutoScroll = true;
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.FlowDirection = FlowDirection.RightToLeft;
            panelContainer.Location = new Point(0, 0);
            panelContainer.Name = "panelContainer";
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSend;
        private TextBox txtUserInput;
        private FlowLayoutPanel panelContainer;
    }
}
