using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsBusUsl
{
    class TriangleForm : IDopElement
    {
        private ElementsEnum doorForm;

        public int SetNumberOfElements { set => doorForm = (ElementsEnum)value; }

        public Color DopColor { private set; get; }

        public TriangleForm(int digit, Color dopColor)
        {
            SetNumberOfElements = digit;
            DopColor = dopColor;
        }

        public void DrawElement(Graphics g, Color dopColor, float x, float y)
        {
            Brush brush = new SolidBrush(dopColor);
            Pen pen = new Pen(Color.Red);
            PointF s1 = new PointF(x + 73, y + 10);
            PointF s2 = new PointF(x + 60, y + 50);
            PointF s3 = new PointF(x + 85, y + 50);
            PointF[] points = { s1, s2, s3 };
            g.FillPolygon(brush, points);
            g.DrawPolygon(pen, points);
            PointF h1 = new PointF(x + 178, y + 10);
            PointF h2 = new PointF(x + 165, y + 50);
            PointF h3 = new PointF(x + 190, y + 50);
            PointF[] pointh = { h1, h2, h3 };
            g.FillPolygon(brush, pointh);
            g.DrawPolygon(pen, pointh);
        }
    }
}
