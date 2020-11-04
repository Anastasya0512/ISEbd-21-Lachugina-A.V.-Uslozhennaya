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
        public int Digit { set => doorEnum = (DoorsEnum)value; }
        private DoorsEnum doorEnum;
        public Color DopColor { private set; get; }
        public TriangleForm(int digit, Color dopColor)
        {
            Digit = digit;
            DopColor = dopColor;
        }

        public void DrawAdditions(Graphics g, Color DopColor, float x, float y)
        {
            switch (doorEnum)
            {
                case DoorsEnum.Three:
                    DrawDoorThree(g, x, y);
                    break;
                case DoorsEnum.Four:
                    DrawDoorFour(g, x, y);
                    break;
                case DoorsEnum.Five:
                    DrawDoorFive(g, x, y);
                    break;
            }
        }
        private void DrawDoorThree(Graphics g, float x, float y)
        {
            Brush brush = new SolidBrush(DopColor);
            Pen pen = new Pen(Color.Red);
            PointF s1 = new PointF(x + 73, y + 10);
            PointF s2 = new PointF(x + 60, y + 50);
            PointF s3 = new PointF(x + 85, y + 50);
            PointF[] points = { s1, s2, s3 };
            g.FillPolygon(brush, points);
            g.DrawPolygon(pen, points);
            PointF h1 = new PointF(x + 97, y + 10);
            PointF h2 = new PointF(x + 84, y + 50);
            PointF h3 = new PointF(x + 109, y + 50);
            PointF[] pointh = { h1, h2, h3 };
            g.FillPolygon(brush, pointh);
            g.DrawPolygon(pen, pointh);
            PointF g1 = new PointF(x + 150, y + 10);
            PointF g2 = new PointF(x + 137, y + 50);
            PointF g3 = new PointF(x + 162, y + 50);
            PointF[] pointg = { g1, g2, g3 };
            g.FillPolygon(brush, pointg);
            g.DrawPolygon(pen, pointg);
        }
        private void DrawDoorFour(Graphics g, float x, float y)
        {
            Brush brush = new SolidBrush(DopColor);
            Pen pen = new Pen(Color.Red);
            DrawDoorThree(g, x, y);
            PointF g1 = new PointF(x + 175, y + 10);
            PointF g2 = new PointF(x + 162, y + 50);
            PointF g3 = new PointF(x + 188, y + 50);
            PointF[] pointg = { g1, g2, g3 };
            g.FillPolygon(brush, pointg);
            g.DrawPolygon(pen, pointg);
        }

        private void DrawDoorFive(Graphics g, float x, float y)
        {
            Brush brush = new SolidBrush(DopColor);
            Pen pen = new Pen(Color.Red);
            DrawDoorFour(g, x, y);
            PointF g1 = new PointF(x + 203, y + 10);
            PointF g2 = new PointF(x + 190, y + 50);
            PointF g3 = new PointF(x + 214, y + 50);
            PointF[] pointg = { g1, g2, g3 };
            g.FillPolygon(brush, pointg);
            g.DrawPolygon(pen, pointg);
        }
    }
}
