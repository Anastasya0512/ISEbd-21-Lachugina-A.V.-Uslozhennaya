namespace WindowsFormsBusUsl
{
    partial class FormBusConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxParametrs = new System.Windows.Forms.GroupBox();
            this.checkBoxOs = new System.Windows.Forms.CheckBox();
            this.checkBoxGarm = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelWeight = new System.Windows.Forms.Label();
            this.labelMaxSpeed = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelBusGarm = new System.Windows.Forms.Label();
            this.labelBus = new System.Windows.Forms.Label();
            this.panelBus = new System.Windows.Forms.Panel();
            this.pictureBoxBusDraw = new System.Windows.Forms.PictureBox();
            this.groupBoxColors = new System.Windows.Forms.GroupBox();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelDarkViolet = new System.Windows.Forms.Panel();
            this.panelPink = new System.Windows.Forms.Panel();
            this.panelLightBlue = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelDarkOrange = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.panelRed = new System.Windows.Forms.Panel();
            this.buttonFalse = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBoxTypeDoors = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelFiveDoors = new System.Windows.Forms.Label();
            this.labelFourDoors = new System.Windows.Forms.Label();
            this.labelThreeDoors = new System.Windows.Forms.Label();
            this.labelTriangleForm = new System.Windows.Forms.Label();
            this.labelRectangleForm = new System.Windows.Forms.Label();
            this.labelEllipseForm = new System.Windows.Forms.Label();
            this.labelChangeDoors = new System.Windows.Forms.Label();
            this.groupBoxParametrs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panelBus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBusDraw)).BeginInit();
            this.groupBoxColors.SuspendLayout();
            this.groupBoxTypeDoors.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxParametrs
            // 
            this.groupBoxParametrs.Controls.Add(this.checkBoxOs);
            this.groupBoxParametrs.Controls.Add(this.checkBoxGarm);
            this.groupBoxParametrs.Controls.Add(this.numericUpDownWeight);
            this.groupBoxParametrs.Controls.Add(this.numericUpDownSpeed);
            this.groupBoxParametrs.Controls.Add(this.labelWeight);
            this.groupBoxParametrs.Controls.Add(this.labelMaxSpeed);
            this.groupBoxParametrs.Location = new System.Drawing.Point(42, 218);
            this.groupBoxParametrs.Name = "groupBoxParametrs";
            this.groupBoxParametrs.Size = new System.Drawing.Size(359, 169);
            this.groupBoxParametrs.TabIndex = 0;
            this.groupBoxParametrs.TabStop = false;
            this.groupBoxParametrs.Text = "Параметры";
            // 
            // checkBoxOs
            // 
            this.checkBoxOs.AutoSize = true;
            this.checkBoxOs.Checked = true;
            this.checkBoxOs.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOs.Location = new System.Drawing.Point(200, 91);
            this.checkBoxOs.Name = "checkBoxOs";
            this.checkBoxOs.Size = new System.Drawing.Size(145, 21);
            this.checkBoxOs.TabIndex = 5;
            this.checkBoxOs.Text = "Третья ось колес";
            this.checkBoxOs.UseVisualStyleBackColor = true;
            // 
            // checkBoxGarm
            // 
            this.checkBoxGarm.AutoSize = true;
            this.checkBoxGarm.Checked = true;
            this.checkBoxGarm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxGarm.Location = new System.Drawing.Point(200, 53);
            this.checkBoxGarm.Name = "checkBoxGarm";
            this.checkBoxGarm.Size = new System.Drawing.Size(97, 21);
            this.checkBoxGarm.TabIndex = 4;
            this.checkBoxGarm.Text = "Гармошка";
            this.checkBoxGarm.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(75, 111);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(66, 22);
            this.numericUpDownWeight.TabIndex = 3;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.Location = new System.Drawing.Point(75, 53);
            this.numericUpDownSpeed.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownSpeed.Name = "numericUpDownSpeed";
            this.numericUpDownSpeed.Size = new System.Drawing.Size(66, 22);
            this.numericUpDownSpeed.TabIndex = 2;
            this.numericUpDownSpeed.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // labelWeight
            // 
            this.labelWeight.AutoSize = true;
            this.labelWeight.Location = new System.Drawing.Point(18, 91);
            this.labelWeight.Name = "labelWeight";
            this.labelWeight.Size = new System.Drawing.Size(100, 17);
            this.labelWeight.TabIndex = 1;
            this.labelWeight.Text = "Вес автобуса:";
            // 
            // labelMaxSpeed
            // 
            this.labelMaxSpeed.AutoSize = true;
            this.labelMaxSpeed.Location = new System.Drawing.Point(18, 33);
            this.labelMaxSpeed.Name = "labelMaxSpeed";
            this.labelMaxSpeed.Size = new System.Drawing.Size(112, 17);
            this.labelMaxSpeed.TabIndex = 0;
            this.labelMaxSpeed.Text = "Макс. скорость:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelBusGarm);
            this.groupBox2.Controls.Add(this.labelBus);
            this.groupBox2.Location = new System.Drawing.Point(12, 30);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(224, 159);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Тип автобуса";
            // 
            // labelBusGarm
            // 
            this.labelBusGarm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBusGarm.Location = new System.Drawing.Point(6, 96);
            this.labelBusGarm.Name = "labelBusGarm";
            this.labelBusGarm.Size = new System.Drawing.Size(172, 45);
            this.labelBusGarm.TabIndex = 1;
            this.labelBusGarm.Text = "Автобус с гармошкой";
            this.labelBusGarm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelBusGarm_MouseDown);
            // 
            // labelBus
            // 
            this.labelBus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelBus.Location = new System.Drawing.Point(6, 36);
            this.labelBus.Name = "labelBus";
            this.labelBus.Size = new System.Drawing.Size(172, 44);
            this.labelBus.TabIndex = 0;
            this.labelBus.Text = "Автобус";
            this.labelBus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelBus_MouseDown);
            // 
            // panelBus
            // 
            this.panelBus.AllowDrop = true;
            this.panelBus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBus.Controls.Add(this.pictureBoxBusDraw);
            this.panelBus.Location = new System.Drawing.Point(242, 44);
            this.panelBus.Name = "panelBus";
            this.panelBus.Size = new System.Drawing.Size(329, 151);
            this.panelBus.TabIndex = 3;
            this.panelBus.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelBus_DragDrop);
            this.panelBus.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelBus_DragEnter);
            // 
            // pictureBoxBusDraw
            // 
            this.pictureBoxBusDraw.Location = new System.Drawing.Point(3, 7);
            this.pictureBoxBusDraw.Name = "pictureBoxBusDraw";
            this.pictureBoxBusDraw.Size = new System.Drawing.Size(323, 141);
            this.pictureBoxBusDraw.TabIndex = 1;
            this.pictureBoxBusDraw.TabStop = false;
            // 
            // groupBoxColors
            // 
            this.groupBoxColors.Controls.Add(this.panelBlue);
            this.groupBoxColors.Controls.Add(this.panelDarkViolet);
            this.groupBoxColors.Controls.Add(this.panelPink);
            this.groupBoxColors.Controls.Add(this.panelLightBlue);
            this.groupBoxColors.Controls.Add(this.panelGreen);
            this.groupBoxColors.Controls.Add(this.panelYellow);
            this.groupBoxColors.Controls.Add(this.panelDarkOrange);
            this.groupBoxColors.Controls.Add(this.labelDopColor);
            this.groupBoxColors.Controls.Add(this.labelMainColor);
            this.groupBoxColors.Controls.Add(this.panelRed);
            this.groupBoxColors.Location = new System.Drawing.Point(593, 44);
            this.groupBoxColors.Name = "groupBoxColors";
            this.groupBoxColors.Size = new System.Drawing.Size(300, 189);
            this.groupBoxColors.TabIndex = 10;
            this.groupBoxColors.TabStop = false;
            this.groupBoxColors.Text = "Цвета";
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.Location = new System.Drawing.Point(29, 145);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(39, 38);
            this.panelBlue.TabIndex = 1;
            // 
            // panelDarkViolet
            // 
            this.panelDarkViolet.BackColor = System.Drawing.Color.DarkViolet;
            this.panelDarkViolet.Location = new System.Drawing.Point(94, 145);
            this.panelDarkViolet.Name = "panelDarkViolet";
            this.panelDarkViolet.Size = new System.Drawing.Size(39, 38);
            this.panelDarkViolet.TabIndex = 1;
            // 
            // panelPink
            // 
            this.panelPink.BackColor = System.Drawing.Color.Fuchsia;
            this.panelPink.Location = new System.Drawing.Point(155, 145);
            this.panelPink.Name = "panelPink";
            this.panelPink.Size = new System.Drawing.Size(39, 38);
            this.panelPink.TabIndex = 1;
            // 
            // panelLightBlue
            // 
            this.panelLightBlue.BackColor = System.Drawing.Color.Aqua;
            this.panelLightBlue.Location = new System.Drawing.Point(225, 145);
            this.panelLightBlue.Name = "panelLightBlue";
            this.panelLightBlue.Size = new System.Drawing.Size(39, 38);
            this.panelLightBlue.TabIndex = 1;
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Lime;
            this.panelGreen.Location = new System.Drawing.Point(225, 92);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(39, 38);
            this.panelGreen.TabIndex = 1;
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.Location = new System.Drawing.Point(155, 92);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(39, 38);
            this.panelYellow.TabIndex = 1;
            // 
            // panelDarkOrange
            // 
            this.panelDarkOrange.BackColor = System.Drawing.Color.DarkOrange;
            this.panelDarkOrange.Location = new System.Drawing.Point(94, 92);
            this.panelDarkOrange.Name = "panelDarkOrange";
            this.panelDarkOrange.Size = new System.Drawing.Size(39, 38);
            this.panelDarkOrange.TabIndex = 1;
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(155, 30);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(139, 41);
            this.labelDopColor.TabIndex = 2;
            this.labelDopColor.Text = "Дополнительный цвет";
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDop_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMain_DragEnter);
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(17, 30);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(132, 41);
            this.labelMainColor.TabIndex = 1;
            this.labelMainColor.Text = "Основной цвет";
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelMain_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMain_DragEnter);
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.Location = new System.Drawing.Point(29, 92);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(39, 38);
            this.panelRed.TabIndex = 0;
            this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelColor_MouseDown);
            // 
            // buttonFalse
            // 
            this.buttonFalse.Location = new System.Drawing.Point(734, 316);
            this.buttonFalse.Name = "buttonFalse";
            this.buttonFalse.Size = new System.Drawing.Size(103, 35);
            this.buttonFalse.TabIndex = 13;
            this.buttonFalse.Text = "Отмена";
            this.buttonFalse.UseVisualStyleBackColor = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(734, 263);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(103, 35);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // groupBoxTypeDoors
            // 
            this.groupBoxTypeDoors.Controls.Add(this.label2);
            this.groupBoxTypeDoors.Controls.Add(this.label1);
            this.groupBoxTypeDoors.Controls.Add(this.labelFiveDoors);
            this.groupBoxTypeDoors.Controls.Add(this.labelFourDoors);
            this.groupBoxTypeDoors.Controls.Add(this.labelThreeDoors);
            this.groupBoxTypeDoors.Controls.Add(this.labelTriangleForm);
            this.groupBoxTypeDoors.Controls.Add(this.labelRectangleForm);
            this.groupBoxTypeDoors.Controls.Add(this.labelEllipseForm);
            this.groupBoxTypeDoors.Controls.Add(this.labelChangeDoors);
            this.groupBoxTypeDoors.Location = new System.Drawing.Point(417, 239);
            this.groupBoxTypeDoors.Name = "groupBoxTypeDoors";
            this.groupBoxTypeDoors.Size = new System.Drawing.Size(309, 190);
            this.groupBoxTypeDoors.TabIndex = 14;
            this.groupBoxTypeDoors.TabStop = false;
            this.groupBoxTypeDoors.Text = "Тип дверей";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Форма";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 16;
            this.label1.Text = "Количество";
            // 
            // labelFiveDoors
            // 
            this.labelFiveDoors.AllowDrop = true;
            this.labelFiveDoors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFiveDoors.Location = new System.Drawing.Point(232, 70);
            this.labelFiveDoors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFiveDoors.Name = "labelFiveDoors";
            this.labelFiveDoors.Size = new System.Drawing.Size(31, 28);
            this.labelFiveDoors.TabIndex = 15;
            this.labelFiveDoors.Text = "5";
            this.labelFiveDoors.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelNumberDoors_MouseDown);
            // 
            // labelFourDoors
            // 
            this.labelFourDoors.AllowDrop = true;
            this.labelFourDoors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelFourDoors.Location = new System.Drawing.Point(191, 69);
            this.labelFourDoors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFourDoors.Name = "labelFourDoors";
            this.labelFourDoors.Size = new System.Drawing.Size(33, 28);
            this.labelFourDoors.TabIndex = 14;
            this.labelFourDoors.Text = "4";
            this.labelFourDoors.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelNumberDoors_MouseDown);
            // 
            // labelThreeDoors
            // 
            this.labelThreeDoors.AllowDrop = true;
            this.labelThreeDoors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelThreeDoors.Location = new System.Drawing.Point(153, 69);
            this.labelThreeDoors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelThreeDoors.Name = "labelThreeDoors";
            this.labelThreeDoors.Size = new System.Drawing.Size(30, 28);
            this.labelThreeDoors.TabIndex = 13;
            this.labelThreeDoors.Text = "3";
            this.labelThreeDoors.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelNumberDoors_MouseDown);
            // 
            // labelTriangleForm
            // 
            this.labelTriangleForm.AllowDrop = true;
            this.labelTriangleForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTriangleForm.Image = global::WindowsFormsBusUsl.Properties.Resources.треугольник;
            this.labelTriangleForm.Location = new System.Drawing.Point(142, 116);
            this.labelTriangleForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTriangleForm.Name = "labelTriangleForm";
            this.labelTriangleForm.Size = new System.Drawing.Size(41, 44);
            this.labelTriangleForm.TabIndex = 12;
            this.labelTriangleForm.Text = "0";
            this.labelTriangleForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTriangleForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelDoorForm_MouseDown);
            // 
            // labelRectangleForm
            // 
            this.labelRectangleForm.AllowDrop = true;
            this.labelRectangleForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelRectangleForm.Image = global::WindowsFormsBusUsl.Properties.Resources.квадрат;
            this.labelRectangleForm.Location = new System.Drawing.Point(244, 116);
            this.labelRectangleForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRectangleForm.Name = "labelRectangleForm";
            this.labelRectangleForm.Size = new System.Drawing.Size(44, 44);
            this.labelRectangleForm.TabIndex = 11;
            this.labelRectangleForm.Text = "2";
            this.labelRectangleForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelRectangleForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelDoorForm_MouseDown);
            // 
            // labelEllipseForm
            // 
            this.labelEllipseForm.AllowDrop = true;
            this.labelEllipseForm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelEllipseForm.Image = global::WindowsFormsBusUsl.Properties.Resources.овал;
            this.labelEllipseForm.Location = new System.Drawing.Point(191, 116);
            this.labelEllipseForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEllipseForm.Name = "labelEllipseForm";
            this.labelEllipseForm.Size = new System.Drawing.Size(44, 44);
            this.labelEllipseForm.TabIndex = 10;
            this.labelEllipseForm.Text = "1";
            this.labelEllipseForm.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelEllipseForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelDoorForm_MouseDown);
            // 
            // labelChangeDoors
            // 
            this.labelChangeDoors.AllowDrop = true;
            this.labelChangeDoors.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelChangeDoors.Location = new System.Drawing.Point(91, 24);
            this.labelChangeDoors.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelChangeDoors.Name = "labelChangeDoors";
            this.labelChangeDoors.Size = new System.Drawing.Size(92, 29);
            this.labelChangeDoors.TabIndex = 9;
            this.labelChangeDoors.Text = "Изменить";
            this.labelChangeDoors.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelChangeDoors_DragDrop);
            this.labelChangeDoors.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelChangeDoors_DragEnter);
            // 
            // FormBusConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 450);
            this.Controls.Add(this.groupBoxTypeDoors);
            this.Controls.Add(this.buttonFalse);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxColors);
            this.Controls.Add(this.panelBus);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBoxParametrs);
            this.Name = "FormBusConfig";
            this.Text = "FormBusConfig";
            this.groupBoxParametrs.ResumeLayout(false);
            this.groupBoxParametrs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.panelBus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBusDraw)).EndInit();
            this.groupBoxColors.ResumeLayout(false);
            this.groupBoxTypeDoors.ResumeLayout(false);
            this.groupBoxTypeDoors.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxParametrs;
        private System.Windows.Forms.CheckBox checkBoxOs;
        private System.Windows.Forms.CheckBox checkBoxGarm;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeed;
        private System.Windows.Forms.Label labelWeight;
        private System.Windows.Forms.Label labelMaxSpeed;
        private System.Windows.Forms.PictureBox pictureBoxBusDraw;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelBusGarm;
        private System.Windows.Forms.Label labelBus;
        private System.Windows.Forms.Panel panelBus;
        private System.Windows.Forms.GroupBox groupBoxColors;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelDarkViolet;
        private System.Windows.Forms.Panel panelPink;
        private System.Windows.Forms.Panel panelLightBlue;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelDarkOrange;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Button buttonFalse;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupBoxTypeDoors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelFiveDoors;
        private System.Windows.Forms.Label labelFourDoors;
        private System.Windows.Forms.Label labelThreeDoors;
        private System.Windows.Forms.Label labelTriangleForm;
        private System.Windows.Forms.Label labelRectangleForm;
        private System.Windows.Forms.Label labelEllipseForm;
        private System.Windows.Forms.Label labelChangeDoors;
        private System.Windows.Forms.Label label2;
    }
}