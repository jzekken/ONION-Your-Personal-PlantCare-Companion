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
    public partial class OutgoingBubble : UserControl
    {
        public string Message
        {
            get { return lblMessage.Text; }
            set { lblMessage.Text = value; AdjustSize(); }
        }

        public OutgoingBubble()
        {
            InitializeComponent();
            this.MinimumSize = new Size(100, 40);  // Prevents cut-off
            this.AutoSize = false;  // ✅ Set to false to allow manual resizing
            lblMessage.MaximumSize = new Size(350, 0); // ✅ Allows text wrapping
            lblMessage.AutoSize = true;

            this.BackColor = Color.LightBlue; // ✅ Outgoing bubble color
            this.Padding = new Padding(10);
        }

        private void AdjustSize()
        {
            lblMessage.MaximumSize = new Size(350, 0);
            lblMessage.AutoSize = true;

            this.Width = lblMessage.PreferredWidth + 30;  // ✅ Adjusted for padding
            this.Height = lblMessage.PreferredHeight + 20;

            this.Invalidate(); // ✅ Force redraw
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            GraphicsPath path = new GraphicsPath();
            int radius = 15;

            int bubbleWidth = this.Width - 1;  // ✅ Fix boundary issues
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
