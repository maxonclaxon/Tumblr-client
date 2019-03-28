namespace Курсовая_работа
{
    partial class Account_Form
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
            this.account_photo = new System.Windows.Forms.PictureBox();
            this.Account_Name = new System.Windows.Forms.Label();
            this.Account_Description = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.account_photo)).BeginInit();
            this.SuspendLayout();
            // 
            // account_photo
            // 
            this.account_photo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.account_photo.Location = new System.Drawing.Point(24, 26);
            this.account_photo.Name = "account_photo";
            this.account_photo.Size = new System.Drawing.Size(64, 64);
            this.account_photo.TabIndex = 0;
            this.account_photo.TabStop = false;
            // 
            // Account_Name
            // 
            this.Account_Name.AutoSize = true;
            this.Account_Name.Location = new System.Drawing.Point(21, 93);
            this.Account_Name.Name = "Account_Name";
            this.Account_Name.Size = new System.Drawing.Size(81, 13);
            this.Account_Name.TabIndex = 1;
            this.Account_Name.Text = "Account_Name";
            // 
            // Account_Description
            // 
            this.Account_Description.AutoSize = true;
            this.Account_Description.Location = new System.Drawing.Point(12, 116);
            this.Account_Description.Name = "Account_Description";
            this.Account_Description.Size = new System.Drawing.Size(106, 13);
            this.Account_Description.TabIndex = 2;
            this.Account_Description.Text = "Account_Description";
            // 
            // Account_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Account_Description);
            this.Controls.Add(this.Account_Name);
            this.Controls.Add(this.account_photo);
            this.Name = "Account_Form";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.account_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.account_photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox account_photo;
        private System.Windows.Forms.Label Account_Name;
        private System.Windows.Forms.Label Account_Description;
    }
}