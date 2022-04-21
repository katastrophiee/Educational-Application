namespace Task2_Code
{
    partial class learning_resources_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(learning_resources_screen));
            this.notification_close_btn = new System.Windows.Forms.Button();
            this.bkg_png_pnl = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.collaboration_student_btn = new System.Windows.Forms.Button();
            this.games_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.content_panel = new System.Windows.Forms.Panel();
            this.close_topic_btn = new System.Windows.Forms.Button();
            this.subjects_pnl = new System.Windows.Forms.Panel();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.education_level_drop_down = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.subject_drop_down = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.title_lbl = new System.Windows.Forms.Label();
            this.notification_pnl = new System.Windows.Forms.Panel();
            this.notifications_btn = new System.Windows.Forms.Button();
            this.topic_pnl = new System.Windows.Forms.Panel();
            this.bkg_png_pnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.content_panel.SuspendLayout();
            this.subjects_pnl.SuspendLayout();
            this.notification_pnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // notification_close_btn
            // 
            this.notification_close_btn.BackColor = System.Drawing.Color.RoyalBlue;
            this.notification_close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.notification_close_btn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.notification_close_btn.ForeColor = System.Drawing.Color.White;
            this.notification_close_btn.Location = new System.Drawing.Point(1140, 22);
            this.notification_close_btn.Name = "notification_close_btn";
            this.notification_close_btn.Size = new System.Drawing.Size(112, 103);
            this.notification_close_btn.TabIndex = 14;
            this.notification_close_btn.Text = "Notifications";
            this.notification_close_btn.UseVisualStyleBackColor = false;
            // 
            // bkg_png_pnl
            // 
            this.bkg_png_pnl.BackColor = System.Drawing.Color.AliceBlue;
            this.bkg_png_pnl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bkg_png_pnl.BackgroundImage")));
            this.bkg_png_pnl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bkg_png_pnl.Controls.Add(this.panel1);
            this.bkg_png_pnl.Controls.Add(this.content_panel);
            this.bkg_png_pnl.Location = new System.Drawing.Point(12, 159);
            this.bkg_png_pnl.Name = "bkg_png_pnl";
            this.bkg_png_pnl.Size = new System.Drawing.Size(1240, 510);
            this.bkg_png_pnl.TabIndex = 15;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(212)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.collaboration_student_btn);
            this.panel1.Controls.Add(this.games_btn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.panel1.Location = new System.Drawing.Point(34, 383);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 100);
            this.panel1.TabIndex = 19;
            // 
            // collaboration_student_btn
            // 
            this.collaboration_student_btn.BackColor = System.Drawing.Color.RoyalBlue;
            this.collaboration_student_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.collaboration_student_btn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.collaboration_student_btn.ForeColor = System.Drawing.Color.White;
            this.collaboration_student_btn.Location = new System.Drawing.Point(166, 23);
            this.collaboration_student_btn.Name = "collaboration_student_btn";
            this.collaboration_student_btn.Size = new System.Drawing.Size(112, 62);
            this.collaboration_student_btn.TabIndex = 20;
            this.collaboration_student_btn.Text = "Collaboration Tools";
            this.collaboration_student_btn.UseVisualStyleBackColor = false;
            this.collaboration_student_btn.Click += new System.EventHandler(this.collaboration_student_btn_Click);
            // 
            // games_btn
            // 
            this.games_btn.BackColor = System.Drawing.Color.RoyalBlue;
            this.games_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.games_btn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.games_btn.ForeColor = System.Drawing.Color.White;
            this.games_btn.Location = new System.Drawing.Point(30, 23);
            this.games_btn.Name = "games_btn";
            this.games_btn.Size = new System.Drawing.Size(112, 62);
            this.games_btn.TabIndex = 19;
            this.games_btn.Text = "Games";
            this.games_btn.UseVisualStyleBackColor = false;
            this.games_btn.Click += new System.EventHandler(this.games_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Location = new System.Drawing.Point(30, 752);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(909, 301);
            this.panel2.TabIndex = 3;
            // 
            // content_panel
            // 
            this.content_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(212)))), ((int)(((byte)(244)))));
            this.content_panel.Controls.Add(this.close_topic_btn);
            this.content_panel.Controls.Add(this.subjects_pnl);
            this.content_panel.Controls.Add(this.education_level_drop_down);
            this.content_panel.Controls.Add(this.label2);
            this.content_panel.Controls.Add(this.subject_drop_down);
            this.content_panel.Controls.Add(this.panel3);
            this.content_panel.Controls.Add(this.label1);
            this.content_panel.Controls.Add(this.title_lbl);
            this.content_panel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.content_panel.Location = new System.Drawing.Point(34, 29);
            this.content_panel.Name = "content_panel";
            this.content_panel.Size = new System.Drawing.Size(964, 355);
            this.content_panel.TabIndex = 0;
            // 
            // close_topic_btn
            // 
            this.close_topic_btn.BackColor = System.Drawing.Color.RoyalBlue;
            this.close_topic_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.close_topic_btn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.close_topic_btn.ForeColor = System.Drawing.Color.White;
            this.close_topic_btn.Location = new System.Drawing.Point(886, 75);
            this.close_topic_btn.Name = "close_topic_btn";
            this.close_topic_btn.Size = new System.Drawing.Size(63, 63);
            this.close_topic_btn.TabIndex = 10;
            this.close_topic_btn.Text = "Close";
            this.close_topic_btn.UseVisualStyleBackColor = false;
            this.close_topic_btn.Visible = false;
            this.close_topic_btn.Click += new System.EventHandler(this.close_topic_btn_Click);
            // 
            // subjects_pnl
            // 
            this.subjects_pnl.AutoScroll = true;
            this.subjects_pnl.Controls.Add(this.button12);
            this.subjects_pnl.Controls.Add(this.button11);
            this.subjects_pnl.Controls.Add(this.button10);
            this.subjects_pnl.Controls.Add(this.button9);
            this.subjects_pnl.Controls.Add(this.button8);
            this.subjects_pnl.Controls.Add(this.button7);
            this.subjects_pnl.Controls.Add(this.button6);
            this.subjects_pnl.Controls.Add(this.button5);
            this.subjects_pnl.Controls.Add(this.button4);
            this.subjects_pnl.Controls.Add(this.button3);
            this.subjects_pnl.Controls.Add(this.button2);
            this.subjects_pnl.Controls.Add(this.button1);
            this.subjects_pnl.Location = new System.Drawing.Point(0, 151);
            this.subjects_pnl.Name = "subjects_pnl";
            this.subjects_pnl.Size = new System.Drawing.Size(964, 204);
            this.subjects_pnl.TabIndex = 19;
            this.subjects_pnl.Visible = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.RoyalBlue;
            this.button12.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button12.ForeColor = System.Drawing.Color.White;
            this.button12.Location = new System.Drawing.Point(757, 348);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(182, 131);
            this.button12.TabIndex = 13;
            this.button12.Text = "Not Functioning";
            this.button12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Visible = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.RoyalBlue;
            this.button11.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button11.ForeColor = System.Drawing.Color.White;
            this.button11.Location = new System.Drawing.Point(515, 348);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(182, 131);
            this.button11.TabIndex = 12;
            this.button11.Text = "Not Functioning";
            this.button11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Visible = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.RoyalBlue;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button10.ForeColor = System.Drawing.Color.White;
            this.button10.Location = new System.Drawing.Point(273, 348);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(182, 131);
            this.button10.TabIndex = 11;
            this.button10.Text = "Not Functioning";
            this.button10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Visible = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.RoyalBlue;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button9.ForeColor = System.Drawing.Color.White;
            this.button9.Location = new System.Drawing.Point(31, 348);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(182, 131);
            this.button9.TabIndex = 10;
            this.button9.Text = "Not Functioning";
            this.button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Visible = false;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.RoyalBlue;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button8.ForeColor = System.Drawing.Color.White;
            this.button8.Location = new System.Drawing.Point(757, 186);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(182, 131);
            this.button8.TabIndex = 9;
            this.button8.Text = "Not Functioning";
            this.button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Visible = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.RoyalBlue;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(515, 186);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(182, 131);
            this.button7.TabIndex = 8;
            this.button7.Text = "Not Functioning";
            this.button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Visible = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.RoyalBlue;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(273, 186);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(182, 131);
            this.button6.TabIndex = 7;
            this.button6.Text = "Not Functioning";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Visible = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.RoyalBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(31, 186);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(182, 131);
            this.button5.TabIndex = 6;
            this.button5.Text = "Not Functioning";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Visible = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.RoyalBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(757, 24);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(182, 131);
            this.button4.TabIndex = 5;
            this.button4.Text = "Not Functioning";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(515, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 131);
            this.button3.TabIndex = 4;
            this.button3.Text = "Not Functioning";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(273, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(182, 131);
            this.button2.TabIndex = 3;
            this.button2.Text = "Not Functioning";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(30, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 131);
            this.button1.TabIndex = 1;
            this.button1.Text = "Not Functioning";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            // 
            // education_level_drop_down
            // 
            this.education_level_drop_down.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.education_level_drop_down.FormattingEnabled = true;
            this.education_level_drop_down.Items.AddRange(new object[] {
            "Primary",
            "Secondary",
            "Higher Education"});
            this.education_level_drop_down.Location = new System.Drawing.Point(254, 109);
            this.education_level_drop_down.Name = "education_level_drop_down";
            this.education_level_drop_down.Size = new System.Drawing.Size(208, 27);
            this.education_level_drop_down.TabIndex = 18;
            this.education_level_drop_down.SelectedIndexChanged += new System.EventHandler(this.education_level_drop_down_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "Education Level:";
            // 
            // subject_drop_down
            // 
            this.subject_drop_down.DropDownHeight = 90;
            this.subject_drop_down.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.subject_drop_down.FormattingEnabled = true;
            this.subject_drop_down.IntegralHeight = false;
            this.subject_drop_down.Items.AddRange(new object[] {
            "Subject",
            "Subject",
            "Subject",
            "Subject"});
            this.subject_drop_down.Location = new System.Drawing.Point(632, 103);
            this.subject_drop_down.Name = "subject_drop_down";
            this.subject_drop_down.Size = new System.Drawing.Size(208, 27);
            this.subject_drop_down.TabIndex = 17;
            this.subject_drop_down.SelectedIndexChanged += new System.EventHandler(this.subject_drop_down_SelectedIndexChanged);
            this.subject_drop_down.Click += new System.EventHandler(this.subject_drop_down_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AliceBlue;
            this.panel3.Location = new System.Drawing.Point(30, 752);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(909, 301);
            this.panel3.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(507, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "Subject:";
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.Location = new System.Drawing.Point(24, 23);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(262, 35);
            this.title_lbl.TabIndex = 0;
            this.title_lbl.Text = "Learning Resources";
            // 
            // notification_pnl
            // 
            this.notification_pnl.Controls.Add(this.notifications_btn);
            this.notification_pnl.Location = new System.Drawing.Point(952, 22);
            this.notification_pnl.Name = "notification_pnl";
            this.notification_pnl.Size = new System.Drawing.Size(300, 658);
            this.notification_pnl.TabIndex = 16;
            this.notification_pnl.Visible = false;
            // 
            // notifications_btn
            // 
            this.notifications_btn.BackColor = System.Drawing.Color.RoyalBlue;
            this.notifications_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.notifications_btn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.notifications_btn.ForeColor = System.Drawing.Color.White;
            this.notifications_btn.Location = new System.Drawing.Point(0, 0);
            this.notifications_btn.Name = "notifications_btn";
            this.notifications_btn.Size = new System.Drawing.Size(112, 103);
            this.notifications_btn.TabIndex = 9;
            this.notifications_btn.Text = "Notifications";
            this.notifications_btn.UseVisualStyleBackColor = false;
            // 
            // topic_pnl
            // 
            this.topic_pnl.AutoScroll = true;
            this.topic_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(212)))), ((int)(((byte)(244)))));
            this.topic_pnl.Location = new System.Drawing.Point(47, 339);
            this.topic_pnl.Name = "topic_pnl";
            this.topic_pnl.Size = new System.Drawing.Size(964, 204);
            this.topic_pnl.TabIndex = 20;
            this.topic_pnl.Visible = false;
            // 
            // learning_resources_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.notification_pnl);
            this.Controls.Add(this.topic_pnl);
            this.Controls.Add(this.bkg_png_pnl);
            this.Controls.Add(this.notification_close_btn);
            this.Name = "learning_resources_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Learning Resources";
            this.Shown += new System.EventHandler(this.learning_resources_screen_Shown);
            this.Controls.SetChildIndex(this.notification_close_btn, 0);
            this.Controls.SetChildIndex(this.bkg_png_pnl, 0);
            this.Controls.SetChildIndex(this.topic_pnl, 0);
            this.Controls.SetChildIndex(this.learning_resources_btn, 0);
            this.Controls.SetChildIndex(this.assignments_btn, 0);
            this.Controls.SetChildIndex(this.rewards_btn, 0);
            this.Controls.SetChildIndex(this.notification_pnl, 0);
            this.bkg_png_pnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.content_panel.ResumeLayout(false);
            this.content_panel.PerformLayout();
            this.subjects_pnl.ResumeLayout(false);
            this.notification_pnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button notification_close_btn;
        private System.Windows.Forms.Panel bkg_png_pnl;
        private System.Windows.Forms.Panel content_panel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Panel notification_pnl;
        private System.Windows.Forms.Button notifications_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox education_level_drop_down;
        private System.Windows.Forms.ComboBox subject_drop_down;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button collaboration_student_btn;
        private System.Windows.Forms.Button games_btn;
        private System.Windows.Forms.Panel subjects_pnl;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel topic_pnl;
        private System.Windows.Forms.Button close_topic_btn;
    }
}