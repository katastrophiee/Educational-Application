using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task2_Code
{
    public partial class home_screen : navigation_bar
    {
        private int start = 1140;
        private int end = 952;
        private int step = 5;
        public home_screen()
        {
            InitializeComponent();
            if (Properties.Settings.Default.logged_in == true && Properties.Settings.Default.name != "")
            {
                welcome_message_lbl.Text = "Welcome " + Properties.Settings.Default.name + "!";
            }
        }

        private void notification_btn_Click(object sender, EventArgs e)
        {
            animate_out.Enabled = true;
        }

        private void animate_out_Tick(object sender, EventArgs e)
        {
            

            // if just starting, move to start location and make visible
            if (!notification_pnl.Visible)
            {
                notification_pnl.Left = start;
                notification_pnl.Visible = true;
            }

            // incrementally move
            notification_pnl.Left -= step;
            // make sure we didn't over shoot
            if (notification_pnl.Left < end) notification_pnl.Left = end;

            // have we arrived?
            if (notification_pnl.Left == end)
            {
                animate_out.Enabled = false;
            }
        }

        private void animate_in_Tick(object sender, EventArgs e)
        {
            // if just starting, move to start location and make visible
            if (!notification_pnl.Visible)
            {
                notification_pnl.Left = end;
                notification_pnl.Visible = true;
            }

            // incrementally move
            notification_pnl.Left += step;
            // make sure we didn't over shoot
            if (notification_pnl.Left > start) notification_pnl.Left = start;

            // have we arrived?
            if (notification_pnl.Left == start)
            {
                animate_in.Enabled = false;
                notification_pnl.Visible = false;
            }
        }

        private void notification_close_btn_Click(object sender, EventArgs e)
        {
            animate_in.Enabled = true;
        }

        public void dark_mode(Control myControl)
        {
            if (myControl is Button)
            {
                myControl.BackColor = Color.FromArgb(84, 97, 140);
                myControl.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.FromArgb(40, 42, 55);
                myControl.BackColor = Color.FromArgb(40, 42, 55);
                myControl.ForeColor = Color.White;
                foreach (Control subC in myControl.Controls)
                {
                    dark_mode(subC);
                }
            }
        }

        private void home_screen_Shown(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.dark_mode_on == true)
            {
                foreach (Control c in this.Controls)
                {
                    dark_mode(c);
                }
                bkg_png_pnl.BackgroundImage = Properties.Resources.night;
            }
        }
    }
}
