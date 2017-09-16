namespace PanScada
{
    partial class Form1
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
            this.usersCheckBox = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.startAppointmentButton = new System.Windows.Forms.Button();
            this.startGameButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usersCheckBox
            // 
            this.usersCheckBox.CheckOnClick = true;
            this.usersCheckBox.FormattingEnabled = true;
            this.usersCheckBox.Location = new System.Drawing.Point(102, 149);
            this.usersCheckBox.Name = "usersCheckBox";
            this.usersCheckBox.Size = new System.Drawing.Size(165, 174);
            this.usersCheckBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Select config file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // startAppointmentButton
            // 
            this.startAppointmentButton.Location = new System.Drawing.Point(12, 50);
            this.startAppointmentButton.Name = "startAppointmentButton";
            this.startAppointmentButton.Size = new System.Drawing.Size(176, 32);
            this.startAppointmentButton.TabIndex = 2;
            this.startAppointmentButton.Text = "Start Appointment";
            this.startAppointmentButton.UseVisualStyleBackColor = true;
            this.startAppointmentButton.Click += new System.EventHandler(this.startAppointmentButton_Click);
            // 
            // startGameButton
            // 
            this.startGameButton.Location = new System.Drawing.Point(194, 12);
            this.startGameButton.Name = "startGameButton";
            this.startGameButton.Size = new System.Drawing.Size(176, 70);
            this.startGameButton.TabIndex = 3;
            this.startGameButton.Text = "Start Game";
            this.startGameButton.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(469, 118);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 408);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.startGameButton);
            this.Controls.Add(this.startAppointmentButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.usersCheckBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox usersCheckBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button startAppointmentButton;
        private System.Windows.Forms.Button startGameButton;
        private System.Windows.Forms.Button button2;
    }
}

