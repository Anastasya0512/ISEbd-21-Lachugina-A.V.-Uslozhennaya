using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsBusUsl
{
    class EllipseForm : IDopElement
    {
        private ElementsEnum doorForm;

        public int SetNumberOfElements { set => doorForm = (ElementsEnum)value; }

        public Color DopColor { private set; get; }

        public EllipseForm(int digit, Color dopColor)
        {
            SetNumberOfElements = digit;
            DopColor = dopColor;
        }

        public void DrawElement(Graphics g, Color dopColor, float x, float y)
        {
            Brush brush = new SolidBrush(dopColor);
            Pen pen = new Pen(Color.Red);
            g.FillEllipse(brush, x + 60, y + 10, 25, 45);
            g.DrawEllipse(pen, x + 60, y + 10, 25, 45);
            g.FillEllipse(brush, x + 165, y + 10, 25, 45);
            g.DrawEllipse(pen, x + 165, y + 10, 25, 45);
        }
    }
}
