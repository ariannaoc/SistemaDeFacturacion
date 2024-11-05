using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2_SistemaDeFacturacion.BotonesCustomizados
{
    public class RoundedPanel : Panel
    {
        private int borderSize = 0;
        private int borderRadius = 20;
        private Color borderColor = Color.PaleVioletRed;

        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                Invalidate();
            }
        }

        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                Invalidate();
            }
        }

        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                Invalidate();
            }
        }

        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);

            Graphics g = pevent.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            g.InterpolationMode = InterpolationMode.HighQualityBicubic;
            g.PixelOffsetMode = PixelOffsetMode.HighQuality;

            Rectangle rectClient = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectClient, -borderSize, -borderSize);

            if (borderRadius > 2)
            {
                using (GraphicsPath path = GetFigurePath(rectClient, borderRadius))
                {
                    this.Region = new Region(path);
                    g.FillPath(new SolidBrush(this.BackColor), path);

                    if (borderSize >= 1)
                    {
                        using (Pen pen = new Pen(borderColor, borderSize))
                        {
                            pen.Alignment = PenAlignment.Inset;
                            g.DrawPath(pen, path);
                        }
                    }
                }
            }
            else
            {
                // Handle non-rounded corners (e.g., simple rectangle)
                g.FillRectangle(new SolidBrush(this.BackColor), rectClient);
                if (borderSize >= 1)
                {
                    using (Pen pen = new Pen(borderColor, borderSize))
                    {
                        pen.Alignment = PenAlignment.Inset;
                        g.DrawRectangle(pen, rectClient);
                    }
                }
            }
        }
    }
}
