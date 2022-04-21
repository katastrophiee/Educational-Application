namespace Task2_Code
{
    partial class accessibility_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(accessibility_screen));
            this.bkg_png_pnl = new System.Windows.Forms.Panel();
            this.content_panel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.title_lbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.notification_pnl = new System.Windows.Forms.Panel();
            this.notification_close_btn = new System.Windows.Forms.Button();
            this.dark_mode_check = new System.Windows.Forms.CheckBox();
            this.message = new System.Windows.Forms.Label();
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
            this.bkg_png_pnl.TabIndex = 14;
            // 
            // content_panel
            // 
            this.content_panel.AutoScroll = true;
            this.content_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(212)))), ((int)(((byte)(244)))));
            this.content_panel.Controls.Add(this.message);
            this.content_panel.Controls.Add(this.dark_mode_check);
            this.content_panel.Controls.Add(this.panel3);
            this.content_panel.Controls.Add(this.title_lbl);
            this.content_panel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.content_panel.Location = new System.Drawing.Point(34, 29);
            this.content_panel.Name = "content_panel";
            this.content_panel.Size = new System.Drawing.Size(964, 454);
            this.content_panel.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AliceBlue;
            this.panel3.Location = new System.Drawing.Point(30, 752);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(909, 301);
            this.panel3.TabIndex = 3;
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.Location = new System.Drawing.Point(24, 23);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(167, 35);
            this.title_lbl.TabIndex = 0;
            this.title_lbl.Text = "Accessibility";
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
            this.button1.TabIndex = 11;
            this.button1.Text = "Notifications";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // notification_pnl
            // 
            this.notification_pnl.Controls.Add(this.notification_close_btn);
            this.notification_pnl.Location = new System.Drawing.Point(952, 22);
            this.notification_pnl.Name = "notification_pnl";
            this.notification_pnl.Size = new System.Drawing.Size(300, 658);
            this.notification_pnl.TabIndex = 16;
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
            // dark_mode_check
            // 
            this.dark_mode_check.Appearance = System.Windows.Forms.Appearance.Button;
            this.dark_mode_check.AutoSize = true;
            this.dark_mode_check.BackColor = System.Drawing.Color.RoyalBlue;
            this.dark_mode_check.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dark_mode_check.Font = new System.Drawing.Font("Tahoma", 21.75F);
            this.dark_mode_check.ForeColor = System.Drawing.Color.White;
            this.dark_mode_check.Location = new System.Drawing.Point(72, 106);
            this.dark_mode_check.Name = "dark_mode_check";
            this.dark_mode_check.Size = new System.Drawing.Size(162, 45);
            this.dark_mode_check.TabIndex = 5;
            this.dark_mode_check.Text = "Dark Mode";
            this.dark_mode_check.UseVisualStyleBackColor = false;
            this.dark_mode_check.CheckedChanged += new System.EventHandler(this.dark_mode_check_CheckedChanged);
            // 
            // message
            // 
            this.message.AutoSize = true;
            this.message.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.Location = new System.Drawing.Point(288, 343);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(371, 35);
            this.message.TabIndex = 6;
            this.message.Text = "More features coming soon!";
            // 
            // accessibility_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.notification_pnl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bkg_png_pnl);
            this.Name = "accessibility_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accessability Screen";
            this.Shown += new System.EventHandler(this.accessibility_screen_Shown);
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
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel notification_pnl;
        private System.Windows.Forms.Button notification_close_btn;
        private System.Windows.Forms.Label message;
        private System.Windows.Forms.CheckBox dark_mode_check;
    }
}