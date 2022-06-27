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
    public partial class UserControlDays : UserControl
    {
        private readonly Color Gradient1 = Color.FromArgb(25, 246, 242, 242);
        private readonly Color Gradient2 = Color.FromArgb(25, 251, 247, 247);
        private readonly Color Gradient3 = Color.FromArgb(25, 255, 253, 252);

        public UserControlDays()
        {
            InitializeComponent();
        }

        private void UserControlDays_Load(object sender, EventArgs e)
        {

        }

        public void Days(int numDay) // метод отображения всех дней, кроме выходных, в контейнере
        {
            lbdays.Text = numDay.ToString();
        }

        private void UserControlDays_Paint(object sender, PaintEventArgs e) // градиент UserControlDays 
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
