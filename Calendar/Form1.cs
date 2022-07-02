using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Windows.Forms;

namespace Calendar
{
    public partial class Form1 : Form
    {
        int month, year;

        private readonly Color WEEKEND_TEXT_COLOR = Color.FromArgb(176, 0, 0);
        private readonly Color Gradient1 = Color.FromArgb(84, 160, 255);
        private readonly Color Gradient2 = Color.FromArgb(255, 107, 107);

        public Form1()
        {
            InitializeComponent();
            lbSaturday.ForeColor = WEEKEND_TEXT_COLOR;
            lbSunday.ForeColor = WEEKEND_TEXT_COLOR;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayDays();
        }

        private void DisplayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month; // определение месяца в данный момент времени
            year = now.Year; // определение года в данный момент времени

            DateTime weekend = new DateTime(year, month, 1); // экземпляр структуры для вывода выходных дней

            DisplayDate(); // отображение месяца и года

            DateTime startOfTheMonth = new DateTime(year, month, 1); // экземпляр структуры для определения начала месяца
            startOfTheMonth = startOfTheMonth.AddDays(-1); // -1 день, т.к. неделя начинается с понедельника,
                                                          // а не с воскресенья, как в структуре DateTime

            int days = DateTime.DaysInMonth(year, month); // возвращает число дней в указанном месяце указанного года
            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1; // определение дня недели

            for (int i = 1; i < dayOfTheWeek; i++) // вывод контейнеров на форму
            {
                UserControlBlank ucblank = new UserControlBlank();
                dayContainer.Controls.Add(ucblank);
                ucblank.Invalidate();
            }

            for (int i = 1; i <= days; i++) // отображение чисел, соответствующих дате
            {
                // сначала проверяется, является ли день выходным, и в этом случае в контейнер выводится номер дня
                if (weekend.DayOfWeek == DayOfWeek.Saturday || weekend.DayOfWeek == DayOfWeek.Sunday)
                {
                    UserControlWeekend ucweekend = new UserControlWeekend();
                    ucweekend.Weekends(i);
                    dayContainer.Controls.Add(ucweekend);
                    ucweekend.Invalidate();
                }
                // после проверяется, является ли день будним, и в этом случае в контейнер выводится номер дня
                else
                { 
                    UserControlDays ucdays = new UserControlDays();
                    ucdays.Days(i);
                    dayContainer.Controls.Add(ucdays);
                    ucdays.Invalidate();
                }
                weekend = weekend.AddDays(1);
            }
        }

        private string DisplayDate() // метод отображения месяца и года на форме
        {
            string monthname = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            lbDate.Text = monthname + " " + year;
            Refresh();
            return lbDate.Text;
        }

        private void btnPrev_Click(object sender, EventArgs e) // обработка события при нажатии на кнопку "Предыдущий"
        {
            dayContainer.Controls.Clear(); // очистка контейнеров dayContainer

            if (month != 1)
            {
                month--;
            }
            else
            {
                month = 12;
                year--;
            }

            DateTime weekend = new DateTime(year, month, 1);

            DisplayDate();

            DateTime startOfTheMonth = new DateTime(year, month, 1);
            startOfTheMonth = startOfTheMonth.AddDays(-1);

            int days = DateTime.DaysInMonth(year, month);
            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;
            
            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                dayContainer.Controls.Add(ucblank);
                ucblank.Invalidate();
            }

            for (int i = 1; i <= days; i++)
            {
                if (weekend.DayOfWeek == DayOfWeek.Saturday || weekend.DayOfWeek == DayOfWeek.Sunday)
                {
                    UserControlWeekend ucweekend = new UserControlWeekend();
                    ucweekend.Weekends(i);
                    dayContainer.Controls.Add(ucweekend);
                    ucweekend.Invalidate();
                }
                else
                {
                    UserControlDays ucdays = new UserControlDays();
                    ucdays.Days(i);
                    dayContainer.Controls.Add(ucdays);
                    ucdays.Invalidate();
                }
                weekend = weekend.AddDays(1);
            }
        }

        private void btnNext_Click(object sender, EventArgs e) // обработка события при нажатии на кнопку "Следующий"
        {
            dayContainer.Controls.Clear(); // очистка контейнеров dayContainer

            if (month != 12)
            {
                month++;
            }
            else
            {
                month = 1;
                year++;
            }

            DateTime weekend = new DateTime(year, month, 1);

            DisplayDate();

            DateTime startOfTheMonth = new DateTime(year, month, 1);
            startOfTheMonth = startOfTheMonth.AddDays(-1);

            int days = DateTime.DaysInMonth(year, month);
            int dayOfTheWeek = Convert.ToInt32(startOfTheMonth.DayOfWeek.ToString("d")) + 1;

            for (int i = 1; i < dayOfTheWeek; i++)
            {
                UserControlBlank ucblank = new UserControlBlank();
                dayContainer.Controls.Add(ucblank);
                ucblank.Invalidate();
            }

            for (int i = 1; i <= days; i++)
            {
                if (weekend.DayOfWeek == DayOfWeek.Saturday || weekend.DayOfWeek == DayOfWeek.Sunday)
                {
                    UserControlWeekend ucweekend = new UserControlWeekend();
                    ucweekend.Weekends(i);
                    dayContainer.Controls.Add(ucweekend);
                    ucweekend.Invalidate();
                }
                else
                {
                    UserControlDays ucdays = new UserControlDays();
                    ucdays.Days(i);
                    dayContainer.Controls.Add(ucdays);
                    ucdays.Invalidate();
                }
                weekend = weekend.AddDays(1);
            }
        }

        private void btnExit_Click(object sender, EventArgs e) => Application.Exit(); // обработка события при нажатии на кнопку "X"

        private void Form1_Paint(object sender, PaintEventArgs e) // градиент на форме
        {
            LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, Color.Black, Color.Black, 0, false);
            ColorBlend colorblend = new ColorBlend
            {
                Positions = new[] { 0f, 1f },
                Colors = new[] { Gradient1, Gradient2 }
            };
            brush.InterpolationColors = colorblend;
            brush.RotateTransform(57.5f);
            e.Graphics.FillRectangle(brush, this.ClientRectangle);
        }

        protected override CreateParams CreateParams // включение двойной буферизации
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
    }
}
