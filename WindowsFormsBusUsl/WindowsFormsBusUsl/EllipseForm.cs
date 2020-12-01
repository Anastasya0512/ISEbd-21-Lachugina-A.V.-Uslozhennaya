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
        private DoorsEnum numberDoors;
        public Color DopColor { private set; get; }
        public EllipseForm(int numberDoors, Color dopColor)
        {
            Count = numberDoors;
            DopColor = dopColor;
        }

        public int Count
        {
            set
            {
                if (value == 3)
                {
                    numberDoors = DoorsEnum.Three;
                }
                if (value == 4)
                {
                    numberDoors = DoorsEnum.Four;
                }
                if (value == 5)
                {
                    numberDoors = DoorsEnum.Five;
                }
            }
        }

        public void DrawAdditions(Graphics g, Color DopColor, float x, float y)
        {
            switch (numberDoors)
            {
                case DoorsEnum.Three:
                    DrawDoorThree(g, DopColor, x, y);
                    break;
                case DoorsEnum.Four:
                    DrawDoorFour(g, DopColor, x, y);
                    break;
                case DoorsEnum.Five:
                    DrawDoorFive(g, DopColor, x, y);
                    break;
            }
        }

        private void DrawDoorThree(Graphics g, Color DopColor, float x, float y)
        {
            Brush brush = new SolidBrush(DopColor);
            Pen pen = new Pen(Color.Red);
            g.FillEllipse(brush, x + 60, y + 10, 15, 40);
            g.DrawEllipse(pen, x + 60, y + 10, 15, 40);
            g.FillEllipse(brush, x + 83, y + 10, 15, 40);
            g.DrawEllipse(pen, x + 83, y + 10, 15, 40);
            g.FillEllipse(brush, x + 145, y + 10, 15, 40);
            g.DrawEllipse(pen, x + 145, y + 10, 15, 40);
        }
        private void DrawDoorFour(Graphics g, Color DopColor, float x, float y)
        {
            DrawDoorThree(g, DopColor, x, y);
            Brush brush = new SolidBrush(DopColor);
            Pen pen = new Pen(Color.Red);
            DrawDoorThree(g, DopColor, x, y);
            g.FillEllipse(brush, x + 168, y + 10, 15, 40);
            g.DrawEllipse(pen, x + 168, y + 10, 15, 40);
        }

        private void DrawDoorFive(Graphics g, Color DopColor, float x, float y)
        {
            Brush brush = new SolidBrush(DopColor);
            Pen pen = new Pen(Color.Red);
            DrawDoorFour(g, DopColor, x, y);
            g.FillEllipse(brush, x + 191, y + 10, 15, 40);
            g.DrawEllipse(pen, x + 191, y + 10, 15, 40);
        }
    }
}
