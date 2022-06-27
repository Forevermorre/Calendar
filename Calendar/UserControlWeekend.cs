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

namespace Calendar
{
    public partial class UserControlWeekend : UserControl
    {
        private readonly Color WEEKEND_TEXT_COLOR = Color.FromArgb(176, 0, 0);
        private readonly Color Gradient1 = Color.FromArgb(25, 238, 82, 83);
        private readonly Color Gradient2 = Color.FromArgb(25, 248, 92, 93);
        private readonly Color Gradient3 = Color.FromArgb(25, 255, 102, 103);

        public UserControlWeekend()
        {
            InitializeComponent();
            lbweekend.ForeColor = WEEKEND_TEXT_COLOR;
        }

        private void UserControlWeekend_Load(object sender, EventArgs e)
        {

        }

        public void Weekends(int numWeekend) // метод отображения выходных дней в контейнере
        {
            lbweekend.Text = numWeekend.ToString();
        }

        private void UserControlWeekend_Paint(object sender, PaintEventArgs e) // градиент UserControlWeekend
        {
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.Black, Color.Black, 0, false);
            ColorBlend colorblend = new ColorBlend
            {
                Positions = new[] { 0f, 0.5f, 1f },
                Colors = new[] { Gradient1, Gradient2, Gradient3 }
            };
            brush.InterpolationColors = colorblend;
            brush.RotateTransform(60);
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
        }
    }
}
