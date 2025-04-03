namespace ONION_Your_Personal_PlantCare_Companion
{
    partial class Doubleclick
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doubleclick));
            SiticoneNetCoreUI.SiticoneRadialProgressBar.ProgressColorRange progressColorRange1 = new SiticoneNetCoreUI.SiticoneRadialProgressBar.ProgressColorRange();
            SiticoneNetCoreUI.SiticoneRadialProgressBar.ProgressColorRange progressColorRange2 = new SiticoneNetCoreUI.SiticoneRadialProgressBar.ProgressColorRange();
            SiticoneNetCoreUI.SiticoneRadialProgressBar.ProgressColorRange progressColorRange3 = new SiticoneNetCoreUI.SiticoneRadialProgressBar.ProgressColorRange();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            siticoneShimmerLabel1 = new SiticoneNetCoreUI.SiticoneShimmerLabel();
            siticoneShimmerLabel2 = new SiticoneNetCoreUI.SiticoneShimmerLabel();
            siticoneRadialProgressBar1 = new SiticoneNetCoreUI.SiticoneRadialProgressBar();
            parrotBarGraph1 = new ReaLTaiizor.Controls.ParrotBarGraph();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(160, 160);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(tableLayoutPanel1);
            flowLayoutPanel1.Controls.Add(siticoneRadialProgressBar1);
            flowLayoutPanel1.Controls.Add(parrotBarGraph1);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(802, 453);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(siticoneShimmerLabel1, 0, 0);
            tableLayoutPanel1.Controls.Add(siticoneShimmerLabel2, 0, 1);
            tableLayoutPanel1.Location = new Point(169, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(621, 160);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // siticoneShimmerLabel1
            // 
            siticoneShimmerLabel1.AutoReverse = false;
            siticoneShimmerLabel1.BaseColor = Color.Black;
            siticoneShimmerLabel1.Direction = SiticoneNetCoreUI.ShimmerDirection.LeftToRight;
            siticoneShimmerLabel1.Font = new Font("Segoe UI", 10F);
            siticoneShimmerLabel1.IsAnimating = true;
            siticoneShimmerLabel1.IsPaused = false;
            siticoneShimmerLabel1.Location = new Point(3, 3);
            siticoneShimmerLabel1.Name = "siticoneShimmerLabel1";
            siticoneShimmerLabel1.PauseDuration = 0;
            siticoneShimmerLabel1.ShimmerColor = Color.Cyan;
            siticoneShimmerLabel1.ShimmerOpacity = 1F;
            siticoneShimmerLabel1.ShimmerSpeed = 50;
            siticoneShimmerLabel1.ShimmerWidth = 0.2F;
            siticoneShimmerLabel1.Size = new Size(425, 62);
            siticoneShimmerLabel1.TabIndex = 0;
            siticoneShimmerLabel1.Text = "siticoneShimmerLabel1";
            siticoneShimmerLabel1.ToolTipText = "";
            // 
            // siticoneShimmerLabel2
            // 
            siticoneShimmerLabel2.AutoReverse = false;
            siticoneShimmerLabel2.BaseColor = Color.Black;
            siticoneShimmerLabel2.Direction = SiticoneNetCoreUI.ShimmerDirection.LeftToRight;
            siticoneShimmerLabel2.Font = new Font("Segoe UI", 10F);
            siticoneShimmerLabel2.IsAnimating = true;
            siticoneShimmerLabel2.IsPaused = false;
            siticoneShimmerLabel2.Location = new Point(3, 83);
            siticoneShimmerLabel2.Name = "siticoneShimmerLabel2";
            siticoneShimmerLabel2.PauseDuration = 0;
            siticoneShimmerLabel2.ShimmerColor = Color.Cyan;
            siticoneShimmerLabel2.ShimmerOpacity = 1F;
            siticoneShimmerLabel2.ShimmerSpeed = 50;
            siticoneShimmerLabel2.ShimmerWidth = 0.2F;
            siticoneShimmerLabel2.Size = new Size(425, 62);
            siticoneShimmerLabel2.TabIndex = 0;
            siticoneShimmerLabel2.Text = "siticoneShimmerLabel1";
            siticoneShimmerLabel2.ToolTipText = "";
            // 
            // siticoneRadialProgressBar1
            // 
            siticoneRadialProgressBar1.AccessibleDescription = "Displays progress in a circular form.";
            siticoneRadialProgressBar1.AccessibleName = "Radial Progress Bar";
            siticoneRadialProgressBar1.AnimationSpeed = 4;
            siticoneRadialProgressBar1.AnimationStepValue = 1D;
            siticoneRadialProgressBar1.CanBeep = false;
            siticoneRadialProgressBar1.CanShake = false;
            siticoneRadialProgressBar1.Clockwise = true;
            siticoneRadialProgressBar1.ColorAnimationCycle = (List<Color>)resources.GetObject("siticoneRadialProgressBar1.ColorAnimationCycle");
            siticoneRadialProgressBar1.CurrentColorTheme = SiticoneNetCoreUI.SiticoneRadialProgressBar.ColorTheme.Default;
            siticoneRadialProgressBar1.Easing = SiticoneNetCoreUI.SiticoneRadialProgressBar.EasingFunction.Linear;
            siticoneRadialProgressBar1.EnableBackgroundShading = false;
            siticoneRadialProgressBar1.EnableBounce = false;
            siticoneRadialProgressBar1.EnableContinuousRotation = false;
            siticoneRadialProgressBar1.EnableKeyboardSupport = false;
            siticoneRadialProgressBar1.EnablePulsate = false;
            siticoneRadialProgressBar1.EnableRangeBasedColoring = false;
            siticoneRadialProgressBar1.EnableTextShadow = false;
            siticoneRadialProgressBar1.FillProgressArea = false;
            siticoneRadialProgressBar1.Indeterminate = false;
            siticoneRadialProgressBar1.IsReadonly = false;
            siticoneRadialProgressBar1.Location = new Point(3, 169);
            siticoneRadialProgressBar1.Maximum = 100D;
            siticoneRadialProgressBar1.Minimum = 0D;
            siticoneRadialProgressBar1.MinimumSize = new Size(40, 40);
            siticoneRadialProgressBar1.MouseDragOrClickResponsive = false;
            siticoneRadialProgressBar1.MouseWheelResponsive = false;
            siticoneRadialProgressBar1.MouseWheelStepValue = 1D;
            siticoneRadialProgressBar1.Name = "siticoneRadialProgressBar1";
            siticoneRadialProgressBar1.ProgressBaseColor = Color.FromArgb(42, 34, 30, 65);
            progressColorRange1.Color = Color.Green;
            progressColorRange1.Maximum = 33D;
            progressColorRange1.Minimum = 0D;
            progressColorRange2.Color = Color.Yellow;
            progressColorRange2.Maximum = 66D;
            progressColorRange2.Minimum = 34D;
            progressColorRange3.Color = Color.Red;
            progressColorRange3.Maximum = 100D;
            progressColorRange3.Minimum = 67D;
            siticoneRadialProgressBar1.ProgressColorRanges.Add(progressColorRange1);
            siticoneRadialProgressBar1.ProgressColorRanges.Add(progressColorRange2);
            siticoneRadialProgressBar1.ProgressColorRanges.Add(progressColorRange3);
            siticoneRadialProgressBar1.ProgressFont = new Font("Segoe UI", 14F, FontStyle.Bold);
            siticoneRadialProgressBar1.ProgressThickness = 15F;
            siticoneRadialProgressBar1.ReadonlyEndColor = Color.DarkGray;
            siticoneRadialProgressBar1.ReadonlyStartColor = Color.Gray;
            siticoneRadialProgressBar1.ReverseGradient = false;
            siticoneRadialProgressBar1.ShadowBlur = 5;
            siticoneRadialProgressBar1.ShadowColor = Color.FromArgb(100, 0, 0, 0);
            siticoneRadialProgressBar1.ShadowOffset = new Point(2, 2);
            siticoneRadialProgressBar1.ShowRadialBorder = true;
            siticoneRadialProgressBar1.Size = new Size(200, 200);
            siticoneRadialProgressBar1.StartAngle = -90;
            siticoneRadialProgressBar1.TabIndex = 2;
            siticoneRadialProgressBar1.Text = "siticoneRadialProgressBar1";
            siticoneRadialProgressBar1.TextFormat = "{0}%";
            siticoneRadialProgressBar1.Value = 78D;
            // 
            // parrotBarGraph1
            // 
            parrotBarGraph1.FilledColor = Color.FromArgb(30, 33, 38);
            parrotBarGraph1.GraphOrientation = ReaLTaiizor.Controls.ParrotBarGraph.Orientation.Vertical;
            parrotBarGraph1.GraphStyle = ReaLTaiizor.Controls.ParrotBarGraph.Style.Material;
            parrotBarGraph1.Items = (List<int>)resources.GetObject("parrotBarGraph1.Items");
            parrotBarGraph1.Location = new Point(209, 169);
            parrotBarGraph1.Name = "parrotBarGraph1";
            parrotBarGraph1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            parrotBarGraph1.ShowGrid = false;
            parrotBarGraph1.Size = new Size(368, 250);
            parrotBarGraph1.Sorting = ReaLTaiizor.Controls.ParrotBarGraph.SortStyle.Normal;
            parrotBarGraph1.SplitterColor = Color.FromArgb(59, 62, 71);
            parrotBarGraph1.TabIndex = 3;
            parrotBarGraph1.Text = "parrotBarGraph1";
            parrotBarGraph1.TextAlignment = ReaLTaiizor.Controls.ParrotBarGraph.Aligning.Far;
            parrotBarGraph1.TextColor = Color.FromArgb(120, 120, 120);
            parrotBarGraph1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            parrotBarGraph1.UnfilledColor = Color.FromArgb(37, 40, 49);
            // 
            // Doubleclick
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(802, 453);
            ControlBox = false;
            Controls.Add(flowLayoutPanel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Doubleclick";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private SiticoneNetCoreUI.SiticoneShimmerLabel siticoneShimmerLabel1;
        private SiticoneNetCoreUI.SiticoneShimmerLabel siticoneShimmerLabel2;
        private SiticoneNetCoreUI.SiticoneRadialProgressBar siticoneRadialProgressBar1;
        private ReaLTaiizor.Controls.ParrotBarGraph parrotBarGraph1;
    }
}