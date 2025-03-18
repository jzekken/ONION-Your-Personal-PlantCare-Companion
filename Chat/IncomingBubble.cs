using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ONION_Your_Personal_PlantCare_Companion.Chat
{
    public partial class IncomingBubble : UserControl
    {
        public string Message
        {
            get => lblMessage.Text;
            set
            {
                lblMessage.Text = value;
                AdjustSize(); // ✅ Call AdjustSize() to fix positioning
            }
        }

        public IncomingBubble()
        {
            InitializeComponent();
            this.MinimumSize = new Size(100, 40); // Prevents cut-off
            this.AutoSize = false; // ✅ Set false so we can manually resize
            lblMessage.MaximumSize = new Size(300, 0); // ✅ Allows text wrapping
            lblMessage.AutoSize = true;
        }

        private void AdjustSize()
        {
            lblMessage.MaximumSize = new Size(300, 0);
            lblMessage.AutoSize = true;

            this.Width = lblMessage.PreferredWidth + 20;  // ✅ Ensures proper width
            this.Height = lblMessage.PreferredHeight + 20; // ✅ Ensures proper height

            this.Invalidate(); // ✅ Forces redraw
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            GraphicsPath path = new GraphicsPath();
            int radius = 15;

            int bubbleWidth = this.Width - 1;  // ✅ Prevents boundary issues
            int bubbleHeight = this.Height - 1;

            // Create rounded rectangle
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(bubbleWidth - radius, 0, radius, radius, 270, 90);
            path.AddArc(bubbleWidth - radius, bubbleHeight - radius, radius, radius, 0, 90);
            path.AddArc(0, bubbleHeight - radius, radius, radius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);
        }
    }
}
