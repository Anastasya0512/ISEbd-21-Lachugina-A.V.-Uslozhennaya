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
        private readonly AutovoksalCollection autovoksalCollection;

        private readonly Autovoksal<EasyBus, EllipseForm> autovoksal;

        public LinkedList<EasyBus> plains = new LinkedList<EasyBus>();
        public FormAutovoksal()
        {
            InitializeComponent();
            autovoksalCollection = new AutovoksalCollection(pictureBoxAutovoksal.Width, pictureBoxAutovoksal.Height);
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
        private void ReloadLevels()
        {
            int index = listBoxAutovoksal.SelectedIndex;
            listBoxAutovoksal.Items.Clear();
            for (int i = 0; i < autovoksalCollection.Keys.Count; i++)
            {
                listBoxAutovoksal.Items.Add(autovoksalCollection.Keys[i]);
            }
            if (listBoxAutovoksal.Items.Count > 0 && (index == -1 || index >= listBoxAutovoksal.Items.Count))
            {
                listBoxAutovoksal.SelectedIndex = 0;
            }
            else if (listBoxAutovoksal.Items.Count > 0 && index > -1 && index < listBoxAutovoksal.Items.Count)
            {
                listBoxAutovoksal.SelectedIndex = index;
            }
        }
        private void buttonAddAutovoksal_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxAutovoksalName.Text))
            {
                MessageBox.Show("Введите название парковки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            autovoksalCollection.AddAutovoksal(textBoxAutovoksalName.Text);
            ReloadLevels();
        }

        private void buttonDeleteAutovoksal_Click(object sender, EventArgs e)
        {
            if (listBoxAutovoksal.SelectedIndex > -1)
            {
                if (MessageBox.Show($"Удалить автовокзал {listBoxAutovoksal.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    autovoksalCollection.DelAutovoksal(listBoxAutovoksal.SelectedItem.ToString());
                    ReloadLevels();
                    Draw();
                }
            }
        }

        private void buttonLastTaken_Click(object sender, EventArgs e)
        {
            if (plains.Count > 0)
            {
                FormAirplan form = new FormAirplan();
                form.SetAircraft(plains.First.Value);
                plains.RemoveFirst();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Самолётов не осталось");
            }
        }
    }
}
