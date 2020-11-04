using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsBusUsl
{
    public partial class FormAutovoksal : Form
    {
        private readonly Autovoksal<EasyBus, EllipseForm> autovoksal;
        public FormAutovoksal()
        {
            InitializeComponent();
            autovoksal = new Autovoksal<EasyBus, EllipseForm>(pictureBoxAutovoksal.Width, pictureBoxAutovoksal.Height);
            Draw();
            comboBoxNumberDoors.Items.AddRange(new string[] { "3 двери", "4 двери", "5 дверей" });
            comboBoxFormDoors.Items.AddRange(new string[] { "Прямоугольные", "Овальные", "Треугольные" });
            comboBoxNumberDoors.SelectedIndex = 0;
            comboBoxFormDoors.SelectedIndex = 0;
        }

        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBoxAutovoksal.Width, pictureBoxAutovoksal.Height);
            Graphics gr = Graphics.FromImage(bmp);
            autovoksal.Draw(gr);
            pictureBoxAutovoksal.Image = bmp;
        }

        private void buttonSetBus_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var bus = new Bus(100, 1000, dialog.Color);
                if (autovoksal + bus)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Парковка переполнена");
                }
            }
        }

        private void buttonSetGarmBus_Click_1(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorDialog dialogDop = new ColorDialog();
                if (dialogDop.ShowDialog() == DialogResult.OK)
                {
                    var bus = new BusGarm(100, 100, dialog.Color, dialogDop.Color, true, true, (comboBoxNumberDoors.SelectedIndex + 3), comboBoxFormDoors.SelectedIndex);
                    if (autovoksal + bus)
                    {
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Автовокзал переполнен");
                    }
                }
            }
        }

        private void buttonTakeBus_Click_1(object sender, EventArgs e)
        {
            if (maskedTextBoxNumber.Text != "")
            {
                var bus = autovoksal - Convert.ToInt32(maskedTextBoxNumber.Text);
                if (bus != null)
                {
                    FormBus form = new FormBus();
                    form.SetBus(bus);
                    form.ShowDialog();
                }
                Draw();
            }
        }

        private void buttonNumberOfBus_Click_1(object sender, EventArgs e)
        {
            if (maskedTextBoxDigit.Text != "")
            {
                int index = Convert.ToInt32(maskedTextBoxDigit.Text);
                if (autovoksal == index)
                {
                    MessageBox.Show("Вы угадали количество транспорта на парковке");
                }
                else
                {
                    MessageBox.Show("Вы не угадали количество транспорта на парковке");
                }
            }
        }

        private void buttonNumberOfEmpty_Click(object sender, EventArgs e)
        {
            if (maskedTextBoxDigit.Text != "")
            {
                int index = Convert.ToInt32(maskedTextBoxDigit.Text);
                if (autovoksal != index)
                {
                    MessageBox.Show("Вы угадали количество пустых мест на парковке");
                }
                else
                {
                    MessageBox.Show("Вы не угадали количество пустых мест на парковке");
                }
            }
        }
    }
}
