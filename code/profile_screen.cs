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
    public partial class profile_screen : navigation_bar
    {
        public bool shown = false;
        public profile_screen()
        {
            InitializeComponent();
            if (Properties.Settings.Default.logged_in == true)
            {
                not_logged_in_lbl.Visible = false; //hides irrelavent buttons
                login_screen_btn.Visible = false;
                user_email_lbl.Text = Properties.Settings.Default.email;
                user_password_lbl.Text = "********"; //sets details if logged in
                user_username_lbl.Text = Properties.Settings.Default.username;
                name_lbl.Text = Properties.Settings.Default.name;


            }
            else
            {
                user_email_lbl.Visible = false;
                user_password_lbl.Visible = false;
                user_username_lbl.Visible = false;
                name_lbl.Visible = false;
                username_lbl.Visible = false;
                password_lbl.Visible = false; //hides all the unneccessary buttons if not logged in
                email_lbl.Visible = false;
                log_out_btn.Visible = false;
                change_email_btn.Visible = false;
                change_password_btn.Visible = false;
                change_username_btn.Visible = false;
                log_out_btn.Visible = false;
                show_password_btn.Visible = false;
            }
        }

        private void login_screen_btn_Click(object sender, EventArgs e)
        {
            this.Close(); //closes current screen
            Form login_screen = new login_screen();
            login_screen.Show(); //creates and shows next screen
        }

        private void show_password_btn_Click(object sender, EventArgs e)
        {
            shown = !shown; //inverts the value, true becomes false
            if (shown == true)
            {
                user_password_lbl.Text = Properties.Settings.Default.password;
                //sets the text to be the password
            }
            else
            {
                user_password_lbl.Text = "********";
                //sets it to be hidden if not shown
            }
        }



        private void log_out_btn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.username = "";
            Properties.Settings.Default.name = "";
            Properties.Settings.Default.password = "";
            Properties.Settings.Default.email = ""; //clears all the values saved
            Properties.Settings.Default.logged_in = false;
            Properties.Settings.Default.teacher = false; // sets false as no account
            Properties.Settings.Default.remembered = false;
            Properties.Settings.Default.Save();
            MessageBox.Show("Logged out."); //shows appropriate message box
            this.Close();
            Form home_screen = new home_screen();
            home_screen.Show();
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

        private void profile_screen_Shown(object sender, EventArgs e)
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
