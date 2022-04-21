
namespace Task2_Code
{
    partial class monitoring_screen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(monitoring_screen));
            this.bkg_png_pnl = new System.Windows.Forms.Panel();
            this.classes_pnl = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.create_class_btn = new System.Windows.Forms.Button();
            this.reward_btn = new System.Windows.Forms.Button();
            this.all_students_btn = new System.Windows.Forms.Button();
            this.classes_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.title_lbl = new System.Windows.Forms.Label();
            this.content_panel = new System.Windows.Forms.Panel();
            this.button_title_lbl = new System.Windows.Forms.Label();
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
            this.bkg_png_pnl.Controls.Add(this.classes_pnl);
            this.bkg_png_pnl.Controls.Add(this.panel1);
            this.bkg_png_pnl.Controls.Add(this.content_panel);
            this.bkg_png_pnl.Location = new System.Drawing.Point(12, 159);
            this.bkg_png_pnl.Name = "bkg_png_pnl";
            this.bkg_png_pnl.Size = new System.Drawing.Size(1240, 510);
            this.bkg_png_pnl.TabIndex = 17;
            // 
            // classes_pnl
            // 
            this.classes_pnl.AutoScroll = true;
            this.classes_pnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(212)))), ((int)(((byte)(244)))));
            this.classes_pnl.Location = new System.Drawing.Point(34, 271);
            this.classes_pnl.Name = "classes_pnl";
            this.classes_pnl.Size = new System.Drawing.Size(964, 212);
            this.classes_pnl.TabIndex = 22;
            this.classes_pnl.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(212)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.create_class_btn);
            this.panel1.Controls.Add(this.reward_btn);
            this.panel1.Controls.Add(this.all_students_btn);
            this.panel1.Controls.Add(this.classes_btn);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.title_lbl);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.panel1.Location = new System.Drawing.Point(34, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 153);
            this.panel1.TabIndex = 1;
            // 
            // create_class_btn
            // 
            this.create_class_btn.BackColor = System.Drawing.Color.RoyalBlue;
            this.create_class_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.create_class_btn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.create_class_btn.ForeColor = System.Drawing.Color.White;
            this.create_class_btn.Location = new System.Drawing.Point(432, 67);
            this.create_class_btn.Name = "create_class_btn";
            this.create_class_btn.Size = new System.Drawing.Size(112, 62);
            this.create_class_btn.TabIndex = 20;
            this.create_class_btn.Text = "Create a class";
            this.create_class_btn.UseVisualStyleBackColor = false;
            this.create_class_btn.Click += new System.EventHandler(this.create_class_btn_Click);
            // 
            // reward_btn
            // 
            this.reward_btn.BackColor = System.Drawing.Color.RoyalBlue;
            this.reward_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reward_btn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.reward_btn.ForeColor = System.Drawing.Color.White;
            this.reward_btn.Location = new System.Drawing.Point(298, 67);
            this.reward_btn.Name = "reward_btn";
            this.reward_btn.Size = new System.Drawing.Size(112, 62);
            this.reward_btn.TabIndex = 19;
            this.reward_btn.Text = "Give a Reward";
            this.reward_btn.UseVisualStyleBackColor = false;
            this.reward_btn.Click += new System.EventHandler(this.reward_btn_Click);
            // 
            // all_students_btn
            // 
            this.all_students_btn.BackColor = System.Drawing.Color.RoyalBlue;
            this.all_students_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.all_students_btn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.all_students_btn.ForeColor = System.Drawing.Color.White;
            this.all_students_btn.Location = new System.Drawing.Point(164, 67);
            this.all_students_btn.Name = "all_students_btn";
            this.all_students_btn.Size = new System.Drawing.Size(112, 62);
            this.all_students_btn.TabIndex = 18;
            this.all_students_btn.Text = "All Students";
            this.all_students_btn.UseVisualStyleBackColor = false;
            this.all_students_btn.Click += new System.EventHandler(this.students_btn_Click);
            // 
            // classes_btn
            // 
            this.classes_btn.BackColor = System.Drawing.Color.RoyalBlue;
            this.classes_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.classes_btn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.classes_btn.ForeColor = System.Drawing.Color.White;
            this.classes_btn.Location = new System.Drawing.Point(30, 67);
            this.classes_btn.Name = "classes_btn";
            this.classes_btn.Size = new System.Drawing.Size(112, 62);
            this.classes_btn.TabIndex = 17;
            this.classes_btn.Text = "Classes";
            this.classes_btn.UseVisualStyleBackColor = false;
            this.classes_btn.Click += new System.EventHandler(this.classes_btn_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Location = new System.Drawing.Point(30, 752);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(909, 301);
            this.panel2.TabIndex = 3;
            // 
            // title_lbl
            // 
            this.title_lbl.AutoSize = true;
            this.title_lbl.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title_lbl.Location = new System.Drawing.Point(24, 14);
            this.title_lbl.Name = "title_lbl";
            this.title_lbl.Size = new System.Drawing.Size(325, 35);
            this.title_lbl.TabIndex = 0;
            this.title_lbl.Text = "Monitoring and Rewards";
            // 
            // content_panel
            // 
            this.content_panel.AutoScroll = true;
            this.content_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(212)))), ((int)(((byte)(244)))));
            this.content_panel.Controls.Add(this.button_title_lbl);
            this.content_panel.Font = new System.Drawing.Font("Tahoma", 12F);
            this.content_panel.Location = new System.Drawing.Point(34, 215);
            this.content_panel.Name = "content_panel";
            this.content_panel.Size = new System.Drawing.Size(964, 268);
            this.content_panel.TabIndex = 0;
            // 
            // button_title_lbl
            // 
            this.button_title_lbl.AutoSize = true;
            this.button_title_lbl.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_title_lbl.Location = new System.Drawing.Point(24, 18);
            this.button_title_lbl.Name = "button_title_lbl";
            this.button_title_lbl.Size = new System.Drawing.Size(161, 35);
            this.button_title_lbl.TabIndex = 21;
            this.button_title_lbl.Text = "Placeholder";
            this.button_title_lbl.Visible = false;
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
            this.button3.TabIndex = 18;
            this.button3.Text = "Notifications";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // notification_pnl
            // 
            this.notification_pnl.Controls.Add(this.notification_close_btn);
            this.notification_pnl.Location = new System.Drawing.Point(952, 22);
            this.notification_pnl.Name = "notification_pnl";
            this.notification_pnl.Size = new System.Drawing.Size(300, 658);
            this.notification_pnl.TabIndex = 19;
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
            // monitoring_screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.notification_pnl);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bkg_png_pnl);
            this.Name = "monitoring_screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitoring";
            this.Shown += new System.EventHandler(this.monitoring_screen_Shown);
            this.Controls.SetChildIndex(this.learning_resources_btn, 0);
            this.Controls.SetChildIndex(this.assignments_btn, 0);
            this.Controls.SetChildIndex(this.rewards_btn, 0);
            this.Controls.SetChildIndex(this.bkg_png_pnl, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.notification_pnl, 0);
            this.bkg_png_pnl.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.content_panel.ResumeLayout(false);
            this.content_panel.PerformLayout();
            this.notification_pnl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bkg_png_pnl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button create_class_btn;
        private System.Windows.Forms.Button reward_btn;
        private System.Windows.Forms.Button all_students_btn;
        private System.Windows.Forms.Button classes_btn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label title_lbl;
        private System.Windows.Forms.Panel content_panel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel notification_pnl;
        private System.Windows.Forms.Button notification_close_btn;
        private System.Windows.Forms.Label button_title_lbl;
        private System.Windows.Forms.Panel classes_pnl;
    }
}