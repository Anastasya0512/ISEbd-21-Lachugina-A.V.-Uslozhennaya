﻿using System;
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

        public LinkedList<EasyBus> buses = new LinkedList<EasyBus>();
        public FormAutovoksal()
        {
            InitializeComponent();
            autovoksalCollection = new AutovoksalCollection(pictureBoxAutovoksal.Width, pictureBoxAutovoksal.Height);
            Draw();       
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
        private void Draw()
        {
            if (listBoxAutovoksal.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxAutovoksal.Width, pictureBoxAutovoksal.Height);
                Graphics gr = Graphics.FromImage(bmp);
                autovoksalCollection[listBoxAutovoksal.SelectedItem.ToString()].Draw(gr);
                pictureBoxAutovoksal.Image = bmp;
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

        private void buttonDelAutovoksal_Click(object sender, EventArgs e)
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

        private void buttonTakeBus_Click_1(object sender, EventArgs e)
        {
            if (listBoxAutovoksal.SelectedIndex > -1 && maskedTextBoxNumber.Text != "")
            {
                var bus = autovoksalCollection[listBoxAutovoksal.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBoxNumber.Text);
                if (bus != null)
                {
                    buses.AddFirst(bus);
                }
                Draw();
            }
        }

        private void buttonSeeBus_Click(object sender, EventArgs e)
        {
            if (buses.Count > 0)
            {
                FormBus form = new FormBus();
                form.SetBus(buses.First.Value);
                buses.RemoveFirst();
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Автобусов не осталось");
            }
        }

        private void listBoxAutovoksal_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Draw();
        }
        private void AddBus(EasyBus bus)
        {
            if (bus != null && listBoxAutovoksal.SelectedIndex > -1)
            {
                if ((autovoksalCollection[listBoxAutovoksal.SelectedItem.ToString()]) + bus)
                {
                    Draw();
                }
                else
                {
                    MessageBox.Show("Автобус не удалось поставить");
                }
            }
        }
        private void buttonAddBus_Click(object sender, EventArgs e)
        {
            var formBusConfig = new FormBusConfig();
            formBusConfig.AddEvent(AddBus);
            formBusConfig.Show();
        }
    }
}
