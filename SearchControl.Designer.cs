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
            searchTextBox = new TextBox();
            panel1 = new Panel();
            button1 = new Button();
            searchContainer = new FlowLayoutPanel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            lblDescription = new Label();
            lblFertilizationFrequency = new Label();
            lblWateringFrequency = new Label();
            lblScientificName = new Label();
            lblCommonName = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // searchTextBox
            // 
            searchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            searchTextBox.BackColor = Color.FromArgb(228, 239, 231);
            searchTextBox.BorderStyle = BorderStyle.None;
            searchTextBox.Location = new Point(490, 21);
            searchTextBox.Multiline = true;
            searchTextBox.Name = "searchTextBox";
            searchTextBox.Size = new Size(435, 35);
            searchTextBox.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(153, 188, 133);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(searchTextBox);
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
            // searchContainer
            // 
            searchContainer.AutoScroll = true;
            searchContainer.FlowDirection = FlowDirection.TopDown;
            searchContainer.Location = new Point(490, 0);
            searchContainer.Name = "searchContainer";
            searchContainer.Size = new Size(469, 135);
            searchContainer.TabIndex = 2;
            searchContainer.WrapContents = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(228, 239, 231);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(lblDescription);
            panel2.Controls.Add(lblFertilizationFrequency);
            panel2.Controls.Add(lblWateringFrequency);
            panel2.Controls.Add(lblScientificName);
            panel2.Controls.Add(lblCommonName);
            panel2.Controls.Add(searchContainer);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(1012, 665);
            panel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(38, 35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 220);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Leelawadee UI", 16.2F);
            lblDescription.Location = new Point(38, 274);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(91, 38);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "label1";
            // 
            // lblFertilizationFrequency
            // 
            lblFertilizationFrequency.AutoSize = true;
            lblFertilizationFrequency.Font = new Font("Leelawadee UI", 16.2F);
            lblFertilizationFrequency.Location = new Point(264, 211);
            lblFertilizationFrequency.Name = "lblFertilizationFrequency";
            lblFertilizationFrequency.Size = new Size(91, 38);
            lblFertilizationFrequency.TabIndex = 4;
            lblFertilizationFrequency.Text = "label1";
            // 
            // lblWateringFrequency
            // 
            lblWateringFrequency.AutoSize = true;
            lblWateringFrequency.Font = new Font("Leelawadee UI", 16.2F);
            lblWateringFrequency.Location = new Point(264, 173);
            lblWateringFrequency.Name = "lblWateringFrequency";
            lblWateringFrequency.Size = new Size(91, 38);
            lblWateringFrequency.TabIndex = 5;
            lblWateringFrequency.Text = "label1";
            // 
            // lblScientificName
            // 
            lblScientificName.AutoSize = true;
            lblScientificName.Font = new Font("Leelawadee UI", 16.2F);
            lblScientificName.Location = new Point(264, 135);
            lblScientificName.Name = "lblScientificName";
            lblScientificName.Size = new Size(91, 38);
            lblScientificName.TabIndex = 6;
            lblScientificName.Text = "label1";
            // 
            // lblCommonName
            // 
            lblCommonName.AutoSize = true;
            lblCommonName.Font = new Font("Leelawadee UI", 16.2F);
            lblCommonName.Location = new Point(264, 97);
            lblCommonName.Name = "lblCommonName";
            lblCommonName.Size = new Size(91, 38);
            lblCommonName.TabIndex = 7;
            lblCommonName.Text = "label1";
            // 
            // SearchControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "SearchControl";
            Size = new Size(1012, 731);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox searchTextBox;
        private Panel panel1;
        private Button button1;
        private FlowLayoutPanel searchContainer;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label lblDescription;
        private Label lblFertilizationFrequency;
        private Label lblWateringFrequency;
        private Label lblScientificName;
        private Label lblCommonName;
    }
}
