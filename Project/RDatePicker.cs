using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public class RDatePicker : DateTimePicker
    {
        // Private Variable
        private Color skinColor = Color.MediumSlateBlue;
        private Color textColor = Color.White;
        private Color borderColor = Color.Black;
        private Color borderFocusColor = Color.HotPink;
        private int borderRadius = 0;
        private int borderSize = 0;
        private bool isFocused = false;

        private bool droppedDown = false;
        private Image calendarIcon = Properties.Resources.calendarWhite;
        private RectangleF iconButtonArea;
        private const int calendarIconWidth = 34;
        private const int arrowIconWidth = 17;

        // Public Properties
        public Color SkinColor
        {
            get { return skinColor; }
            set
            {
                skinColor = value;
                if (skinColor.GetBrightness() >= 0.8f)
                {
                    calendarIcon = Properties.Resources.calendarDark;
                }
                else
                {
                    calendarIcon = Properties.Resources.calendarWhite;
                    this.Invalidate();
                }
            }
        }

        public Color TextColor
        {
            get { return textColor; }
            set { textColor = value; }
        }

        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                if (value >= 0)
                {
                    borderRadius = value;
                    this.Invalidate();
                }
            }
        }

        public Color BorderColor
        {
            get { return borderColor; }
            set 
            { 
                borderColor = value;
                this.Invalidate();
            }
        }

        public int BorderSize
        {
            get { return borderSize; }
            set 
            { 
                borderSize = value;
                this.Invalidate();
            }
        }

        // Constructor
        public RDatePicker()
        {
            this.SetStyle(ControlStyles.UserPaint, true);
            this.MinimumSize = new Size(0, 35);
            this.Font = new Font(this.Font.Name, 9.5f);
        }


        // Overridden Methods
        protected override void OnDropDown(EventArgs e)
        {
            base.OnDropDown(e);
            droppedDown = true;
        }

        protected override void OnCloseUp(EventArgs e)
        {
            base.OnCloseUp(e);
            droppedDown = false;
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            base.OnKeyPress(e);
            e.Handled = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            using(Graphics graphics = this.CreateGraphics())
            using(Pen penBorder = new Pen(borderColor, borderSize))
            using(SolidBrush skinBrush = new SolidBrush(skinColor))
            using(SolidBrush openIconBrush = new SolidBrush(Color.FromArgb(50, 64, 64, 64)))
            using(SolidBrush textBrush = new SolidBrush(textColor))
            using(StringFormat textFormat = new StringFormat())
            {
                RectangleF clientArea = new RectangleF(0, 0, this.Width - 0.5f, this.Height - 0.5f);
                RectangleF iconArea = new RectangleF(clientArea.Width - calendarIconWidth, 0, calendarIconWidth, clientArea.Height);
                penBorder.Alignment = PenAlignment.Inset;
                textFormat.LineAlignment = StringAlignment.Center;

                graphics.FillRectangle(skinBrush, clientArea);
                graphics.DrawString("   " + this.Text, this.Font, textBrush, clientArea, textFormat);
                if(droppedDown == true) graphics.FillRectangle(openIconBrush, iconArea);
                if(borderSize >= 1) graphics.DrawRectangle(penBorder, clientArea.X, clientArea.Y, clientArea.Width, clientArea.Height);
                graphics.DrawImage(calendarIcon, this.Width - calendarIcon.Width - 9, (this.Height - calendarIcon.Height)/2);
            }

            Graphics graph = e.Graphics;
            if (borderRadius > 1)
            {
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;
                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(pathBorderSmooth);
                    if (borderRadius > 15) { SetTextBoxRoundedRegion(); }
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                    if (isFocused) penBorder.Color = borderFocusColor;
                    graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                    graph.DrawPath(penBorder, pathBorder);
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            int iconWidth = GetIconButtonWidth();
            iconButtonArea = new RectangleF(this.Width - iconWidth, 0, iconWidth, this.Height);
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if(iconButtonArea.Contains(e.Location))
            {
                this.Cursor = Cursors.Hand;
            }
            else
            {
                this.Cursor = Cursors.Default;
            }
        }

        // Private Methods
        private int GetIconButtonWidth()
        {
            int textWidth = TextRenderer.MeasureText(this.Text, this.Font).Width;
            if(textWidth <= this.Width)
            {
                return calendarIconWidth;
            }
            else
            {
                return arrowIconWidth;
            }
        }
        private GraphicsPath GetFigurePath(Rectangle rect, float radius)
        {
            GraphicsPath gPath = new GraphicsPath();
            float curveSize = radius * 2f;

            gPath.StartFigure();
            gPath.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            gPath.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            gPath.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            gPath.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            gPath.CloseFigure();

            return gPath;
        }

        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath pathTxt;
            pathTxt = GetFigurePath(this.ClientRectangle, borderSize * 2);
            this.Region = new Region(pathTxt);
        }
    }
}
