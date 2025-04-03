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
            flowLayoutPanel2 = new FlowLayoutPanel();
            label1 = new Label();
            lblFertilizationFrequency = new Label();
            lblWateringFrequency = new Label();
            lblDescription = new Label();
            label3 = new Label();
            lblTemperature = new Label();
            lblSunlight = new Label();
            lblSoil = new Label();
            lblHumidity = new Label();
            lblPruning = new Label();
            label2 = new Label();
            lblHeight = new Label();
            lblGrowthRate = new Label();
            lblFlowering = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            lblScientificName = new Label();
            lblCommonName = new Label();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            panel1.Controls.Add(pictureBox2);
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
            searchContainer.Anchor = AnchorStyles.Top | AnchorStyles.Right;
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
            panel2.Controls.Add(flowLayoutPanel2);
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Controls.Add(searchContainer);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(lblScientificName);
            panel2.Controls.Add(lblCommonName);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 66);
            panel2.Name = "panel2";
            panel2.Size = new Size(1012, 665);
            panel2.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            flowLayoutPanel2.AutoScroll = true;
            flowLayoutPanel2.Controls.Add(label1);
            flowLayoutPanel2.Controls.Add(lblFertilizationFrequency);
            flowLayoutPanel2.Controls.Add(lblWateringFrequency);
            flowLayoutPanel2.Controls.Add(lblDescription);
            flowLayoutPanel2.Controls.Add(label3);
            flowLayoutPanel2.Controls.Add(lblTemperature);
            flowLayoutPanel2.Controls.Add(lblSunlight);
            flowLayoutPanel2.Controls.Add(lblSoil);
            flowLayoutPanel2.Controls.Add(lblHumidity);
            flowLayoutPanel2.Controls.Add(lblPruning);
            flowLayoutPanel2.Controls.Add(label2);
            flowLayoutPanel2.Controls.Add(lblHeight);
            flowLayoutPanel2.Controls.Add(lblGrowthRate);
            flowLayoutPanel2.Controls.Add(lblFlowering);
            flowLayoutPanel2.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel2.Location = new Point(38, 302);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(953, 343);
            flowLayoutPanel2.TabIndex = 13;
            flowLayoutPanel2.WrapContents = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 0);
            label1.MaximumSize = new Size(850, 0);
            label1.Name = "label1";
            label1.Padding = new Padding(30, 0, 0, 0);
            label1.Size = new Size(230, 38);
            label1.TabIndex = 5;
            label1.Text = "🌿 Basic Info ";
            // 
            // lblFertilizationFrequency
            // 
            lblFertilizationFrequency.AutoSize = true;
            lblFertilizationFrequency.Font = new Font("Leelawadee UI", 16.2F);
            lblFertilizationFrequency.Location = new Point(3, 38);
            lblFertilizationFrequency.MaximumSize = new Size(850, 0);
            lblFertilizationFrequency.Name = "lblFertilizationFrequency";
            lblFertilizationFrequency.Padding = new Padding(0, 5, 0, 5);
            lblFertilizationFrequency.Size = new Size(91, 48);
            lblFertilizationFrequency.TabIndex = 4;
            lblFertilizationFrequency.Text = "label1";
            // 
            // lblWateringFrequency
            // 
            lblWateringFrequency.AutoSize = true;
            lblWateringFrequency.Font = new Font("Leelawadee UI", 16.2F);
            lblWateringFrequency.Location = new Point(3, 86);
            lblWateringFrequency.MaximumSize = new Size(850, 0);
            lblWateringFrequency.Name = "lblWateringFrequency";
            lblWateringFrequency.Padding = new Padding(0, 5, 0, 5);
            lblWateringFrequency.Size = new Size(91, 48);
            lblWateringFrequency.TabIndex = 5;
            lblWateringFrequency.Text = "label1";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Leelawadee UI", 16.2F);
            lblDescription.Location = new Point(3, 134);
            lblDescription.MaximumSize = new Size(850, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Padding = new Padding(0, 5, 0, 5);
            lblDescription.Size = new Size(91, 48);
            lblDescription.TabIndex = 3;
            lblDescription.Text = "label1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Bold);
            label3.Location = new Point(3, 182);
            label3.MaximumSize = new Size(850, 0);
            label3.Name = "label3";
            label3.Padding = new Padding(30, 0, 0, 0);
            label3.Size = new Size(403, 38);
            label3.TabIndex = 5;
            label3.Text = "🌞 Care and Maintenance  ";
            // 
            // lblTemperature
            // 
            lblTemperature.AutoSize = true;
            lblTemperature.Font = new Font("Leelawadee UI", 16.2F);
            lblTemperature.Location = new Point(3, 220);
            lblTemperature.MaximumSize = new Size(850, 0);
            lblTemperature.Name = "lblTemperature";
            lblTemperature.Padding = new Padding(0, 5, 0, 5);
            lblTemperature.Size = new Size(91, 48);
            lblTemperature.TabIndex = 5;
            lblTemperature.Text = "label1";
            // 
            // lblSunlight
            // 
            lblSunlight.AutoSize = true;
            lblSunlight.Font = new Font("Leelawadee UI", 16.2F);
            lblSunlight.Location = new Point(3, 268);
            lblSunlight.MaximumSize = new Size(850, 0);
            lblSunlight.Name = "lblSunlight";
            lblSunlight.Padding = new Padding(0, 5, 0, 5);
            lblSunlight.Size = new Size(91, 48);
            lblSunlight.TabIndex = 5;
            lblSunlight.Text = "label1";
            // 
            // lblSoil
            // 
            lblSoil.AutoSize = true;
            lblSoil.Font = new Font("Leelawadee UI", 16.2F);
            lblSoil.Location = new Point(3, 316);
            lblSoil.MaximumSize = new Size(850, 0);
            lblSoil.Name = "lblSoil";
            lblSoil.Padding = new Padding(0, 5, 0, 5);
            lblSoil.Size = new Size(91, 48);
            lblSoil.TabIndex = 5;
            lblSoil.Text = "label1";
            // 
            // lblHumidity
            // 
            lblHumidity.AutoSize = true;
            lblHumidity.Font = new Font("Leelawadee UI", 16.2F);
            lblHumidity.Location = new Point(3, 364);
            lblHumidity.MaximumSize = new Size(850, 0);
            lblHumidity.Name = "lblHumidity";
            lblHumidity.Padding = new Padding(0, 5, 0, 5);
            lblHumidity.Size = new Size(91, 48);
            lblHumidity.TabIndex = 5;
            lblHumidity.Text = "label1";
            // 
            // lblPruning
            // 
            lblPruning.AutoSize = true;
            lblPruning.Font = new Font("Leelawadee UI", 16.2F);
            lblPruning.Location = new Point(3, 412);
            lblPruning.MaximumSize = new Size(850, 0);
            lblPruning.Name = "lblPruning";
            lblPruning.Padding = new Padding(0, 5, 0, 5);
            lblPruning.Size = new Size(91, 48);
            lblPruning.TabIndex = 5;
            lblPruning.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Leelawadee UI", 16.2F, FontStyle.Bold);
            label2.Location = new Point(3, 460);
            label2.MaximumSize = new Size(850, 0);
            label2.Name = "label2";
            label2.Padding = new Padding(30, 0, 0, 0);
            label2.Size = new Size(420, 38);
            label2.TabIndex = 5;
            label2.Text = " 🌱Growth and Appearance ";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Font = new Font("Leelawadee UI", 16.2F);
            lblHeight.Location = new Point(3, 498);
            lblHeight.MaximumSize = new Size(850, 0);
            lblHeight.Name = "lblHeight";
            lblHeight.Padding = new Padding(0, 5, 0, 5);
            lblHeight.Size = new Size(91, 48);
            lblHeight.TabIndex = 5;
            lblHeight.Text = "label1";
            // 
            // lblGrowthRate
            // 
            lblGrowthRate.AutoSize = true;
            lblGrowthRate.Font = new Font("Leelawadee UI", 16.2F);
            lblGrowthRate.Location = new Point(3, 546);
            lblGrowthRate.MaximumSize = new Size(850, 0);
            lblGrowthRate.Name = "lblGrowthRate";
            lblGrowthRate.Padding = new Padding(0, 5, 0, 5);
            lblGrowthRate.Size = new Size(91, 48);
            lblGrowthRate.TabIndex = 5;
            lblGrowthRate.Text = "label1";
            // 
            // lblFlowering
            // 
            lblFlowering.AutoSize = true;
            lblFlowering.Font = new Font("Leelawadee UI", 16.2F);
            lblFlowering.Location = new Point(3, 594);
            lblFlowering.MaximumSize = new Size(850, 0);
            lblFlowering.Name = "lblFlowering";
            lblFlowering.Padding = new Padding(0, 5, 0, 5);
            lblFlowering.Size = new Size(91, 48);
            lblFlowering.TabIndex = 5;
            lblFlowering.Text = "label1";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(221, 97);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(0, 0);
            flowLayoutPanel1.TabIndex = 12;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(38, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 250);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // lblScientificName
            // 
            lblScientificName.AutoSize = true;
            lblScientificName.Font = new Font("Leelawadee UI", 16.2F);
            lblScientificName.Location = new Point(294, 178);
            lblScientificName.Name = "lblScientificName";
            lblScientificName.Size = new Size(91, 38);
            lblScientificName.TabIndex = 6;
            lblScientificName.Text = "label1";
            // 
            // lblCommonName
            // 
            lblCommonName.AutoSize = true;
            lblCommonName.Font = new Font("Leelawadee UI", 16.2F);
            lblCommonName.Location = new Point(294, 97);
            lblCommonName.Name = "lblCommonName";
            lblCommonName.Size = new Size(91, 38);
            lblCommonName.TabIndex = 7;
            lblCommonName.Text = "label1";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(18, -55);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(270, 142);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
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
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
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
        private Label lblFlowering;
        private Label lblGrowthRate;
        private Label lblHeight;
        private Label lblPruning;
        private Label lblHumidity;
        private Label lblSoil;
        private Label lblSunlight;
        private Label lblTemperature;
        private Label label1;
        private Label label3;
        private Label label2;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private PictureBox pictureBox2;
    }
}
