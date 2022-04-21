namespace Task2_Code
{
    partial class rewards_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rewards_screen));
            this.bkg_png_pnl = new System.Windows.Forms.Panel();
            this.content_panel = new System.Windows.Forms.Panel();
            this.award_lbl = new System.Windows.Forms.Label();
            this.award_message_lbl = new System.Windows.Forms.Label();
            this.percentage_lbl = new System.Windows.Forms.Label();
            this.medal_png = new System.Windows.Forms.PictureBox();
            this.reward_message_lbl = new System.Windows.Forms.Label();
            this.title_lbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.notification_pnl = new System.Windows.Forms.Panel();
            this.notification_close_btn = new System.Windows.Forms.Button();
            this.bkg_png_pnl.SuspendLayout();
            this.content_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medal_png)).BeginInit();
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
            this.bkg_png_pnl.TabIndex = 15;
            // 
            // content_panel
            // 
            this.content_panel.AutoScroll = true;
            this.content_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(212)))), ((int)(((byte)(244)))));
            this.content_panel.Controls.Add(this.award_lbl);
            this.content_panel.Controls.Add(this.award_message_lbl);
            this.content_panel.Controls.Add(this.percentage_lbl);
            this.content_panel.Controls.Add(this.medal_png);
            this.content_panel.Controls.Add(this.reward_message_lbl);
            this.content_panel.Controls.Add(this.title_lbl);
            this.content_panel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.content_panel.Location = new System.Drawing.Point(34, 29);
            this.content_panel.Name = "content_panel";
            this.content_panel.Size = new System.Drawing.Size(964, 454);
            this.content_panel.TabIndex = 0;
            // 
            // award_lbl
            // 
            this.award_lbl.AutoSize = true;
            this.award_lbl.Location = new System.Drawing.Point(170, 160);
            this.award_lbl.Name = "award_lbl";
            this.award_lbl.Size = new System.Drawing.Size(88, 19);
            this.award_lbl.TabIndex = 5;
            this.award_lbl.Text = "gold medal";
            // 
            // award_message_lbl
            // 
            this.award_message_lbl.AutoSize = true;
            this.award_message_lbl.Location = new System.Drawing.Point(26, 160);
            this.award_message_lbl.Name = "award_message_lbl";
            this.award_message_lbl.Size = new System.Drawing.Size(138, 19);
            this.award_message_lbl.TabIndex = 4;
            this.award_message_lbl.Text = "You\'re awarded a:";
            // 
            // percentage_lbl
            // 
            this.percentage_lbl.AutoSize = true;
            this.percentage_lbl.Location = new System.Drawing.Point(308, 98);
            this.percentage_lbl.Name = "percentage_lbl";
            this.percentage_lbl.Size = new System.Drawing.Size(52, 19);
            this.percentage_lbl.TabIndex = 3;
            this.percentage_lbl.Text = "100%";
            // 
            // medal_png
            // 
            this.medal_png.Location = new System.Drawing.Point(746, 36);
            this.medal_png.Name = "medal_png";
            this.medal_png.Size = new System.Drawing.Size(171, 190);
            this.medal_png.TabIndex = 2;
            this.medal_png.TabStop = false;
            // 
            // reward_message_lbl
            // 
            this.reward_message_lbl.AutoSize = true;
            this.reward_message_lbl.Location = new System.Drawing.Point(26, 98);
            this.reward_message_lbl.Name = "reward_message_lbl";
            this.reward_message_lbl.Size = new System.Drawing.Size(276, 19);
            this.reward_message_lbl.TabIndex = 1;
            this.reward_message_lbl.Text = "Your percent overall on your tests is: ";
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.Location = new System.Drawing.Point(24, 23);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(124, 35);
            this.title_lbl.TabIndex = 0;
            this.title_lbl.Text = "Rewards";
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
            this.button1.TabIndex = 16;
            this.button1.Text = "Notifications";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // notification_pnl
            // 
            this.notification_pnl.Controls.Add(this.notification_close_btn);
            this.notification_pnl.Location = new System.Drawing.Point(952, 22);
            this.notification_pnl.Name = "notification_pnl";
            this.notification_pnl.Size = new System.Drawing.Size(300, 658);
            this.notification_pnl.TabIndex = 17;
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
            // rewards_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.notification_pnl);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bkg_png_pnl);
            this.Name = "rewards_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rewards";
            this.Shown += new System.EventHandler(this.rewards_screen_Shown);
            this.Controls.SetChildIndex(this.learning_resources_btn, 0);
            this.Controls.SetChildIndex(this.assignments_btn, 0);
            this.Controls.SetChildIndex(this.rewards_btn, 0);
            this.Controls.SetChildIndex(this.bkg_png_pnl, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.notification_pnl, 0);
            this.bkg_png_pnl.ResumeLayout(false);
            this.content_panel.ResumeLayout(false);
            this.content_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.medal_png)).EndInit();
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
        private System.Windows.Forms.Label award_lbl;
        private System.Windows.Forms.Label award_message_lbl;
        private System.Windows.Forms.Label percentage_lbl;
        private System.Windows.Forms.PictureBox medal_png;
        private System.Windows.Forms.Label reward_message_lbl;
    }
}