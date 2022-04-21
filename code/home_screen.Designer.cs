namespace Task2_Code
{
    partial class home_screen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home_screen));
            this.bkg_png_pnl = new System.Windows.Forms.Panel();
            this.content_panel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.welcome_message_lbl = new System.Windows.Forms.Label();
            this.notification_pnl = new System.Windows.Forms.Panel();
            this.notification_close_btn = new System.Windows.Forms.Button();
            this.notification_btn = new System.Windows.Forms.Button();
            this.animate_out = new System.Windows.Forms.Timer(this.components);
            this.animate_in = new System.Windows.Forms.Timer(this.components);
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
            this.content_panel.Controls.Add(this.panel3);
            this.content_panel.Controls.Add(this.panel2);
            this.content_panel.Controls.Add(this.panel1);
            this.content_panel.Controls.Add(this.welcome_message_lbl);
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Location = new System.Drawing.Point(30, 416);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(909, 301);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Location = new System.Drawing.Point(30, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 301);
            this.panel1.TabIndex = 1;
            // 
            // welcome_message_lbl
            // 
            this.welcome_message_lbl.AutoSize = true;
            this.welcome_message_lbl.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome_message_lbl.Location = new System.Drawing.Point(24, 23);
            this.welcome_message_lbl.Name = "welcome_message_lbl";
            this.welcome_message_lbl.Size = new System.Drawing.Size(141, 35);
            this.welcome_message_lbl.TabIndex = 0;
            this.welcome_message_lbl.Text = "Welcome!";
            // 
            // notification_pnl
            // 
            this.notification_pnl.Controls.Add(this.notification_close_btn);
            this.notification_pnl.Location = new System.Drawing.Point(952, 22);
            this.notification_pnl.Name = "notification_pnl";
            this.notification_pnl.Size = new System.Drawing.Size(300, 658);
            this.notification_pnl.TabIndex = 15;
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
            this.notification_close_btn.Click += new System.EventHandler(this.notification_close_btn_Click);
            // 
            // notification_btn
            // 
            this.notification_btn.BackColor = System.Drawing.Color.RoyalBlue;
            this.notification_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.notification_btn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.notification_btn.ForeColor = System.Drawing.Color.White;
            this.notification_btn.Location = new System.Drawing.Point(1140, 22);
            this.notification_btn.Name = "notification_btn";
            this.notification_btn.Size = new System.Drawing.Size(112, 103);
            this.notification_btn.TabIndex = 10;
            this.notification_btn.Text = "Notifications";
            this.notification_btn.UseVisualStyleBackColor = false;
            this.notification_btn.Click += new System.EventHandler(this.notification_btn_Click);
            // 
            // animate_out
            // 
            this.animate_out.Interval = 5;
            this.animate_out.Tick += new System.EventHandler(this.animate_out_Tick);
            // 
            // animate_in
            // 
            this.animate_in.Interval = 5;
            this.animate_in.Tick += new System.EventHandler(this.animate_in_Tick);
            // 
            // home_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.notification_pnl);
            this.Controls.Add(this.bkg_png_pnl);
            this.Controls.Add(this.notification_btn);
            this.Name = "home_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home Screen";
            this.Shown += new System.EventHandler(this.home_screen_Shown);
            this.Controls.SetChildIndex(this.learning_resources_btn, 0);
            this.Controls.SetChildIndex(this.assignments_btn, 0);
            this.Controls.SetChildIndex(this.rewards_btn, 0);
            this.Controls.SetChildIndex(this.notification_btn, 0);
            this.Controls.SetChildIndex(this.bkg_png_pnl, 0);
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
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel notification_pnl;
        private System.Windows.Forms.Button notification_close_btn;
        private System.Windows.Forms.Button notification_btn;
        public System.Windows.Forms.Label welcome_message_lbl;
        private System.Windows.Forms.Timer animate_out;
        private System.Windows.Forms.Timer animate_in;
    }
}

