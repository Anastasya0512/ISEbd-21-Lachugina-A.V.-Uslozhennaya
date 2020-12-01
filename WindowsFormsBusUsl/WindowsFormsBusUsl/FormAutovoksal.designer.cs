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
            this.groupBoxTakingBus = new System.Windows.Forms.GroupBox();
            this.buttonSeeBus = new System.Windows.Forms.Button();
            this.buttonTakeBus = new System.Windows.Forms.Button();
            this.maskedTextBoxNumber = new System.Windows.Forms.MaskedTextBox();
            this.labelPlace = new System.Windows.Forms.Label();
            this.labelAuotovoksal = new System.Windows.Forms.Label();
            this.textBoxAutovoksalName = new System.Windows.Forms.TextBox();
            this.buttonAddAutovoksal = new System.Windows.Forms.Button();
            this.listBoxAutovoksal = new System.Windows.Forms.ListBox();
            this.buttonDelAutovoksal = new System.Windows.Forms.Button();
            this.buttonAddBus = new System.Windows.Forms.Button();
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
            // groupBoxTakingBus
            // 
            this.groupBoxTakingBus.Controls.Add(this.buttonSeeBus);
            this.groupBoxTakingBus.Controls.Add(this.buttonTakeBus);
            this.groupBoxTakingBus.Controls.Add(this.maskedTextBoxNumber);
            this.groupBoxTakingBus.Controls.Add(this.labelPlace);
            this.groupBoxTakingBus.Location = new System.Drawing.Point(894, 441);
            this.groupBoxTakingBus.Name = "groupBoxTakingBus";
            this.groupBoxTakingBus.Size = new System.Drawing.Size(150, 148);
            this.groupBoxTakingBus.TabIndex = 3;
            this.groupBoxTakingBus.TabStop = false;
            this.groupBoxTakingBus.Text = "Забрать автобус";
            // 
            // buttonSeeBus
            // 
            this.buttonSeeBus.Location = new System.Drawing.Point(17, 100);
            this.buttonSeeBus.Name = "buttonSeeBus";
            this.buttonSeeBus.Size = new System.Drawing.Size(103, 34);
            this.buttonSeeBus.TabIndex = 3;
            this.buttonSeeBus.Text = "Последний";
            this.buttonSeeBus.UseVisualStyleBackColor = true;
            this.buttonSeeBus.Click += new System.EventHandler(this.buttonSeeBus_Click);
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
            // labelAuotovoksal
            // 
            this.labelAuotovoksal.AutoSize = true;
            this.labelAuotovoksal.Location = new System.Drawing.Point(921, 28);
            this.labelAuotovoksal.Name = "labelAuotovoksal";
            this.labelAuotovoksal.Size = new System.Drawing.Size(84, 17);
            this.labelAuotovoksal.TabIndex = 4;
            this.labelAuotovoksal.Text = "Автовокзал";
            // 
            // textBoxAutovoksalName
            // 
            this.textBoxAutovoksalName.Location = new System.Drawing.Point(881, 48);
            this.textBoxAutovoksalName.Name = "textBoxAutovoksalName";
            this.textBoxAutovoksalName.Size = new System.Drawing.Size(163, 22);
            this.textBoxAutovoksalName.TabIndex = 5;
            // 
            // buttonAddAutovoksal
            // 
            this.buttonAddAutovoksal.Location = new System.Drawing.Point(881, 76);
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
            this.listBoxAutovoksal.Location = new System.Drawing.Point(881, 124);
            this.listBoxAutovoksal.Name = "listBoxAutovoksal";
            this.listBoxAutovoksal.Size = new System.Drawing.Size(163, 100);
            this.listBoxAutovoksal.TabIndex = 7;
            this.listBoxAutovoksal.Click += new System.EventHandler(this.listBoxAutovoksal_SelectedIndexChanged_1);
            // 
            // buttonDelAutovoksal
            // 
            this.buttonDelAutovoksal.Location = new System.Drawing.Point(881, 230);
            this.buttonDelAutovoksal.Name = "buttonDelAutovoksal";
            this.buttonDelAutovoksal.Size = new System.Drawing.Size(163, 44);
            this.buttonDelAutovoksal.TabIndex = 8;
            this.buttonDelAutovoksal.Text = "Удалить автовокзал";
            this.buttonDelAutovoksal.UseVisualStyleBackColor = true;
            this.buttonDelAutovoksal.Click += new System.EventHandler(this.buttonDelAutovoksal_Click);
            // 
            // buttonAddBus
            // 
            this.buttonAddBus.Location = new System.Drawing.Point(881, 329);
            this.buttonAddBus.Name = "buttonAddBus";
            this.buttonAddBus.Size = new System.Drawing.Size(163, 53);
            this.buttonAddBus.TabIndex = 10;
            this.buttonAddBus.Text = "Добавить автобус";
            this.buttonAddBus.UseVisualStyleBackColor = true;
            this.buttonAddBus.Click += new System.EventHandler(this.buttonAddBus_Click);
            // 
            // FormAutovoksal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 601);
            this.Controls.Add(this.buttonAddBus);
            this.Controls.Add(this.buttonDelAutovoksal);
            this.Controls.Add(this.listBoxAutovoksal);
            this.Controls.Add(this.buttonAddAutovoksal);
            this.Controls.Add(this.textBoxAutovoksalName);
            this.Controls.Add(this.labelAuotovoksal);
            this.Controls.Add(this.groupBoxTakingBus);
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
        private System.Windows.Forms.GroupBox groupBoxTakingBus;
        private System.Windows.Forms.Button buttonTakeBus;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumber;
        private System.Windows.Forms.Label labelPlace;
        private System.Windows.Forms.Button buttonSeeBus;
        private System.Windows.Forms.Label labelAuotovoksal;
        private System.Windows.Forms.TextBox textBoxAutovoksalName;
        private System.Windows.Forms.Button buttonAddAutovoksal;
        private System.Windows.Forms.ListBox listBoxAutovoksal;
        private System.Windows.Forms.Button buttonDelAutovoksal;
        private System.Windows.Forms.Button buttonAddBus;
    }
}