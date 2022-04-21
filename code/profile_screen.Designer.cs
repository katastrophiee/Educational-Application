namespace Task2_Code
{
    partial class profile_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(profile_screen));
            this.bkg_png_pnl = new System.Windows.Forms.Panel();
            this.content_panel = new System.Windows.Forms.Panel();
            this.show_password_btn = new System.Windows.Forms.Button();
            this.change_username_btn = new System.Windows.Forms.Button();
            this.change_email_btn = new System.Windows.Forms.Button();
            this.log_out_btn = new System.Windows.Forms.Button();
            this.change_password_btn = new System.Windows.Forms.Button();
            this.user_password_lbl = new System.Windows.Forms.Label();
            this.user_username_lbl = new System.Windows.Forms.Label();
            this.user_email_lbl = new System.Windows.Forms.Label();
            this.password_lbl = new System.Windows.Forms.Label();
            this.username_lbl = new System.Windows.Forms.Label();
            this.email_lbl = new System.Windows.Forms.Label();
            this.name_lbl = new System.Windows.Forms.Label();
            this.not_logged_in_lbl = new System.Windows.Forms.Label();
            this.login_screen_btn = new System.Windows.Forms.Button();
            this.title_lbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.notification_pnl = new System.Windows.Forms.Panel();
            this.notification_close_btn = new System.Windows.Forms.Button();
            this.bkg_png_pnl.SuspendLayout();
            this.content_panel.SuspendLayout();
            this.notification_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // bkg_png_pnl
            // 
            this.bkg_png_pnl.BackColor = System.Drawing.Color.AliceBlue;
            this.bkg_png_pnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bkg_png_pnl.BackgroundImage")));
            this.bkg_png_pnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bkg_png_pnl.Controls.Add(this.content_panel);
            this.bkg_png_pnl.Location = new System.Drawing.Point(12, 159);
            this.bkg_png_pnl.Name = "bkg_png_pnl";
            this.bkg_png_pnl.Size = new System.Drawing.Size(1240, 510);
            this.bkg_png_pnl.TabIndex = 16;
            // 
            // content_panel
            // 
            this.content_panel.AutoScroll = true;
            this.content_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(212)))), ((int)(((byte)(244)))));
            this.content_panel.Controls.Add(this.show_password_btn);
            this.content_panel.Controls.Add(this.change_username_btn);
            this.content_panel.Controls.Add(this.change_email_btn);
            this.content_panel.Controls.Add(this.log_out_btn);
            this.content_panel.Controls.Add(this.change_password_btn);
            this.content_panel.Controls.Add(this.user_password_lbl);
            this.content_panel.Controls.Add(this.user_username_lbl);
            this.content_panel.Controls.Add(this.user_email_lbl);
            this.content_panel.Controls.Add(this.password_lbl);
            this.content_panel.Controls.Add(this.username_lbl);
            this.content_panel.Controls.Add(this.email_lbl);
            this.content_panel.Controls.Add(this.name_lbl);
            this.content_panel.Controls.Add(this.not_logged_in_lbl);
            this.content_panel.Controls.Add(this.login_screen_btn);
            this.content_panel.Controls.Add(this.title_lbl);
            this.content_panel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.content_panel.Location = new System.Drawing.Point(34, 29);
            this.content_panel.Name = "content_panel";
            this.content_panel.Size = new System.Drawing.Size(964, 454);
            this.content_panel.TabIndex = 0;
            // 
            // show_password_btn
            // 
            this.show_password_btn.BackColor = System.Drawing.Color.RoyalBlue;
            this.show_password_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.show_password_btn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.show_password_btn.ForeColor = System.Drawing.Color.White;
            this.show_password_btn.Location = new System.Drawing.Point(823, 126);
            this.show_password_btn.Name = "show_password_btn";
            this.show_password_btn.Size = new System.Drawing.Size(112, 62);
            this.show_password_btn.TabIndex = 32;
            this.show_password_btn.Text = "Show Password";
            this.show_password_btn.UseVisualStyleBackColor = false;
            this.show_password_btn.Click += new System.EventHandler(this.show_password_btn_Click);
            // 
            // change_username_btn
            // 
            this.change_username_btn.BackColor = System.Drawing.Color.RoyalBlue;
            this.change_username_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.change_username_btn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.change_username_btn.ForeColor = System.Drawing.Color.White;
            this.change_username_btn.Location = new System.Drawing.Point(822, 234);
            this.change_username_btn.Name = "change_username_btn";
            this.change_username_btn.Size = new System.Drawing.Size(112, 62);
            this.change_username_btn.TabIndex = 31;
            this.change_username_btn.Text = "Change Username";
            this.change_username_btn.UseVisualStyleBackColor = false;
            // 
            // change_email_btn
            // 
            this.change_email_btn.BackColor = System.Drawing.Color.RoyalBlue;
            this.change_email_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.change_email_btn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.change_email_btn.ForeColor = System.Drawing.Color.White;
            this.change_email_btn.Location = new System.Drawing.Point(822, 302);
            this.change_email_btn.Name = "change_email_btn";
            this.change_email_btn.Size = new System.Drawing.Size(112, 62);
            this.change_email_btn.TabIndex = 30;
            this.change_email_btn.Text = "Change Email";
            this.change_email_btn.UseVisualStyleBackColor = false;
            // 
            // log_out_btn
            // 
            this.log_out_btn.BackColor = System.Drawing.Color.RoyalBlue;
            this.log_out_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.log_out_btn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.log_out_btn.ForeColor = System.Drawing.Color.White;
            this.log_out_btn.Location = new System.Drawing.Point(823, 23);
            this.log_out_btn.Name = "log_out_btn";
            this.log_out_btn.Size = new System.Drawing.Size(112, 62);
            this.log_out_btn.TabIndex = 29;
            this.log_out_btn.Text = "Log out";
            this.log_out_btn.UseVisualStyleBackColor = false;
            this.log_out_btn.Click += new System.EventHandler(this.log_out_btn_Click);
            // 
            // change_password_btn
            // 
            this.change_password_btn.BackColor = System.Drawing.Color.RoyalBlue;
            this.change_password_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.change_password_btn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.change_password_btn.ForeColor = System.Drawing.Color.White;
            this.change_password_btn.Location = new System.Drawing.Point(822, 370);
            this.change_password_btn.Name = "change_password_btn";
            this.change_password_btn.Size = new System.Drawing.Size(112, 62);
            this.change_password_btn.TabIndex = 28;
            this.change_password_btn.Text = "Change Password";
            this.change_password_btn.UseVisualStyleBackColor = false;
            // 
            // user_password_lbl
            // 
            this.user_password_lbl.AutoSize = true;
            this.user_password_lbl.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_password_lbl.Location = new System.Drawing.Point(239, 353);
            this.user_password_lbl.Name = "user_password_lbl";
            this.user_password_lbl.Size = new System.Drawing.Size(146, 35);
            this.user_password_lbl.TabIndex = 27;
            this.user_password_lbl.Text = "Password:";
            // 
            // user_username_lbl
            // 
            this.user_username_lbl.AutoSize = true;
            this.user_username_lbl.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_username_lbl.Location = new System.Drawing.Point(239, 268);
            this.user_username_lbl.Name = "user_username_lbl";
            this.user_username_lbl.Size = new System.Drawing.Size(152, 35);
            this.user_username_lbl.TabIndex = 26;
            this.user_username_lbl.Text = "Username:";
            // 
            // user_email_lbl
            // 
            this.user_email_lbl.AutoSize = true;
            this.user_email_lbl.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_email_lbl.Location = new System.Drawing.Point(176, 183);
            this.user_email_lbl.Name = "user_email_lbl";
            this.user_email_lbl.Size = new System.Drawing.Size(94, 35);
            this.user_email_lbl.TabIndex = 25;
            this.user_email_lbl.Text = "Email:";
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_lbl.Location = new System.Drawing.Point(60, 353);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(146, 35);
            this.password_lbl.TabIndex = 24;
            this.password_lbl.Text = "Password:";
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_lbl.Location = new System.Drawing.Point(60, 268);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(152, 35);
            this.username_lbl.TabIndex = 23;
            this.username_lbl.Text = "Username:";
            // 
            // email_lbl
            // 
            this.email_lbl.AutoSize = true;
            this.email_lbl.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email_lbl.Location = new System.Drawing.Point(60, 183);
            this.email_lbl.Name = "email_lbl";
            this.email_lbl.Size = new System.Drawing.Size(94, 35);
            this.email_lbl.TabIndex = 22;
            this.email_lbl.Text = "Email:";
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lbl.Location = new System.Drawing.Point(60, 98);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(88, 35);
            this.name_lbl.TabIndex = 21;
            this.name_lbl.Text = "Name";
            // 
            // not_logged_in_lbl
            // 
            this.not_logged_in_lbl.AutoSize = true;
            this.not_logged_in_lbl.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.not_logged_in_lbl.Location = new System.Drawing.Point(264, 107);
            this.not_logged_in_lbl.Name = "not_logged_in_lbl";
            this.not_logged_in_lbl.Size = new System.Drawing.Size(437, 35);
            this.not_logged_in_lbl.TabIndex = 19;
            this.not_logged_in_lbl.Text = "You\'re not logged in, log in here:";
            // 
            // login_screen_btn
            // 
            this.login_screen_btn.BackColor = System.Drawing.Color.RoyalBlue;
            this.login_screen_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_screen_btn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.login_screen_btn.ForeColor = System.Drawing.Color.White;
            this.login_screen_btn.Location = new System.Drawing.Point(426, 169);
            this.login_screen_btn.Name = "login_screen_btn";
            this.login_screen_btn.Size = new System.Drawing.Size(112, 62);
            this.login_screen_btn.TabIndex = 18;
            this.login_screen_btn.Text = "Log in";
            this.login_screen_btn.UseVisualStyleBackColor = false;
            this.login_screen_btn.Click += new System.EventHandler(this.login_screen_btn_Click);
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.Location = new System.Drawing.Point(24, 23);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(95, 35);
            this.title_lbl.TabIndex = 0;
            this.title_lbl.Text = "Profile";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1140, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 103);
            this.button1.TabIndex = 17;
            this.button1.Text = "Notifications";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // notification_pnl
            // 
            this.notification_pnl.Controls.Add(this.notification_close_btn);
            this.notification_pnl.Location = new System.Drawing.Point(952, 22);
            this.notification_pnl.Name = "notification_pnl";
            this.notification_pnl.Size = new System.Drawing.Size(300, 658);
            this.notification_pnl.TabIndex = 18;
            this.notification_pnl.Visible = false;
            // 
            // notification_close_btn
            // 
            this.notification_close_btn.BackColor = System.Drawing.Color.RoyalBlue;
            this.notification_close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.notification_close_btn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.notification_close_btn.ForeColor = System.Drawing.Color.White;
            this.notification_close_btn.Location = new System.Drawing.Point(0, 0);
            this.notification_close_btn.Name = "notification_close_btn";
            this.notification_close_btn.Size = new System.Drawing.Size(112, 103);
            this.notification_close_btn.TabIndex = 9;
            this.notification_close_btn.Text = "Notifications";
            this.notification_close_btn.UseVisualStyleBackColor = false;
            // 
            // profile_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.notification_pnl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bkg_png_pnl);
            this.Name = "profile_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.Shown += new System.EventHandler(this.profile_screen_Shown);
            this.Controls.SetChildIndex(this.learning_resources_btn, 0);
            this.Controls.SetChildIndex(this.assignments_btn, 0);
            this.Controls.SetChildIndex(this.rewards_btn, 0);
            this.Controls.SetChildIndex(this.bkg_png_pnl, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.notification_pnl, 0);
            this.bkg_png_pnl.ResumeLayout(false);
            this.content_panel.ResumeLayout(false);
            this.content_panel.PerformLayout();
            this.notification_pnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bkg_png_pnl;
        private System.Windows.Forms.Panel content_panel;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel notification_pnl;
        private System.Windows.Forms.Button notification_close_btn;
        private System.Windows.Forms.Label not_logged_in_lbl;
        private System.Windows.Forms.Button login_screen_btn;
        private System.Windows.Forms.Label password_lbl;
        private System.Windows.Forms.Label username_lbl;
        private System.Windows.Forms.Label email_lbl;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label user_password_lbl;
        private System.Windows.Forms.Label user_username_lbl;
        private System.Windows.Forms.Label user_email_lbl;
        private System.Windows.Forms.Button change_username_btn;
        private System.Windows.Forms.Button change_email_btn;
        private System.Windows.Forms.Button log_out_btn;
        private System.Windows.Forms.Button change_password_btn;
        private System.Windows.Forms.Button show_password_btn;
    }
}