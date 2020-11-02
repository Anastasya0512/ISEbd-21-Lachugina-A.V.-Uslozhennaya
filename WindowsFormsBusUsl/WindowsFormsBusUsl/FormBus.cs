using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsBusUsl;

namespace WindowsFormsBusUsl
{
    public partial class FormBus : Form
    {
        private Bus bus;

        /// <summary>
        /// Конструктор
        /// </summary>
        public FormBus()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод отрисовки машины
        /// </summary>
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxBus.Width, pictureBoxBus.Height);
            Graphics gr = Graphics.FromImage(bmp);
            bus.DrawTransport(gr);
            pictureBoxBus.Image = bmp;
        }
        /// <summary>
        /// Обработка нажатия кнопки "Создать автобус"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCreateBus_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            bus = new Bus(rnd.Next(150, 200), rnd.Next(5000, 10000), Color.Red);
            bus.SetPosition(rnd.Next(10, 150), rnd.Next(10, 150), pictureBoxBus.Width, pictureBoxBus.Height);
            Draw();
        }
        /// <summary>
        /// Обработка нажатия кнопок управления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    bus.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    bus.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    bus.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    bus.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }

        private void buttonCreateBusGarm_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            int doorForm = (checkBoxTriangle.Checked && !checkBoxRectangle.Checked && !checkBoxEllipse.Checked) ? 1 :
                (!checkBoxTriangle.Checked && checkBoxRectangle.Checked && !checkBoxEllipse.Checked) ? 2 :
                (!checkBoxTriangle.Checked && !checkBoxRectangle.Checked && checkBoxEllipse.Checked ? 3 : 0);

            bus = new BusGarm(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Red, Color.Black, true, true, doorForm);
            bus.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), pictureBoxBus.Width, pictureBoxBus.Height);
            Draw();
        }
    }
}