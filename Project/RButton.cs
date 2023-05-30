using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Project
{
    public class RButton : Button
    {
        // Private Variable
        private int borderSize = 0;
        private int borderRadius = 0;
        private Color borderColor = Color.Black;

        // Constructor
        public RButton() {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.Size = new Size(150, 40);
            this.Resize += new EventHandler(Button_Resize);
        }

        // Private Methods
        private void Button_Resize(object sender, EventArgs e)
        {
            if(borderRadius > this.Height)
            {
                BorderRadius = this.Height;
            }
        }

        private void Container_BackColorChanged(object sender, EventArgs e)
        {
            if (this.DesignMode)
            {
                this.Invalidate();
            }
        }

        // Public Properties
        public int BorderSize
        {
            get 
            { 
                return borderSize; 
            } 
            set 
            { 
                borderSize = value; 
                this.Invalidate(); 
            }
        }

        public int BorderRadius
        {
            get
            {
                return borderRadius;
            }
            set
            {
                if(value <= this.Height )
                {
                    borderRadius = value;
                }
                else
                {
                    borderRadius = this.Height;
                }
                this.Invalidate();
            }
        }

        public Color BorderColor
        {
            get 
            { 
                return borderColor;
            }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        // Private Methods
        private GraphicsPath GetGraphicsPath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }

        // Protected Methods
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            RectangleF rectSurface = new RectangleF(0,0, this.Width,this.Height);
            RectangleF rectBorder = new RectangleF(1, 1, this.Width - 0.8f, this.Height - 1);

            if(borderRadius > 2)
            {
                using(GraphicsPath pathSurface = GetGraphicsPath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetGraphicsPath(rectBorder, borderRadius - 1f))
                using (Pen penSurface = new Pen(this.Parent.BackColor, 2))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    this.Region = new Region(pathSurface);
                    e.Graphics.DrawPath(penSurface, pathSurface);

                    if(borderSize >= 1)
                    {
                        e.Graphics.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else
            {
                this.Region = new Region(rectSurface);
                if(borderSize >= 1)
                {
                    using(Pen penBorder = new Pen(borderColor, borderSize))
                    {
                        penBorder.Alignment = PenAlignment.Inset;
                        e.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                    }
                }
            }
        }

        protected override void OnHandleCreated(EventArgs e)
        {
            base.OnHandleCreated(e);
            this.Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
        }
    }
}
