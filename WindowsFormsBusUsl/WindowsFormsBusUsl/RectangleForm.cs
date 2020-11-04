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
        public int Digit { set => doorEnum = (DoorsEnum)value; }
        private DoorsEnum doorEnum;
        public Color DopColor { private set; get; }
        public RectangleForm(int digit, Color dopColor)
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
            g.FillRectangle(brush, x + 60, y + 10, 15, 40);
            g.DrawRectangle(pen, x + 60, y + 10, 15, 40);
            g.FillRectangle(brush, x + 83, y + 10, 15, 40);
            g.DrawRectangle(pen, x + 83, y + 10, 15, 40);
            g.FillRectangle(brush, x + 145, y + 10, 15, 40);
            g.DrawRectangle(pen, x + 145, y + 10, 15, 40);
        }
        private void DrawDoorFour(Graphics g, float x, float y)
        {
            Brush brush = new SolidBrush(DopColor);
            Pen pen = new Pen(Color.Red);
            DrawDoorThree(g, x, y);
            g.FillRectangle(brush, x + 168, y + 10, 15, 40);
            g.DrawRectangle(pen, x + 168, y + 10, 15, 40);
        }

        private void DrawDoorFive(Graphics g, float x, float y)
        {
            Brush brush = new SolidBrush(DopColor);
            Pen pen = new Pen(Color.Red);
            DrawDoorFour(g, x, y);
            g.FillRectangle(brush, x + 191, y + 10, 15, 40);
            g.DrawRectangle(pen, x + 191, y + 10, 15, 40);
        }
    }
}
