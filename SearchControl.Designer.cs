namespace ONION_Your_Personal_PlantCare_Companion
{
    partial class SearchControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchControl));
            txtSearch = new TextBox();
            panel1 = new Panel();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            result1 = new result();
            result2 = new result();
            result3 = new result();
            result4 = new result();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.BackColor = Color.FromArgb(228, 239, 231);
            txtSearch.BorderStyle = BorderStyle.None;
            txtSearch.Location = new Point(490, 21);
            txtSearch.Multiline = true;
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(434, 34);
            txtSearch.TabIndex = 0;
            txtSearch.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(153, 188, 133);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1012, 66);
            panel1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(929, 24);
            button1.Name = "button1";
            button1.Size = new Size(30, 25);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(228, 239, 231);
            flowLayoutPanel1.Controls.Add(result1);
            flowLayoutPanel1.Controls.Add(result2);
            flowLayoutPanel1.Controls.Add(result3);
            flowLayoutPanel1.Controls.Add(result4);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 66);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1012, 665);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // result1
            // 
            result1.Location = new Point(3, 3);
            result1.Name = "result1";
            result1.Size = new Size(1008, 150);
            result1.TabIndex = 0;
            // 
            // result2
            // 
            result2.Location = new Point(3, 159);
            result2.Name = "result2";
            result2.Size = new Size(1008, 150);
            result2.TabIndex = 1;
            // 
            // result3
            // 
            result3.Location = new Point(3, 315);
            result3.Name = "result3";
            result3.Size = new Size(1008, 150);
            result3.TabIndex = 2;
            // 
            // result4
            // 
            result4.Location = new Point(3, 471);
            result4.Name = "result4";
            result4.Size = new Size(1008, 150);
            result4.TabIndex = 3;
            // 
            // SearchControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "SearchControl";
            Size = new Size(1012, 731);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtSearch;
        private Panel panel1;
        private Button button1;
        private FlowLayoutPanel flowLayoutPanel1;
        private result result1;
        private result result2;
        private result result3;
        private result result4;
    }
}
