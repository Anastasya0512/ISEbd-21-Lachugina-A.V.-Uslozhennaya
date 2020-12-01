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
    public partial class FormBusConfig : Form
    {
        EasyBus bus = null;
        private event Action<EasyBus> AddBus;
        public FormBusConfig()
        {
            InitializeComponent();
            this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            this.panelDarkViolet.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            this.panelPink.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            this.panelLightBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            this.panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            this.panelDarkOrange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            buttonFalse.Click += (object sender, EventArgs e) => { Close(); };
        }
        private void DrawBus()
        {
            if (bus != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxBusDraw.Width, pictureBoxBusDraw.Height);
                Graphics gr = Graphics.FromImage(bmp);
                bus.SetPosition(5, 15, pictureBoxBusDraw.Width, pictureBoxBusDraw.Height);
                bus.DrawTransport(gr);
                pictureBoxBusDraw.Image = bmp;
            }
        }

        /// <param name="ev"></param>
        public void AddEvent(Action<EasyBus> ev)
        {
            if (AddBus == null)
            {
                AddBus = new Action<EasyBus>(ev);
            }
            else
            {
                AddBus += ev;
            }
        }
        private void labelBus_MouseDown(object sender, MouseEventArgs e)
        {
            labelBus.DoDragDrop(labelBus.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelBusGarm_MouseDown(object sender, MouseEventArgs e)
        {
            labelBusGarm.DoDragDrop(labelBusGarm.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelBus_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Автобус":
                    bus = new Bus((int)numericUpDownSpeed.Value, (int)numericUpDownWeight.Value, Color.White);
                    break;
                case "Автобус с гармошкой":
                    bus = new BusGarm((int)numericUpDownSpeed.Value, (int)numericUpDownWeight.Value, Color.White, Color.Black, checkBoxGarm.Checked, checkBoxOs.Checked, 5, "RectangleForm");
                    break;
            }
            DrawBus();
        }

        private void panelBus_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            Color color = (sender as Panel).BackColor;
            (sender as Panel).DoDragDrop(color, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelMain_DragDrop(object sender, DragEventArgs e)
        {
            bus.SetMainColor((Color)e.Data.GetData(typeof(Color)));
            DrawBus();
        }

        private void labelMain_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelDop_DragDrop(object sender, DragEventArgs e)
        {
            if (bus is BusGarm)
            {
                (bus as BusGarm).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                DrawBus();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddBus?.Invoke(bus);
            Close();
        }

        private void labelChangeDoors_DragDrop(object sender, DragEventArgs e)
        {
            if (bus is BusGarm b)
            {
                if (e.Data.GetData(typeof(EllipseForm)) != null)
                {
                    b.SetDoors((EllipseForm)e.Data.GetData(typeof(EllipseForm)));
                }
                else if (e.Data.GetData(typeof(TriangleForm)) != null)
                {
                    b.SetDoors((TriangleForm)e.Data.GetData(typeof(TriangleForm)));
                }
                else if (e.Data.GetData(typeof(RectangleForm)) != null)
                {
                    b.SetDoors((RectangleForm)e.Data.GetData(typeof(RectangleForm)));
                }
                DrawBus();
            }
        }

        private void labelChangeDoors_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(EllipseForm)) || e.Data.GetDataPresent(typeof(RectangleForm)) || e.Data.GetDataPresent(typeof(TriangleForm)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelNumberDoors_MouseDown(object sender, MouseEventArgs e)
        {
            if (bus is BusGarm b)
            {
                IDopElement door = null;
                int numberDoor = Convert.ToInt32(((Label)sender).Text);
                switch (b.DoorForm)
                {
                    case "EllipseForm":
                        door = new EllipseForm(numberDoor, b.DopColor);
                        break;
                    case "RectangleForm":
                        door = new RectangleForm(numberDoor, b.DopColor);
                        break;
                    case "TriangleForm":
                        door = new TriangleForm(numberDoor, b.DopColor);
                        break;
                }
                if (door != null)
                {
                    ((Label)sender).DoDragDrop(door, DragDropEffects.Move | DragDropEffects.Copy);
                    b.SetDoorsCount(numberDoor);
                }
            }
        }

            private void labelDoorForm_MouseDown(object sender, MouseEventArgs e)
            {
                IDopElement DoorForm = null;
                if (bus is BusGarm b)
                {
                    switch (((Label)sender).Text)
                    {
                        case "0":
                            DoorForm = new TriangleForm(b.NumberDoors, b.DopColor);
                            break;
                        case "1":
                            DoorForm = new EllipseForm(b.NumberDoors, b.DopColor);
                            break;
                        case "2":
                            DoorForm = new RectangleForm(b.NumberDoors, b.DopColor);
                            break;
                    }
                    if (DoorForm != null)
                    {
                        ((Label)sender).DoDragDrop(DoorForm, DragDropEffects.Move | DragDropEffects.Copy);
                    }
                }
            }
        }
    }

