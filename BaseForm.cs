using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ONION_Your_Personal_PlantCare_Companion
{
    public class BaseForm : Form
    {
        protected Button activeButton;
        protected Panel mainPanel;

        public BaseForm()
        {
            EnableDoubleBuffering();
            MakeFormRounded();
        }

        protected void EnableDoubleBuffering()
        {
            mainPanel?.GetType().GetProperty("DoubleBuffered",
                System.Reflection.BindingFlags.Instance |
                System.Reflection.BindingFlags.NonPublic)
                ?.SetValue(mainPanel, true, null);
        }

        protected void MakeFormRounded()
        {
            this.FormBorderStyle = FormBorderStyle.None;
            int radius = 30;
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();

            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius - 1, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius - 1, this.Height - radius - 1, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius - 1, radius, radius, 90, 90);
            path.CloseAllFigures();
            this.Region = new Region(path);
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            MakeFormRounded();
        }

        protected async void LoadUserControl(UserControl userControl, Button clickedButton)
        {
            if (mainPanel.Controls.Count > 0)
            {
                var currentControl = mainPanel.Controls[0];

                for (int i = 100; i >= 0; i -= 25)
                {
                    currentControl.BackColor = Color.FromArgb(i * 255 / 100, currentControl.BackColor);
                    await Task.Delay(5);
                }

                mainPanel.Controls.Clear();
                currentControl.Dispose();
            }

            mainPanel.SuspendLayout();
            userControl.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(userControl);
            userControl.BringToFront();
            mainPanel.ResumeLayout();
            mainPanel.Refresh();

            for (int i = 0; i <= 100; i += 25)
            {
                userControl.BackColor = Color.FromArgb(i * 255 / 100, userControl.BackColor);
                await Task.Delay(5);
            }

            if (activeButton != null)
                activeButton.BackColor = Color.FromArgb(224, 239, 204);

            clickedButton.BackColor = Color.LightGreen;
            activeButton = clickedButton;
        }
    }
}
