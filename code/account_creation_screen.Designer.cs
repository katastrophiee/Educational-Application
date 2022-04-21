namespace Task2_Code
{
    partial class account_creation_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(account_creation_screen));
            this.company_logo = new System.Windows.Forms.PictureBox();
            this.content_panel = new System.Windows.Forms.Panel();
            this.back_btn = new System.Windows.Forms.Button();
            this.create_account_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.code = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.title_lbl = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.company_logo)).BeginInit();
            this.content_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // company_logo
            // 
            this.company_logo.BackColor = System.Drawing.Color.Transparent;
            this.company_logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("company_logo.BackgroundImage")));
            this.company_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.company_logo.Location = new System.Drawing.Point(242, 9);
            this.company_logo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.company_logo.Name = "company_logo";
            this.company_logo.Size = new System.Drawing.Size(122, 123);
            this.company_logo.TabIndex = 8;
            this.company_logo.TabStop = false;
            // 
            // content_panel
            // 
            this.content_panel.AutoScroll = true;
            this.content_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(212)))), ((int)(((byte)(244)))));
            this.content_panel.Controls.Add(this.back_btn);
            this.content_panel.Controls.Add(this.create_account_btn);
            this.content_panel.Controls.Add(this.label1);
            this.content_panel.Controls.Add(this.code);
            this.content_panel.Controls.Add(this.email);
            this.content_panel.Controls.Add(this.name);
            this.content_panel.Controls.Add(this.password);
            this.content_panel.Controls.Add(this.username);
            this.content_panel.Controls.Add(this.title_lbl);
            this.content_panel.Controls.Add(this.company_logo);
            this.content_panel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.content_panel.Location = new System.Drawing.Point(329, -1);
            this.content_panel.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.content_panel.Name = "content_panel";
            this.content_panel.Size = new System.Drawing.Size(606, 754);
            this.content_panel.TabIndex = 0;
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.Transparent;
            this.back_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back_btn.BackgroundImage")));
            this.back_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.Font = new System.Drawing.Font("Tahoma", 16F);
            this.back_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(212)))), ((int)(((byte)(244)))));
            this.back_btn.Location = new System.Drawing.Point(2, 9);
            this.back_btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(110, 68);
            this.back_btn.TabIndex = 19;
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // create_account_btn
            // 
            this.create_account_btn.BackColor = System.Drawing.Color.RoyalBlue;
            this.create_account_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.create_account_btn.Font = new System.Drawing.Font("Tahoma", 16F);
            this.create_account_btn.ForeColor = System.Drawing.Color.White;
            this.create_account_btn.Location = new System.Drawing.Point(206, 572);
            this.create_account_btn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.create_account_btn.Name = "create_account_btn";
            this.create_account_btn.Size = new System.Drawing.Size(192, 68);
            this.create_account_btn.TabIndex = 18;
            this.create_account_btn.Text = "Create Account";
            this.create_account_btn.UseVisualStyleBackColor = false;
            this.create_account_btn.Click += new System.EventHandler(this.create_account_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.75F);
            this.label1.Location = new System.Drawing.Point(152, 503);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 28);
            this.label1.TabIndex = 15;
            this.label1.Text = "Code:";
            // 
            // code
            // 
            this.code.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.code.Font = new System.Drawing.Font("Tahoma", 16F);
            this.code.ForeColor = System.Drawing.Color.Silver;
            this.code.Location = new System.Drawing.Point(230, 506);
            this.code.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(220, 26);
            this.code.TabIndex = 14;
            this.code.Text = "000-000-000";
            this.code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.code.Enter += new System.EventHandler(this.code_Enter);
            this.code.Leave += new System.EventHandler(this.code_Leave);
            // 
            // email
            // 
            this.email.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.email.Font = new System.Drawing.Font("Tahoma", 21F);
            this.email.ForeColor = System.Drawing.Color.Silver;
            this.email.Location = new System.Drawing.Point(157, 430);
            this.email.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(293, 34);
            this.email.TabIndex = 13;
            this.email.Text = "Email";
            this.email.Enter += new System.EventHandler(this.email_Enter);
            this.email.Leave += new System.EventHandler(this.email_Leave);
            // 
            // name
            // 
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Font = new System.Drawing.Font("Tahoma", 21F);
            this.name.ForeColor = System.Drawing.Color.Silver;
            this.name.Location = new System.Drawing.Point(157, 363);
            this.name.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(293, 34);
            this.name.TabIndex = 12;
            this.name.Text = "Name";
            this.name.Enter += new System.EventHandler(this.name_Enter);
            this.name.Leave += new System.EventHandler(this.name_Leave);
            // 
            // password
            // 
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Font = new System.Drawing.Font("Tahoma", 21F);
            this.password.ForeColor = System.Drawing.Color.Silver;
            this.password.Location = new System.Drawing.Point(157, 295);
            this.password.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(293, 34);
            this.password.TabIndex = 11;
            this.password.Text = "Password";
            this.password.Enter += new System.EventHandler(this.password_Enter);
            this.password.Leave += new System.EventHandler(this.password_Leave);
            // 
            // username
            // 
            this.username.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.username.Font = new System.Drawing.Font("Tahoma", 21F);
            this.username.ForeColor = System.Drawing.Color.Silver;
            this.username.Location = new System.Drawing.Point(157, 227);
            this.username.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(293, 34);
            this.username.TabIndex = 10;
            this.username.Text = "Username";
            this.username.Enter += new System.EventHandler(this.username_Enter);
            this.username.Leave += new System.EventHandler(this.username_Leave);
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Tahoma", 26F);
            this.title_lbl.Location = new System.Drawing.Point(186, 146);
            this.title_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(235, 42);
            this.title_lbl.TabIndex = 9;
            this.title_lbl.Text = "Join us today!";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(127)))));
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(301, 657);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(127)))));
            this.panel2.Location = new System.Drawing.Point(950, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(301, 657);
            this.panel2.TabIndex = 2;
            // 
            // account_creation_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.content_panel);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "account_creation_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create an Account";
            this.Shown += new System.EventHandler(this.account_creation_screen_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.company_logo)).EndInit();
            this.content_panel.ResumeLayout(false);
            this.content_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox company_logo;
        private System.Windows.Forms.Panel content_panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button create_account_btn;
        private System.Windows.Forms.Button back_btn;
    }
}