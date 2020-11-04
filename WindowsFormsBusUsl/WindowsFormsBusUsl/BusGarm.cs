using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsBusUsl
{
    /// <summary>
    /// Класс отрисовки автобуса
    /// </summary>
    public class BusGarm : Bus
    {
        public Color DopColor { private set; get; }

        public bool Garmoshka { private set; get; }

        public bool ThirdOs { private set; get; }

        IDopElement DoorForm;

        public BusGarm(int maxSpeed, float weight, Color mainColor, Color dopColor, bool garmoshka, bool thirdOs, int numberDoors, int formDoors) : base(maxSpeed, weight, mainColor, 194, 68)
        {
            DopColor = dopColor;
            Garmoshka = garmoshka;
            ThirdOs = thirdOs;
            DoorForm = GetForm(formDoors, numberDoors);
        }

        public override void DrawTransport(Graphics g)
        {
            Brush brDop = new SolidBrush(DopColor);
            Pen os = new Pen(Color.Black, 4);
            Pen luke = new Pen(Color.Black);
            Brush white = new SolidBrush(Color.White);
            Brush red = new SolidBrush(Color.Red);
            Brush okno = new SolidBrush(Color.DarkGray);

            base.DrawTransport(g);

            //отрисуем гармошку
            if (Garmoshka)
            {
                //отрисуем кузов автобуса
                g.FillRectangle(red, _startPosX + 136, _startPosY + 5, 80, 53);

                //правый люк
                g.DrawRectangle(luke, _startPosX + 150, _startPosY, 29, 6);
                g.FillRectangle(white, _startPosX + 151, _startPosY + 1, 28, 5);

                //окно автобуса
                g.DrawRectangle(luke, _startPosX + 137, _startPosY + 14, 78, 29);
                g.FillRectangle(okno, _startPosX + 138, _startPosY + 15, 77, 28);

                //гармошка
                g.FillRectangle(brDop, _startPosX + 118, _startPosY + 8, 19, 47);
            }
            //отрисуем третью ось колес
            if (ThirdOs)
            {
                g.DrawEllipse(os, _startPosX + 148, _startPosY + 50, 17, 17);
                g.FillEllipse(white, _startPosX + 150, _startPosY + 52, 13, 13);
            }
            DoorForm.DrawAdditions(g, DopColor, _startPosX, _startPosY);
        }
        private IDopElement GetForm(int formDoors, int numberDoors)
        {
            switch (formDoors)
            {
                case 0:
                    return new RectangleForm(numberDoors, DopColor);
                case 1:
                    return new EllipseForm(numberDoors, DopColor);
                case 2:
                    return new TriangleForm(numberDoors, DopColor);
            }
            return null;
        }
    }
}