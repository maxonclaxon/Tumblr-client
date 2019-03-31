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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Post_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Post_summary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_prev = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.count_of_posts = new System.Windows.Forms.Label();
            this.Change_Account = new System.Windows.Forms.Button();
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
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Post_ID,
            this.Post_summary});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(290, 26);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(498, 287);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
            // 
            // Post_ID
            // 
            this.Post_ID.Text = "№ поста";
            this.Post_ID.Width = 61;
            // 
            // Post_summary
            // 
            this.Post_summary.Text = "Описание";
            this.Post_summary.Width = 370;
            // 
            // button_prev
            // 
            this.button_prev.Location = new System.Drawing.Point(290, 415);
            this.button_prev.Name = "button_prev";
            this.button_prev.Size = new System.Drawing.Size(75, 23);
            this.button_prev.TabIndex = 4;
            this.button_prev.Text = "<";
            this.button_prev.UseVisualStyleBackColor = true;
            this.button_prev.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(713, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // count_of_posts
            // 
            this.count_of_posts.AutoSize = true;
            this.count_of_posts.Location = new System.Drawing.Point(532, 420);
            this.count_of_posts.Name = "count_of_posts";
            this.count_of_posts.Size = new System.Drawing.Size(35, 13);
            this.count_of_posts.TabIndex = 6;
            this.count_of_posts.Text = "label1";
            // 
            // Change_Account
            // 
            this.Change_Account.Location = new System.Drawing.Point(15, 420);
            this.Change_Account.Name = "Change_Account";
            this.Change_Account.Size = new System.Drawing.Size(147, 23);
            this.Change_Account.TabIndex = 7;
            this.Change_Account.Text = "другой пользователь";
            this.Change_Account.UseVisualStyleBackColor = true;
            this.Change_Account.Click += new System.EventHandler(this.Change_Account_Click);
            // 
            // Account_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Change_Account);
            this.Controls.Add(this.count_of_posts);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button_prev);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.Account_Description);
            this.Controls.Add(this.Account_Name);
            this.Controls.Add(this.account_photo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Account_Form";
            this.Text = "Аккаунт";
            this.Load += new System.EventHandler(this.account_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.account_photo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox account_photo;
        private System.Windows.Forms.Label Account_Name;
        private System.Windows.Forms.Label Account_Description;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button_prev;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader Post_ID;
        private System.Windows.Forms.ColumnHeader Post_summary;
        private System.Windows.Forms.Label count_of_posts;
        private System.Windows.Forms.Button Change_Account;
    }
}