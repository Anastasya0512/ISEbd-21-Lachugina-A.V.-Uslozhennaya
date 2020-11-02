namespace WindowsFormsBusUsl
{
    partial class FormBus
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxBus = new System.Windows.Forms.PictureBox();
            this.buttonCreateBus = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.groupBoxBusGarm = new System.Windows.Forms.GroupBox();
            this.labelFormDoor = new System.Windows.Forms.Label();
            this.checkBoxRectangle = new System.Windows.Forms.CheckBox();
            this.checkBoxEllipse = new System.Windows.Forms.CheckBox();
            this.checkBoxTriangle = new System.Windows.Forms.CheckBox();
            this.buttonCreateBusGarm = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBus)).BeginInit();
            this.groupBoxBusGarm.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxBus
            // 
            this.pictureBoxBus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxBus.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxBus.Name = "pictureBoxBus";
            this.pictureBoxBus.Size = new System.Drawing.Size(969, 568);
            this.pictureBoxBus.TabIndex = 0;
            this.pictureBoxBus.TabStop = false;
            this.pictureBoxBus.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonCreateBus
            // 
            this.buttonCreateBus.Location = new System.Drawing.Point(12, 12);
            this.buttonCreateBus.Name = "buttonCreateBus";
            this.buttonCreateBus.Size = new System.Drawing.Size(91, 32);
            this.buttonCreateBus.TabIndex = 1;
            this.buttonCreateBus.Text = "Создать";
            this.buttonCreateBus.UseVisualStyleBackColor = true;
            this.buttonCreateBus.Click += new System.EventHandler(this.buttonCreateBus_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLeft.BackgroundImage = global::WindowsFormsBusUsl.Properties.Resources.лево;
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(833, 516);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 30);
            this.buttonLeft.TabIndex = 2;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackgroundImage = global::WindowsFormsBusUsl.Properties.Resources.верх;
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(869, 480);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 30);
            this.buttonUp.TabIndex = 3;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRight.BackgroundImage = global::WindowsFormsBusUsl.Properties.Resources.вправо;
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(905, 516);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 30);
            this.buttonRight.TabIndex = 4;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDown.BackgroundImage = global::WindowsFormsBusUsl.Properties.Resources.вниз;
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(869, 516);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(30, 30);
            this.buttonDown.TabIndex = 5;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // groupBoxBusGarm
            // 
            this.groupBoxBusGarm.Controls.Add(this.buttonCreateBusGarm);
            this.groupBoxBusGarm.Controls.Add(this.checkBoxTriangle);
            this.groupBoxBusGarm.Controls.Add(this.checkBoxEllipse);
            this.groupBoxBusGarm.Controls.Add(this.checkBoxRectangle);
            this.groupBoxBusGarm.Controls.Add(this.labelFormDoor);
            this.groupBoxBusGarm.Location = new System.Drawing.Point(739, 12);
            this.groupBoxBusGarm.Name = "groupBoxBusGarm";
            this.groupBoxBusGarm.Size = new System.Drawing.Size(218, 193);
            this.groupBoxBusGarm.TabIndex = 6;
            this.groupBoxBusGarm.TabStop = false;
            this.groupBoxBusGarm.Text = "Создать автобус с гармошкой";
            // 
            // labelFormDoor
            // 
            this.labelFormDoor.AutoSize = true;
            this.labelFormDoor.Location = new System.Drawing.Point(10, 43);
            this.labelFormDoor.Name = "labelFormDoor";
            this.labelFormDoor.Size = new System.Drawing.Size(172, 17);
            this.labelFormDoor.TabIndex = 0;
            this.labelFormDoor.Text = "Выберите форму дверей";
            // 
            // checkBoxRectangle
            // 
            this.checkBoxRectangle.AutoSize = true;
            this.checkBoxRectangle.Location = new System.Drawing.Point(13, 71);
            this.checkBoxRectangle.Name = "checkBoxRectangle";
            this.checkBoxRectangle.Size = new System.Drawing.Size(132, 21);
            this.checkBoxRectangle.TabIndex = 1;
            this.checkBoxRectangle.Text = "Прямоугольная";
            this.checkBoxRectangle.UseVisualStyleBackColor = true;
            // 
            // checkBoxEllipse
            // 
            this.checkBoxEllipse.AutoSize = true;
            this.checkBoxEllipse.Location = new System.Drawing.Point(13, 98);
            this.checkBoxEllipse.Name = "checkBoxEllipse";
            this.checkBoxEllipse.Size = new System.Drawing.Size(95, 21);
            this.checkBoxEllipse.TabIndex = 2;
            this.checkBoxEllipse.Text = "Овальная";
            this.checkBoxEllipse.UseVisualStyleBackColor = true;
            // 
            // checkBoxTriangle
            // 
            this.checkBoxTriangle.AutoSize = true;
            this.checkBoxTriangle.Location = new System.Drawing.Point(13, 125);
            this.checkBoxTriangle.Name = "checkBoxTriangle";
            this.checkBoxTriangle.Size = new System.Drawing.Size(114, 21);
            this.checkBoxTriangle.TabIndex = 3;
            this.checkBoxTriangle.Text = "Треугольная";
            this.checkBoxTriangle.UseVisualStyleBackColor = true;
            // 
            // buttonCreateBusGarm
            // 
            this.buttonCreateBusGarm.Location = new System.Drawing.Point(13, 152);
            this.buttonCreateBusGarm.Name = "buttonCreateBusGarm";
            this.buttonCreateBusGarm.Size = new System.Drawing.Size(95, 37);
            this.buttonCreateBusGarm.TabIndex = 4;
            this.buttonCreateBusGarm.Text = "Создать";
            this.buttonCreateBusGarm.UseVisualStyleBackColor = true;
            this.buttonCreateBusGarm.Click += new System.EventHandler(this.buttonCreateBusGarm_Click);
            // 
            // FormBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 568);
            this.Controls.Add(this.groupBoxBusGarm);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonCreateBus);
            this.Controls.Add(this.pictureBoxBus);
            this.Name = "FormBus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автобус";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBus)).EndInit();
            this.groupBoxBusGarm.ResumeLayout(false);
            this.groupBoxBusGarm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxBus;
        private System.Windows.Forms.Button buttonCreateBus;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.GroupBox groupBoxBusGarm;
        private System.Windows.Forms.Button buttonCreateBusGarm;
        private System.Windows.Forms.CheckBox checkBoxTriangle;
        private System.Windows.Forms.CheckBox checkBoxEllipse;
        private System.Windows.Forms.CheckBox checkBoxRectangle;
        private System.Windows.Forms.Label labelFormDoor;
    }
}

