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
            this.buttonSeeFirst = new System.Windows.Forms.Button();
            this.buttonSeeLast = new System.Windows.Forms.Button();
            this.buttonTakeBus = new System.Windows.Forms.Button();
            this.maskedTextBoxNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.labelAuotovoksal = new System.Windows.Forms.Label();
            this.textBoxAutovoksalName = new System.Windows.Forms.TextBox();
            this.buttonAddAutovoksal = new System.Windows.Forms.Button();
            this.listBoxAutovoksal = new System.Windows.Forms.ListBox();
            this.buttonDelAutovoksal = new System.Windows.Forms.Button();
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
            this.buttonSetBus.Location = new System.Drawing.Point(877, 289);
            this.buttonSetBus.Name = "buttonSetBus";
            this.buttonSetBus.Size = new System.Drawing.Size(150, 51);
            this.buttonSetBus.TabIndex = 1;
            this.buttonSetBus.Text = "Припарковать автобус";
            this.buttonSetBus.UseVisualStyleBackColor = true;
            this.buttonSetBus.Click += new System.EventHandler(this.buttonSetBus_Click);
            // 
            // buttonSetGarmBus
            // 
            this.buttonSetGarmBus.Location = new System.Drawing.Point(877, 346);
            this.buttonSetGarmBus.Name = "buttonSetGarmBus";
            this.buttonSetGarmBus.Size = new System.Drawing.Size(150, 64);
            this.buttonSetGarmBus.TabIndex = 2;
            this.buttonSetGarmBus.Text = "Припарковать автобус с гармошкой";
            this.buttonSetGarmBus.UseVisualStyleBackColor = true;
            this.buttonSetGarmBus.Click += new System.EventHandler(this.buttonSetGarmBus_Click_1);
            // 
            // groupBoxTakingBus
            // 
            this.groupBoxTakingBus.Controls.Add(this.buttonSeeFirst);
            this.groupBoxTakingBus.Controls.Add(this.buttonSeeLast);
            this.groupBoxTakingBus.Controls.Add(this.buttonTakeBus);
            this.groupBoxTakingBus.Controls.Add(this.maskedTextBoxNumber);
            this.groupBoxTakingBus.Controls.Add(this.labelPlace);
            this.groupBoxTakingBus.Location = new System.Drawing.Point(838, 423);
            this.groupBoxTakingBus.Name = "groupBoxTakingBus";
            this.groupBoxTakingBus.Size = new System.Drawing.Size(228, 166);
            this.groupBoxTakingBus.TabIndex = 3;
            this.groupBoxTakingBus.TabStop = false;
            this.groupBoxTakingBus.Text = "Забрать автобус";
            // 
            // buttonSeeFirst
            // 
            this.buttonSeeFirst.Location = new System.Drawing.Point(115, 112);
            this.buttonSeeFirst.Name = "buttonSeeFirst";
            this.buttonSeeFirst.Size = new System.Drawing.Size(107, 34);
            this.buttonSeeFirst.TabIndex = 4;
            this.buttonSeeFirst.Text = "Первый";
            this.buttonSeeFirst.UseVisualStyleBackColor = true;
            this.buttonSeeFirst.Click += new System.EventHandler(this.buttonSeeFirst_Click);
            // 
            // buttonSeeLast
            // 
            this.buttonSeeLast.Location = new System.Drawing.Point(6, 112);
            this.buttonSeeLast.Name = "buttonSeeLast";
            this.buttonSeeLast.Size = new System.Drawing.Size(103, 34);
            this.buttonSeeLast.TabIndex = 3;
            this.buttonSeeLast.Text = "Последний";
            this.buttonSeeLast.UseVisualStyleBackColor = true;
            this.buttonSeeLast.Click += new System.EventHandler(this.buttonSeeLast_Click);
            // 
            // buttonTakeBus
            // 
            this.buttonTakeBus.Location = new System.Drawing.Point(65, 76);
            this.buttonTakeBus.Name = "buttonTakeBus";
            this.buttonTakeBus.Size = new System.Drawing.Size(112, 30);
            this.buttonTakeBus.TabIndex = 2;
            this.buttonTakeBus.Text = "Забрать";
            this.buttonTakeBus.UseVisualStyleBackColor = true;
            this.buttonTakeBus.Click += new System.EventHandler(this.buttonTakeBus_Click_1);
            // 
            // maskedTextBoxNumber
            // 
            this.maskedTextBoxNumber.Location = new System.Drawing.Point(73, 36);
            this.maskedTextBoxNumber.Name = "maskedTextBoxNumber";
            this.maskedTextBoxNumber.Size = new System.Drawing.Size(116, 22);
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
            // labelAuotovoksal
            // 
            this.labelAuotovoksal.AutoSize = true;
            this.labelAuotovoksal.Location = new System.Drawing.Point(908, 21);
            this.labelAuotovoksal.Name = "labelAuotovoksal";
            this.labelAuotovoksal.Size = new System.Drawing.Size(84, 17);
            this.labelAuotovoksal.TabIndex = 4;
            this.labelAuotovoksal.Text = "Автовокзал";
            // 
            // textBoxAutovoksalName
            // 
            this.textBoxAutovoksalName.Location = new System.Drawing.Point(868, 41);
            this.textBoxAutovoksalName.Name = "textBoxAutovoksalName";
            this.textBoxAutovoksalName.Size = new System.Drawing.Size(163, 22);
            this.textBoxAutovoksalName.TabIndex = 5;
            // 
            // buttonAddAutovoksal
            // 
            this.buttonAddAutovoksal.Location = new System.Drawing.Point(868, 69);
            this.buttonAddAutovoksal.Name = "buttonAddAutovoksal";
            this.buttonAddAutovoksal.Size = new System.Drawing.Size(163, 42);
            this.buttonAddAutovoksal.TabIndex = 6;
            this.buttonAddAutovoksal.Text = "Добавить автовокзал";
            this.buttonAddAutovoksal.UseVisualStyleBackColor = true;
            this.buttonAddAutovoksal.Click += new System.EventHandler(this.buttonAddAutovoksal_Click);
            // 
            // listBoxAutovoksal
            // 
            this.listBoxAutovoksal.FormattingEnabled = true;
            this.listBoxAutovoksal.ItemHeight = 16;
            this.listBoxAutovoksal.Location = new System.Drawing.Point(868, 117);
            this.listBoxAutovoksal.Name = "listBoxAutovoksal";
            this.listBoxAutovoksal.Size = new System.Drawing.Size(163, 100);
            this.listBoxAutovoksal.TabIndex = 7;
            this.listBoxAutovoksal.Click += new System.EventHandler(this.listBoxAutovoksal_SelectedIndexChanged_1);
            // 
            // buttonDelAutovoksal
            // 
            this.buttonDelAutovoksal.Location = new System.Drawing.Point(868, 223);
            this.buttonDelAutovoksal.Name = "buttonDelAutovoksal";
            this.buttonDelAutovoksal.Size = new System.Drawing.Size(163, 44);
            this.buttonDelAutovoksal.TabIndex = 8;
            this.buttonDelAutovoksal.Text = "Удалить автовокзал";
            this.buttonDelAutovoksal.UseVisualStyleBackColor = true;
            this.buttonDelAutovoksal.Click += new System.EventHandler(this.buttonDelAutovoksal_Click);
            // 
            // FormAutovoksal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 601);
            this.Controls.Add(this.buttonDelAutovoksal);
            this.Controls.Add(this.listBoxAutovoksal);
            this.Controls.Add(this.buttonAddAutovoksal);
            this.Controls.Add(this.textBoxAutovoksalName);
            this.Controls.Add(this.labelAuotovoksal);
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
        private System.Windows.Forms.Button buttonSeeLast;
        private System.Windows.Forms.Label labelAuotovoksal;
        private System.Windows.Forms.TextBox textBoxAutovoksalName;
        private System.Windows.Forms.Button buttonAddAutovoksal;
        private System.Windows.Forms.ListBox listBoxAutovoksal;
        private System.Windows.Forms.Button buttonDelAutovoksal;
        private System.Windows.Forms.Button buttonSeeFirst;
    }
}