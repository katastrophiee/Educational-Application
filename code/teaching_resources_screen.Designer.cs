namespace Task2_Code
{
    partial class teaching_resources_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(teaching_resources_screen));
            this.bkg_png_pnl = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.content_panel = new System.Windows.Forms.Panel();
            this.education_level_drop_down = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.subject_drop_down = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.title_lbl = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.notification_pnl = new System.Windows.Forms.Panel();
            this.notification_close_btn = new System.Windows.Forms.Button();
            this.bkg_png_pnl.SuspendLayout();
            this.panel1.SuspendLayout();
            this.content_panel.SuspendLayout();
            this.notification_pnl.SuspendLayout();
            this.SuspendLayout();
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
            this.bkg_png_pnl.TabIndex = 18;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(212)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.panel1.Location = new System.Drawing.Point(34, 383);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 100);
            this.panel1.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Location = new System.Drawing.Point(30, 752);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(909, 301);
            this.panel2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(30, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 62);
            this.button1.TabIndex = 20;
            this.button1.Text = "Collaboration Tools";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // content_panel
            // 
            this.content_panel.AutoScroll = true;
            this.content_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(212)))), ((int)(((byte)(244)))));
            this.content_panel.Controls.Add(this.education_level_drop_down);
            this.content_panel.Controls.Add(this.label2);
            this.content_panel.Controls.Add(this.subject_drop_down);
            this.content_panel.Controls.Add(this.label1);
            this.content_panel.Controls.Add(this.panel3);
            this.content_panel.Controls.Add(this.title_lbl);
            this.content_panel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.content_panel.Location = new System.Drawing.Point(34, 29);
            this.content_panel.Name = "content_panel";
            this.content_panel.Size = new System.Drawing.Size(964, 356);
            this.content_panel.TabIndex = 1;
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
            this.education_level_drop_down.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 35);
            this.label2.TabIndex = 20;
            this.label2.Text = "Education Level:";
            // 
            // subject_drop_down
            // 
            this.subject_drop_down.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.subject_drop_down.FormattingEnabled = true;
            this.subject_drop_down.Location = new System.Drawing.Point(632, 103);
            this.subject_drop_down.Name = "subject_drop_down";
            this.subject_drop_down.Size = new System.Drawing.Size(208, 27);
            this.subject_drop_down.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(507, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 35);
            this.label1.TabIndex = 19;
            this.label1.Text = "Subject:";
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
            this.title_lbl.Size = new System.Drawing.Size(268, 35);
            this.title_lbl.TabIndex = 0;
            this.title_lbl.Text = "Teaching Resources";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Tahoma", 12F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1140, 22);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 103);
            this.button3.TabIndex = 19;
            this.button3.Text = "Notifications";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // notification_pnl
            // 
            this.notification_pnl.Controls.Add(this.notification_close_btn);
            this.notification_pnl.Location = new System.Drawing.Point(952, 22);
            this.notification_pnl.Name = "notification_pnl";
            this.notification_pnl.Size = new System.Drawing.Size(300, 658);
            this.notification_pnl.TabIndex = 20;
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
            // teaching_resources_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.notification_pnl);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bkg_png_pnl);
            this.Name = "teaching_resources_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "teaching_resources_screen";
            this.Shown += new System.EventHandler(this.teaching_resources_screen_Shown);
            this.Controls.SetChildIndex(this.bkg_png_pnl, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.notification_pnl, 0);
            this.Controls.SetChildIndex(this.learning_resources_btn, 0);
            this.Controls.SetChildIndex(this.assignments_btn, 0);
            this.Controls.SetChildIndex(this.rewards_btn, 0);
            this.bkg_png_pnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.content_panel.ResumeLayout(false);
            this.content_panel.PerformLayout();
            this.notification_pnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bkg_png_pnl;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel notification_pnl;
        private System.Windows.Forms.Button notification_close_btn;
        private System.Windows.Forms.Panel content_panel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox education_level_drop_down;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox subject_drop_down;
        private System.Windows.Forms.Label label1;
    }
}