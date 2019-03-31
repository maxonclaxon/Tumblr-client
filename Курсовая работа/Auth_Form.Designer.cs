namespace Курсовая_работа
{
    partial class Auth_Form
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
            this.auth_textBox = new System.Windows.Forms.TextBox();
            this.auth_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // auth_textBox
            // 
            this.auth_textBox.Location = new System.Drawing.Point(65, 83);
            this.auth_textBox.Margin = new System.Windows.Forms.Padding(0);
            this.auth_textBox.Name = "auth_textBox";
            this.auth_textBox.Size = new System.Drawing.Size(145, 20);
            this.auth_textBox.TabIndex = 0;
            // 
            // auth_button
            // 
            this.auth_button.Location = new System.Drawing.Point(65, 120);
            this.auth_button.Name = "auth_button";
            this.auth_button.Size = new System.Drawing.Size(145, 23);
            this.auth_button.TabIndex = 1;
            this.auth_button.Text = "Посмотреть фотографии";
            this.auth_button.UseVisualStyleBackColor = true;
            this.auth_button.Click += new System.EventHandler(this.auth_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(88, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите никнейм";
            // 
            // Auth_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 221);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.auth_button);
            this.Controls.Add(this.auth_textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Auth_Form";
            this.Text = "Поиск";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox auth_textBox;
        private System.Windows.Forms.Button auth_button;
        private System.Windows.Forms.Label label1;
    }
}

