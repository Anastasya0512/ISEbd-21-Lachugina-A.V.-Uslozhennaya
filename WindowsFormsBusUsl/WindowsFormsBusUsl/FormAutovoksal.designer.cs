﻿namespace WindowsFormsBusUsl
{
    partial class FormAutovoksal
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
            this.pictureBoxAutovoksal = new System.Windows.Forms.PictureBox();
            this.buttonSetBus = new System.Windows.Forms.Button();
            this.buttonSetGarmBus = new System.Windows.Forms.Button();
            this.groupBoxTakingBus = new System.Windows.Forms.GroupBox();
            this.buttonTakeBus = new System.Windows.Forms.Button();
            this.maskedTextBoxNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.comboBoxNumberDoors = new System.Windows.Forms.ComboBox();
            this.comboBoxFormDoors = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxDigit = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonNumberOfEmpty = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAutovoksal)).BeginInit();
            this.groupBoxTakingBus.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxAutovoksal
            // 
            this.pictureBoxAutovoksal.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBoxAutovoksal.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAutovoksal.Name = "pictureBoxAutovoksal";
            this.pictureBoxAutovoksal.Size = new System.Drawing.Size(810, 601);
            this.pictureBoxAutovoksal.TabIndex = 0;
            this.pictureBoxAutovoksal.TabStop = false;
            // 
            // buttonSetBus
            // 
            this.buttonSetBus.Location = new System.Drawing.Point(894, 28);
            this.buttonSetBus.Name = "buttonSetBus";
            this.buttonSetBus.Size = new System.Drawing.Size(150, 51);
            this.buttonSetBus.TabIndex = 1;
            this.buttonSetBus.Text = "Припарковать автобус";
            this.buttonSetBus.UseVisualStyleBackColor = true;
            this.buttonSetBus.Click += new System.EventHandler(this.buttonSetBus_Click);
            // 
            // buttonSetGarmBus
            // 
            this.buttonSetGarmBus.Location = new System.Drawing.Point(893, 145);
            this.buttonSetGarmBus.Name = "buttonSetGarmBus";
            this.buttonSetGarmBus.Size = new System.Drawing.Size(150, 64);
            this.buttonSetGarmBus.TabIndex = 2;
            this.buttonSetGarmBus.Text = "Припарковать автобус с гармошкой";
            this.buttonSetGarmBus.UseVisualStyleBackColor = true;
            this.buttonSetGarmBus.Click += new System.EventHandler(this.buttonSetGarmBus_Click_1);
            // 
            // groupBoxTakingBus
            // 
            this.groupBoxTakingBus.Controls.Add(this.buttonTakeBus);
            this.groupBoxTakingBus.Controls.Add(this.maskedTextBoxNumber);
            this.groupBoxTakingBus.Controls.Add(this.labelPlace);
            this.groupBoxTakingBus.Location = new System.Drawing.Point(894, 441);
            this.groupBoxTakingBus.Name = "groupBoxTakingBus";
            this.groupBoxTakingBus.Size = new System.Drawing.Size(150, 109);
            this.groupBoxTakingBus.TabIndex = 3;
            this.groupBoxTakingBus.TabStop = false;
            this.groupBoxTakingBus.Text = "Забрать автобус";
            // 
            // buttonTakeBus
            // 
            this.buttonTakeBus.Location = new System.Drawing.Point(17, 64);
            this.buttonTakeBus.Name = "buttonTakeBus";
            this.buttonTakeBus.Size = new System.Drawing.Size(103, 30);
            this.buttonTakeBus.TabIndex = 2;
            this.buttonTakeBus.Text = "Забрать";
            this.buttonTakeBus.UseVisualStyleBackColor = true;
            this.buttonTakeBus.Click += new System.EventHandler(this.buttonTakeBus_Click_1);
            // 
            // maskedTextBoxNumber
            // 
            this.maskedTextBoxNumber.Location = new System.Drawing.Point(73, 36);
            this.maskedTextBoxNumber.Name = "maskedTextBoxNumber";
            this.maskedTextBoxNumber.Size = new System.Drawing.Size(47, 22);
            this.maskedTextBoxNumber.TabIndex = 1;
            // 
            // labelPlace
            // 
            this.labelPlace.AutoSize = true;
            this.labelPlace.Location = new System.Drawing.Point(14, 36);
            this.labelPlace.Name = "labelPlace";
            this.labelPlace.Size = new System.Drawing.Size(53, 17);
            this.labelPlace.TabIndex = 0;
            this.labelPlace.Text = "Место:";
            // 
            // comboBoxNumberDoors
            // 
            this.comboBoxNumberDoors.FormattingEnabled = true;
            this.comboBoxNumberDoors.Location = new System.Drawing.Point(894, 85);
            this.comboBoxNumberDoors.Name = "comboBoxNumberDoors";
            this.comboBoxNumberDoors.Size = new System.Drawing.Size(150, 24);
            this.comboBoxNumberDoors.TabIndex = 4;
            // 
            // comboBoxFormDoors
            // 
            this.comboBoxFormDoors.FormattingEnabled = true;
            this.comboBoxFormDoors.Location = new System.Drawing.Point(893, 115);
            this.comboBoxFormDoors.Name = "comboBoxFormDoors";
            this.comboBoxFormDoors.Size = new System.Drawing.Size(151, 24);
            this.comboBoxFormDoors.TabIndex = 5;
            // 
            // maskedTextBoxDigit
            // 
            this.maskedTextBoxDigit.Location = new System.Drawing.Point(914, 267);
            this.maskedTextBoxDigit.Name = "maskedTextBoxDigit";
            this.maskedTextBoxDigit.Size = new System.Drawing.Size(100, 22);
            this.maskedTextBoxDigit.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(844, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Попробуйте угадать количество";
            // 
            // buttonNumberOfEmpty
            // 
            this.buttonNumberOfEmpty.Location = new System.Drawing.Point(894, 325);
            this.buttonNumberOfEmpty.Name = "buttonNumberOfEmpty";
            this.buttonNumberOfEmpty.Size = new System.Drawing.Size(141, 51);
            this.buttonNumberOfEmpty.TabIndex = 8;
            this.buttonNumberOfEmpty.Text = "Количество пустых мест";
            this.buttonNumberOfEmpty.UseVisualStyleBackColor = true;
            this.buttonNumberOfEmpty.Click += new System.EventHandler(this.buttonNumberOfEmpty_Click);
            // 
            // FormAutovoksal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 601);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonNumberOfEmpty);
            this.Controls.Add(this.maskedTextBoxDigit);
            this.Controls.Add(this.comboBoxFormDoors);
            this.Controls.Add(this.comboBoxNumberDoors);
            this.Controls.Add(this.groupBoxTakingBus);
            this.Controls.Add(this.buttonSetGarmBus);
            this.Controls.Add(this.buttonSetBus);
            this.Controls.Add(this.pictureBoxAutovoksal);
            this.Name = "FormAutovoksal";
            this.Text = "Автовокзал";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAutovoksal)).EndInit();
            this.groupBoxTakingBus.ResumeLayout(false);
            this.groupBoxTakingBus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAutovoksal;
        private System.Windows.Forms.Button buttonSetBus;
        private System.Windows.Forms.Button buttonSetGarmBus;
        private System.Windows.Forms.GroupBox groupBoxTakingBus;
        private System.Windows.Forms.Button buttonTakeBus;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumber;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.ComboBox comboBoxNumberDoors;
        private System.Windows.Forms.ComboBox comboBoxFormDoors;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxDigit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonNumberOfEmpty;
    }
}