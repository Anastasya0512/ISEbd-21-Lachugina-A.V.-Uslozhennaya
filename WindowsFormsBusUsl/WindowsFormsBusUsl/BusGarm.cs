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

        public int NumberDoors { private set; get; }

        public string DoorForm { private set; get; }

        IDopElement Doors;

        public BusGarm(int maxSpeed, float weight, Color mainColor, Color dopColor, bool garmoshka, bool thirdOs, int numberDoors, string formDoors) : base(maxSpeed, weight, mainColor, 194, 68)
        {
            DopColor = dopColor;
            Garmoshka = garmoshka;
            ThirdOs = thirdOs;
            DoorForm = formDoors;

            if (DoorForm == "EllipseForm")
            {
                Doors = new EllipseForm(numberDoors, DopColor);

            }
            else if (DoorForm == "RectangleForm")
            {
                Doors = new RectangleForm(numberDoors, DopColor);
            }
            else
            {
                Doors = new TriangleForm(numberDoors, DopColor);
            }
        }
        public BusGarm(string info) : base(info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 8)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
                DopColor = Color.FromName(strs[3]);
                Garmoshka = Convert.ToBoolean(strs[4]);
                ThirdOs = Convert.ToBoolean(strs[5]);
                NumberDoors = Convert.ToInt32(strs[6]);
                DoorForm = strs[7];
                if (DoorForm == "EllipseForm")
                {
                    Doors = new EllipseForm(NumberDoors, DopColor);

                }
                else if (DoorForm == "RectangleForm")
                {
                    Doors = new RectangleForm(NumberDoors, DopColor);
                }
                else
                {
                    Doors = new TriangleForm(NumberDoors, DopColor);
                }
            }
        }
        public void SetDoors(IDopElement door)
        {
            Doors = door;
            DoorForm = Doors.GetType().Name;
        }
        public void SetDoorsCount(int portholeCount)
        {
            NumberDoors = portholeCount;
        }

        public override void DrawTransport(Graphics g)
        {
            Brush brDop = new SolidBrush(DopColor);
            Pen os = new Pen(Color.Black, 4);
            Pen luke = new Pen(Color.Black);
            Brush white = new SolidBrush(Color.White);
            Brush red = new SolidBrush(MainColor);
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

            if (Doors != null)
            {
                Doors.DrawAdditions(g, DopColor, _startPosX, _startPosY);
            }
        }

        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
        public override string ToString()
        {
            return $"{base.ToString()}{separator}{DopColor.Name}{separator}{Garmoshka}{separator}{ThirdOs}{separator}{NumberDoors}{separator}{DoorForm}";
        }
    }
}