using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsBus
{
    public class Door
    {  
        private DoorsNumber number;
        public int numberDoors
        {
            set
            {
                number = (DoorsNumber)value;
            }
        }
        public void DrawDoors(Graphics g, float _startPosX, float _startPosY, Color color)
        {
            float x = _startPosX;
            Pen pen = new Pen(Color.Red);
            Brush br = new SolidBrush(color);
            for (int i=0; i<=(int) number-1; i++)
            {
            //отрисовка двери
            g.DrawRectangle(pen, x + 55, _startPosY + 12, 15, 36);
            g.FillRectangle(br, x + 56, _startPosY + 13, 14, 35);
                if (i == 1) x += 50;
                else x += 23;
            }
        }
    }
}
