namespace ONION_Your_Personal_PlantCare_Companion
{
    partial class ListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListControl));
            panel1 = new Panel();
            txtSearchPlant = new TextBox();
            lblPlantCount = new SiticoneNetCoreUI.SiticoneShimmerLabel();
            button1 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            plantdata1 = new Plantdata();
            plantdata2 = new Plantdata();
            plantdata3 = new Plantdata();
            plantdata4 = new Plantdata();
            plantdata5 = new Plantdata();
            plantdata6 = new Plantdata();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(228, 239, 231);
            panel1.Controls.Add(txtSearchPlant);
            panel1.Controls.Add(lblPlantCount);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(891, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(121, 658);
            panel1.TabIndex = 4;
            // 
            // txtSearchPlant
            // 
            txtSearchPlant.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtSearchPlant.Dock = DockStyle.Top;
            txtSearchPlant.Location = new Point(0, 62);
            txtSearchPlant.Name = "txtSearchPlant";
            txtSearchPlant.Size = new Size(121, 27);
            txtSearchPlant.TabIndex = 2;
            txtSearchPlant.TextChanged += txtSearchPlant_TextChanged;
            // 
            // lblPlantCount
            // 
            lblPlantCount.AutoReverse = false;
            lblPlantCount.BaseColor = Color.Black;
            lblPlantCount.Direction = SiticoneNetCoreUI.ShimmerDirection.LeftToRight;
            lblPlantCount.Dock = DockStyle.Top;
            lblPlantCount.Font = new Font("Segoe UI", 10F);
            lblPlantCount.IsAnimating = true;
            lblPlantCount.IsPaused = false;
            lblPlantCount.Location = new Point(0, 0);
            lblPlantCount.Name = "lblPlantCount";
            lblPlantCount.PauseDuration = 0;
            lblPlantCount.ShimmerColor = Color.Cyan;
            lblPlantCount.ShimmerOpacity = 1F;
            lblPlantCount.ShimmerSpeed = 50;
            lblPlantCount.ShimmerWidth = 0.2F;
            lblPlantCount.Size = new Size(121, 62);
            lblPlantCount.TabIndex = 1;
            lblPlantCount.Text = "siticoneShimmerLabel1";
            lblPlantCount.ToolTipText = "";
            // 
            // button1
            // 
            button1.Dock = DockStyle.Bottom;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(0, 603);
            button1.Name = "button1";
            button1.Size = new Size(121, 55);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(228, 239, 231);
            flowLayoutPanel1.Controls.Add(plantdata1);
            flowLayoutPanel1.Controls.Add(plantdata2);
            flowLayoutPanel1.Controls.Add(plantdata3);
            flowLayoutPanel1.Controls.Add(plantdata4);
            flowLayoutPanel1.Controls.Add(plantdata5);
            flowLayoutPanel1.Controls.Add(plantdata6);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(891, 658);
            flowLayoutPanel1.TabIndex = 5;
            flowLayoutPanel1.MouseClick += flowLayoutPanel1_MouseClick;
            // 
            // plantdata1
            // 
            plantdata1.FertilizationSchedule = "Fertilization: Fertilization: Fertilization: Fertilization: Fertilization: Fertilization Schedule:";
            plantdata1.Location = new Point(3, 3);
            plantdata1.Name = "plantdata1";
            plantdata1.PlantID = null;
            plantdata1.PlantName = "Plant: ";
            plantdata1.Size = new Size(280, 315);
            plantdata1.TabIndex = 0;
            plantdata1.WateringFrequency = "Watering: Watering: Watering: Watering: Watering: Watering Frequency:";
            // 
            // plantdata2
            // 
            plantdata2.FertilizationSchedule = "Fertilization: Fertilization: Fertilization: Fertilization: Fertilization: Fertilization Schedule:";
            plantdata2.Location = new Point(289, 3);
            plantdata2.Name = "plantdata2";
            plantdata2.PlantID = null;
            plantdata2.PlantName = "Plant: ";
            plantdata2.Size = new Size(280, 315);
            plantdata2.TabIndex = 0;
            plantdata2.WateringFrequency = "Watering: Watering: Watering: Watering: Watering: Watering Frequency:";
            // 
            // plantdata3
            // 
            plantdata3.FertilizationSchedule = "Fertilization: Fertilization: Fertilization: Fertilization: Fertilization: Fertilization Schedule:";
            plantdata3.Location = new Point(575, 3);
            plantdata3.Name = "plantdata3";
            plantdata3.PlantID = null;
            plantdata3.PlantName = "Plant: ";
            plantdata3.Size = new Size(280, 315);
            plantdata3.TabIndex = 0;
            plantdata3.WateringFrequency = "Watering: Watering: Watering: Watering: Watering: Watering Frequency:";
            // 
            // plantdata4
            // 
            plantdata4.FertilizationSchedule = "Fertilization: Fertilization: Fertilization: Fertilization: Fertilization: Fertilization Schedule:";
            plantdata4.Location = new Point(3, 324);
            plantdata4.Name = "plantdata4";
            plantdata4.PlantID = null;
            plantdata4.PlantName = "Plant: ";
            plantdata4.Size = new Size(280, 315);
            plantdata4.TabIndex = 0;
            plantdata4.WateringFrequency = "Watering: Watering: Watering: Watering: Watering: Watering Frequency:";
            // 
            // plantdata5
            // 
            plantdata5.FertilizationSchedule = "Fertilization: Fertilization: Fertilization: Fertilization: Fertilization: Fertilization Schedule:";
            plantdata5.Location = new Point(289, 324);
            plantdata5.Name = "plantdata5";
            plantdata5.PlantID = null;
            plantdata5.PlantName = "Plant: ";
            plantdata5.Size = new Size(280, 315);
            plantdata5.TabIndex = 0;
            plantdata5.WateringFrequency = "Watering: Watering: Watering: Watering: Watering: Watering Frequency:";
            // 
            // plantdata6
            // 
            plantdata6.FertilizationSchedule = "Fertilization: Fertilization: Fertilization: Fertilization: Fertilization: Fertilization Schedule:";
            plantdata6.Location = new Point(575, 324);
            plantdata6.Name = "plantdata6";
            plantdata6.PlantID = null;
            plantdata6.PlantName = "Plant: ";
            plantdata6.Size = new Size(280, 315);
            plantdata6.TabIndex = 0;
            plantdata6.WateringFrequency = "Watering: Watering: Watering: Watering: Watering: Watering Frequency:";
            // 
            // ListControl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Name = "ListControl";
            Size = new Size(1012, 658);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Plantdata plantdata1;
        private Plantdata plantdata2;
        private Plantdata plantdata3;
        private Plantdata plantdata4;
        private Plantdata plantdata5;
        private Plantdata plantdata6;
        private Button button1;
        private TextBox txtSearchPlant;
        private SiticoneNetCoreUI.SiticoneShimmerLabel lblPlantCount;
    }
}
