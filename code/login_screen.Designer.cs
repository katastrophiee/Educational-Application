namespace Task2_Code
{
    partial class login_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_screen));
            this.decor_panel2 = new System.Windows.Forms.Panel();
            this.decor_panel = new System.Windows.Forms.Panel();
            this.content_panel = new System.Windows.Forms.Panel();
            this.back_btn = new System.Windows.Forms.Button();
            this.remembered_check = new System.Windows.Forms.CheckBox();
            this.sign_in_btn = new System.Windows.Forms.Button();
            this.account_creation_screen_btn = new System.Windows.Forms.Button();
            this.password = new System.Windows.Forms.TextBox();
            this.username = new System.Windows.Forms.TextBox();
            this.title_lbl = new System.Windows.Forms.Label();
            this.company_logo = new System.Windows.Forms.PictureBox();
            this.content_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.company_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // decor_panel2
            // 
            this.decor_panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(127)))));
            this.decor_panel2.Location = new System.Drawing.Point(951, 12);
            this.decor_panel2.Name = "decor_panel2";
            this.decor_panel2.Size = new System.Drawing.Size(301, 657);
            this.decor_panel2.TabIndex = 5;
            // 
            // decor_panel
            // 
            this.decor_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(223)))), ((int)(((byte)(127)))));
            this.decor_panel.Location = new System.Drawing.Point(12, 12);
            this.decor_panel.Name = "decor_panel";
            this.decor_panel.Size = new System.Drawing.Size(301, 657);
            this.decor_panel.TabIndex = 4;
            // 
            // content_panel
            // 
            this.content_panel.AutoScroll = true;
            this.content_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(212)))), ((int)(((byte)(244)))));
            this.content_panel.Controls.Add(this.back_btn);
            this.content_panel.Controls.Add(this.remembered_check);
            this.content_panel.Controls.Add(this.sign_in_btn);
            this.content_panel.Controls.Add(this.account_creation_screen_btn);
            this.content_panel.Controls.Add(this.password);
            this.content_panel.Controls.Add(this.username);
            this.content_panel.Controls.Add(this.title_lbl);
            this.content_panel.Controls.Add(this.company_logo);
            this.content_panel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.content_panel.Location = new System.Drawing.Point(329, -2);
            this.content_panel.Name = "content_panel";
            this.content_panel.Size = new System.Drawing.Size(606, 754);
            this.content_panel.TabIndex = 3;
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.Transparent;
            this.back_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("back_btn.BackgroundImage")));
            this.back_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.back_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_btn.Font = new System.Drawing.Font("Tahoma", 16F);
            this.back_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(212)))), ((int)(((byte)(244)))));
            this.back_btn.Location = new System.Drawing.Point(3, 9);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(110, 68);
            this.back_btn.TabIndex = 21;
            this.back_btn.UseVisualStyleBackColor = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // remembered_check
            // 
            this.remembered_check.AutoSize = true;
            this.remembered_check.Location = new System.Drawing.Point(157, 357);
            this.remembered_check.Name = "remembered_check";
            this.remembered_check.Size = new System.Drawing.Size(132, 23);
            this.remembered_check.TabIndex = 20;
            this.remembered_check.Text = "Remember me";
            this.remembered_check.UseVisualStyleBackColor = true;
            // 
            // sign_in_btn
            // 
            this.sign_in_btn.BackColor = System.Drawing.Color.RoyalBlue;
            this.sign_in_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sign_in_btn.Font = new System.Drawing.Font("Tahoma", 16F);
            this.sign_in_btn.ForeColor = System.Drawing.Color.White;
            this.sign_in_btn.Location = new System.Drawing.Point(207, 412);
            this.sign_in_btn.Name = "sign_in_btn";
            this.sign_in_btn.Size = new System.Drawing.Size(192, 68);
            this.sign_in_btn.TabIndex = 19;
            this.sign_in_btn.Text = "Sign In";
            this.sign_in_btn.UseVisualStyleBackColor = false;
            this.sign_in_btn.Click += new System.EventHandler(this.sign_in_btn_Click);
            // 
            // account_creation_screen_btn
            // 
            this.account_creation_screen_btn.BackColor = System.Drawing.Color.RoyalBlue;
            this.account_creation_screen_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.account_creation_screen_btn.Font = new System.Drawing.Font("Tahoma", 16F);
            this.account_creation_screen_btn.ForeColor = System.Drawing.Color.White;
            this.account_creation_screen_btn.Location = new System.Drawing.Point(207, 514);
            this.account_creation_screen_btn.Name = "account_creation_screen_btn";
            this.account_creation_screen_btn.Size = new System.Drawing.Size(192, 68);
            this.account_creation_screen_btn.TabIndex = 18;
            this.account_creation_screen_btn.Text = "No account? Make one!";
            this.account_creation_screen_btn.UseVisualStyleBackColor = false;
            this.account_creation_screen_btn.Click += new System.EventHandler(this.account_creation_screen_btn_Click);
            // 
            // password
            // 
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.password.Font = new System.Drawing.Font("Tahoma", 21F);
            this.password.ForeColor = System.Drawing.Color.Silver;
            this.password.Location = new System.Drawing.Point(157, 292);
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
            this.title_lbl.Location = new System.Drawing.Point(218, 146);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(170, 42);
            this.title_lbl.TabIndex = 9;
            this.title_lbl.Text = "Welcome!";
            // 
            // company_logo
            // 
            this.company_logo.BackColor = System.Drawing.Color.Transparent;
            this.company_logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("company_logo.BackgroundImage")));
            this.company_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.company_logo.Location = new System.Drawing.Point(242, 9);
            this.company_logo.Name = "company_logo";
            this.company_logo.Size = new System.Drawing.Size(123, 123);
            this.company_logo.TabIndex = 8;
            this.company_logo.TabStop = false;
            // 
            // login_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.decor_panel2);
            this.Controls.Add(this.decor_panel);
            this.Controls.Add(this.content_panel);
            this.Name = "login_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Shown += new System.EventHandler(this.login_screen_Shown);
            this.content_panel.ResumeLayout(false);
            this.content_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.company_logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel decor_panel2;
        private System.Windows.Forms.Panel decor_panel;
        private System.Windows.Forms.Panel content_panel;
        private System.Windows.Forms.Button account_creation_screen_btn;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.PictureBox company_logo;
        private System.Windows.Forms.CheckBox remembered_check;
        private System.Windows.Forms.Button sign_in_btn;
        private System.Windows.Forms.Button back_btn;
    }
}