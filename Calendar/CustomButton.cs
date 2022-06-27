using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Calendar
{
    public class CustomButton : Button
    {
        private int _borderSize = 3;
        private int _borderRadius = 20;

        private bool _useGradient;
        private Color _firstFillColor = Color.FromArgb(10, 10, 10);
        private Color _secondFillColor = Color.FromArgb(100, 100, 100);
        private LinearGradientMode _gradientDirection = LinearGradientMode.ForwardDiagonal;

        private bool _useGradientBorder = true;
        private Color _firstBorderColor = Color.FromArgb(10, 10, 10);
        private Color _secondBorderColor = Color.FromArgb(100, 100, 100);
        private LinearGradientMode _gradientBorderDirection = LinearGradientMode.ForwardDiagonal;

        private TextPosition _textPosition = TextPosition.Center;

        private bool _isEntered;
        private bool _isClicked;

        public int BorderSize
        {
            get => _borderSize;
            set
            {
                _borderSize = value;
                Invalidate();
            }
        }

        public int BorderRadius
        {
            get => _borderRadius;
            set
            {
                _borderRadius = value;
                Invalidate();
            }
        }

        public bool UseGradient
        {
            get => _useGradient;
            set
            {
                _useGradient = value;
                Invalidate();
            }
        }

        public Color FillColorFirst
        {
            get => _firstFillColor;
            set
            {
                _firstFillColor = value;
                Invalidate();
            }
        }

        public Color FillColorSecond
        {
            get => _secondFillColor;
            set
            {
                _secondFillColor = value;
                Invalidate();
            }
        }

        public LinearGradientMode GradientDirection
        {
            get => _gradientDirection;
            set
            {
                _gradientDirection = value;
                Invalidate();
            }
        }

        public bool UseGradientBorder
        {
            get => _useGradientBorder;
            set
            {
                _useGradientBorder = value;
                Invalidate();
            }
        }

        public Color BorderColorFirst
        {
            get => _firstBorderColor;
            set
            {
                _firstBorderColor = value;
                Invalidate();
            }
        }

        public Color BorderColorSecond
        {
            get => _secondBorderColor;
            set
            {
                _secondBorderColor = value;
                Invalidate();
            }
        }

        public LinearGradientMode GradientBorderDirection
        {
            get => _gradientBorderDirection;
            set
            {
                _gradientBorderDirection = value;
                Invalidate();
            }
        }

        public new TextPosition TextAlign
        {
            get => _textPosition;
            set
            {
                _textPosition = value;
                Invalidate();
            }
        }

        public Color OnOverFirstFillColor { get; set; }
        public Color OnOverSecondFillColor { get; set; }
        public Color OnOverFirstBorderColor { get; set; }
        public Color OnOverSecondBorderColor { get; set; }
        public Color OnClickFirstFillColor { get; set; }
        public Color OnClickSecondFillColor { get; set; }
        public Color OnClickFirstBorderColor { get; set; }
        public Color OnClickSecondBorderColor { get; set; }

        public CustomButton()
        {
            FlatStyle = FlatStyle.Flat;
            BackColor = Color.Transparent;
            FlatAppearance.BorderSize = 0;
            ForeColor = Color.WhiteSmoke;
            Font = new Font(FontFamily.GenericSansSerif, 14, FontStyle.Regular);
            Size = new Size(180, 60);
            Resize += CustomButton_Resize;
            SetStyle(ControlStyles.Opaque | ControlStyles.SupportsTransparentBackColor 
                | ControlStyles.UserPaint | ControlStyles.ResizeRedraw, true);
        }

        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            var path = new GraphicsPath();
            float diameter = radius * 2f;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, diameter, diameter, 180, 90);
            path.AddArc(rect.Right - diameter, rect.Y, diameter, diameter, 270, 90);
            path.AddArc(rect.Right - diameter, rect.Bottom - diameter, diameter, diameter, 0, 90);
            path.AddArc(rect.X, rect.Bottom - diameter, diameter, diameter, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // base.OnPaint(e);
            InvokePaintBackground(this, e);
            var graphics = e.Graphics;
            graphics.SmoothingMode = SmoothingMode.AntiAlias;

            int borderSize = _borderSize > 1 ? _borderSize : 2;
            Color firstFillColor, secondFillColor, firstBorderColor, secondBorderColor;

            if (_isEntered)
            {
                if (_isClicked)
                {
                    firstFillColor = OnClickFirstFillColor;
                    secondFillColor = OnClickSecondFillColor;
                    firstBorderColor = OnClickFirstBorderColor;
                    secondBorderColor = OnClickSecondBorderColor;
                }
                else
                {
                    firstFillColor = OnOverFirstFillColor;
                    secondFillColor = OnOverSecondFillColor;
                    firstBorderColor = OnOverFirstBorderColor;
                    secondBorderColor = OnOverSecondBorderColor;
                }
            }
            else
            {
                firstFillColor = _firstFillColor;
                secondFillColor = _secondFillColor;
                firstBorderColor = _firstBorderColor;
                secondBorderColor = _secondBorderColor;
            }

            using (var gradientBrush = new LinearGradientBrush(ClientRectangle, firstFillColor, secondFillColor, _gradientDirection))
            using (var borderGradientBrush = new LinearGradientBrush(ClientRectangle, firstBorderColor, secondBorderColor, _gradientBorderDirection))
            using (var penBorder = _useGradientBorder ? new Pen(borderGradientBrush, borderSize) : new Pen(new SolidBrush(firstBorderColor), borderSize))
            {
                if (_borderRadius > 2)
                {
                    using (var borderPath = GetFigurePath(Rectangle.Inflate(ClientRectangle, -2, -2), _borderRadius))
                    using (var path = GetFigurePath(Rectangle.Inflate(ClientRectangle, -1, -1), _borderRadius))
                    {
                        if (_useGradient)
                        {
                            graphics.FillPath(gradientBrush, path);
                        }
                        else
                        {
                            graphics.FillPath(new SolidBrush(firstFillColor), path);
                        }
                        
                        if (_borderSize >= 1)
                        {
                            penBorder.Alignment = PenAlignment.Center;
                            graphics.DrawPath(penBorder, borderPath);
                        }
                    }
                }
                else
                {
                    graphics.SmoothingMode = SmoothingMode.HighQuality;

                    if (_useGradient)
                    {
                        graphics.FillRectangle(gradientBrush, ClientRectangle);
                    }
                    else
                    {
                        graphics.FillRectangle(new SolidBrush(firstFillColor), ClientRectangle);
                    }

                    if (_borderSize > 0)
                    {
                        penBorder.Alignment = PenAlignment.Center;
                        graphics.DrawRectangle(penBorder, 0, 0, Width - 1, Height - 1);
                    }
                }
                
                var textSize = graphics.MeasureString(Text, Font);
                float positionX = 5f + _borderSize;
                float positionY = (Height - textSize.Height) / 2;

                switch (_textPosition)
                {
                    case TextPosition.Left:
                        positionX = Width - textSize.Width - _borderSize;
                        break;
                    case TextPosition.Center:
                        positionX = (Width - textSize.Width) / 2;
                        break;
                    case TextPosition.Right:
                        positionX = 5f + _borderSize;
                        break;
                }
                graphics.DrawString(Text, Font, new SolidBrush(ForeColor), positionX, positionY);
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            _isEntered = true;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            _isEntered = false;
        }

        protected override void OnMouseDown(MouseEventArgs mevent)
        {
            base.OnMouseDown(mevent);
            _isClicked = true;
            Invalidate();
        }

        protected override void OnMouseUp(MouseEventArgs mevent)
        {
            base.OnMouseUp(mevent);
            _isClicked = false;
            Invalidate();
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            Parent.BackColorChanged += Parent_BackColorChanged;
        }

        private void Parent_BackColorChanged(object sender, EventArgs e) => Invalidate();

        private void CustomButton_Resize(object sender, EventArgs e)
        {
            if (_borderRadius > Height)
            {
                _borderRadius = Height;
            }
        }
    }
}
