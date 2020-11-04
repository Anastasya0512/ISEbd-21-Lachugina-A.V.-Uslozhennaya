namespace WindowsFormsBusUsl
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
            this.buttonLastTaken = new System.Windows.Forms.Button();
            this.buttonTakeBus = new System.Windows.Forms.Button();
            this.maskedTextBoxNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.labelAutovoksal = new System.Windows.Forms.Label();
            this.textBoxAutovoksalName = new System.Windows.Forms.TextBox();
            this.buttonAddAutovoksal = new System.Windows.Forms.Button();
            this.listBoxAutovoksal = new System.Windows.Forms.ListBox();
            this.buttonDeleteAutovoksal = new System.Windows.Forms.Button();
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
            this.buttonSetBus.Location = new System.Drawing.Point(895, 268);
            this.buttonSetBus.Name = "buttonSetBus";
            this.buttonSetBus.Size = new System.Drawing.Size(150, 51);
            this.buttonSetBus.TabIndex = 1;
            this.buttonSetBus.Text = "Припарковать автобус";
            this.buttonSetBus.UseVisualStyleBackColor = true;
            this.buttonSetBus.Click += new System.EventHandler(this.buttonSetBus_Click);
            // 
            // buttonSetGarmBus
            // 
            this.buttonSetGarmBus.Location = new System.Drawing.Point(893, 325);
            this.buttonSetGarmBus.Name = "buttonSetGarmBus";
            this.buttonSetGarmBus.Size = new System.Drawing.Size(150, 64);
            this.buttonSetGarmBus.TabIndex = 2;
            this.buttonSetGarmBus.Text = "Припарковать автобус с гармошкой";
            this.buttonSetGarmBus.UseVisualStyleBackColor = true;
            this.buttonSetGarmBus.Click += new System.EventHandler(this.buttonSetGarmBus_Click_1);
            // 
            // groupBoxTakingBus
            // 
            this.groupBoxTakingBus.Controls.Add(this.buttonLastTaken);
            this.groupBoxTakingBus.Controls.Add(this.buttonTakeBus);
            this.groupBoxTakingBus.Controls.Add(this.maskedTextBoxNumber);
            this.groupBoxTakingBus.Controls.Add(this.labelPlace);
            this.groupBoxTakingBus.Location = new System.Drawing.Point(861, 407);
            this.groupBoxTakingBus.Name = "groupBoxTakingBus";
            this.groupBoxTakingBus.Size = new System.Drawing.Size(205, 146);
            this.groupBoxTakingBus.TabIndex = 3;
            this.groupBoxTakingBus.TabStop = false;
            this.groupBoxTakingBus.Text = "Забрать автобус";
            // 
            // buttonLastTaken
            // 
            this.buttonLastTaken.Location = new System.Drawing.Point(6, 100);
            this.buttonLastTaken.Name = "buttonLastTaken";
            this.buttonLastTaken.Size = new System.Drawing.Size(176, 30);
            this.buttonLastTaken.TabIndex = 3;
            this.buttonLastTaken.Text = "Последний забранный";
            this.buttonLastTaken.UseVisualStyleBackColor = true;
            this.buttonLastTaken.Click += new System.EventHandler(this.buttonLastTaken_Click);
            // 
            // buttonTakeBus
            // 
            this.buttonTakeBus.Location = new System.Drawing.Point(6, 64);
            this.buttonTakeBus.Name = "buttonTakeBus";
            this.buttonTakeBus.Size = new System.Drawing.Size(176, 30);
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
            // labelAutovoksal
            // 
            this.labelAutovoksal.AutoSize = true;
            this.labelAutovoksal.Location = new System.Drawing.Point(929, 9);
            this.labelAutovoksal.Name = "labelAutovoksal";
            this.labelAutovoksal.Size = new System.Drawing.Size(84, 17);
            this.labelAutovoksal.TabIndex = 10;
            this.labelAutovoksal.Text = "Автовокзал";
            // 
            // textBoxAutovoksalName
            // 
            this.textBoxAutovoksalName.Location = new System.Drawing.Point(894, 29);
            this.textBoxAutovoksalName.Name = "textBoxAutovoksalName";
            this.textBoxAutovoksalName.Size = new System.Drawing.Size(149, 22);
            this.textBoxAutovoksalName.TabIndex = 11;
            // 
            // buttonAddAutovoksal
            // 
            this.buttonAddAutovoksal.Location = new System.Drawing.Point(895, 57);
            this.buttonAddAutovoksal.Name = "buttonAddAutovoksal";
            this.buttonAddAutovoksal.Size = new System.Drawing.Size(150, 42);
            this.buttonAddAutovoksal.TabIndex = 12;
            this.buttonAddAutovoksal.Text = "Добавить автовокзал";
            this.buttonAddAutovoksal.UseVisualStyleBackColor = true;
            this.buttonAddAutovoksal.Click += new System.EventHandler(this.buttonAddAutovoksal_Click);
            // 
            // listBoxAutovoksal
            // 
            this.listBoxAutovoksal.FormattingEnabled = true;
            this.listBoxAutovoksal.ItemHeight = 16;
            this.listBoxAutovoksal.Location = new System.Drawing.Point(895, 105);
            this.listBoxAutovoksal.Name = "listBoxAutovoksal";
            this.listBoxAutovoksal.Size = new System.Drawing.Size(150, 100);
            this.listBoxAutovoksal.TabIndex = 13;
            // 
            // buttonDeleteAutovoksal
            // 
            this.buttonDeleteAutovoksal.Location = new System.Drawing.Point(894, 211);
            this.buttonDeleteAutovoksal.Name = "buttonDeleteAutovoksal";
            this.buttonDeleteAutovoksal.Size = new System.Drawing.Size(151, 42);
            this.buttonDeleteAutovoksal.TabIndex = 14;
            this.buttonDeleteAutovoksal.Text = "Удалить автовокзал";
            this.buttonDeleteAutovoksal.UseVisualStyleBackColor = true;
            this.buttonDeleteAutovoksal.Click += new System.EventHandler(this.buttonDeleteAutovoksal_Click);
            // 
            // FormAutovoksal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 601);
            this.Controls.Add(this.buttonDeleteAutovoksal);
            this.Controls.Add(this.listBoxAutovoksal);
            this.Controls.Add(this.buttonAddAutovoksal);
            this.Controls.Add(this.textBoxAutovoksalName);
            this.Controls.Add(this.labelAutovoksal);
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
        private System.Windows.Forms.Label labelAutovoksal;
        private System.Windows.Forms.TextBox textBoxAutovoksalName;
        private System.Windows.Forms.Button buttonAddAutovoksal;
        private System.Windows.Forms.ListBox listBoxAutovoksal;
        private System.Windows.Forms.Button buttonDeleteAutovoksal;
        private System.Windows.Forms.Button buttonLastTaken;
    }
}