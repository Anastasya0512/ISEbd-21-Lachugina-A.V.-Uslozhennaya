using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsBusUsl
{
    class RectangleForm : IDopElement
    {
        private DoorsEnum numberDoors;
        public Color DopColor { private set; get; }
        public RectangleForm(int numberDoors, Color dopColor)
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
            g.FillRectangle(brush, x + 60, y + 10, 15, 40);
            g.DrawRectangle(pen, x + 60, y + 10, 15, 40);
            g.FillRectangle(brush, x + 83, y + 10, 15, 40);
            g.DrawRectangle(pen, x + 83, y + 10, 15, 40);
            g.FillRectangle(brush, x + 145, y + 10, 15, 40);
            g.DrawRectangle(pen, x + 145, y + 10, 15, 40);
        }
        private void DrawDoorFour(Graphics g, Color DopColor, float x, float y)
        {
            Brush brush = new SolidBrush(DopColor);
            Pen pen = new Pen(Color.Red);
            DrawDoorThree(g, DopColor, x, y);
            g.FillRectangle(brush, x + 168, y + 10, 15, 40);
            g.DrawRectangle(pen, x + 168, y + 10, 15, 40);
        }

        private void DrawDoorFive(Graphics g, Color DopColor, float x, float y)
        {
            Brush brush = new SolidBrush(DopColor);
            Pen pen = new Pen(Color.Red);
            DrawDoorFour(g, DopColor, x, y);
            g.FillRectangle(brush, x + 191, y + 10, 15, 40);
            g.DrawRectangle(pen, x + 191, y + 10, 15, 40);
        }
    }
}
