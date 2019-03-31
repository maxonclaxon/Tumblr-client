namespace Курсовая_работа
{
    partial class Post_Form
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
            this.Post_Picture = new System.Windows.Forms.PictureBox();
            this.Post_Summary = new System.Windows.Forms.Label();
            this.Post_Date = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Post_Picture)).BeginInit();
            this.SuspendLayout();
            // 
            // Post_Picture
            // 
            this.Post_Picture.Location = new System.Drawing.Point(12, 25);
            this.Post_Picture.Name = "Post_Picture";
            this.Post_Picture.Size = new System.Drawing.Size(250, 250);
            this.Post_Picture.TabIndex = 0;
            this.Post_Picture.TabStop = false;
            this.Post_Picture.DoubleClick += new System.EventHandler(this.Post_Picture_DoubleClick);
            // 
            // Post_Summary
            // 
            this.Post_Summary.AutoSize = true;
            this.Post_Summary.Location = new System.Drawing.Point(12, 288);
            this.Post_Summary.Name = "Post_Summary";
            this.Post_Summary.Size = new System.Drawing.Size(35, 13);
            this.Post_Summary.TabIndex = 1;
            this.Post_Summary.Text = "label1";
            // 
            // Post_Date
            // 
            this.Post_Date.AutoSize = true;
            this.Post_Date.Location = new System.Drawing.Point(12, 9);
            this.Post_Date.Name = "Post_Date";
            this.Post_Date.Size = new System.Drawing.Size(35, 13);
            this.Post_Date.TabIndex = 2;
            this.Post_Date.Text = "label1";
            // 
            // Post_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 437);
            this.Controls.Add(this.Post_Date);
            this.Controls.Add(this.Post_Summary);
            this.Controls.Add(this.Post_Picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Post_Form";
            this.Text = "Пост";
            this.Load += new System.EventHandler(this.Post_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Post_Picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Post_Picture;
        private System.Windows.Forms.Label Post_Summary;
        private System.Windows.Forms.Label Post_Date;
    }
}