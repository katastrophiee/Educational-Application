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
    public partial class accessibility_screen : navigation_bar
    {
        public accessibility_screen()
        {
            InitializeComponent();
        }

        public void dark_mode(Control myControl)
        {
            if (myControl is CheckBox || myControl is Button)
            {
                myControl.BackColor = Color.FromArgb(84, 97, 140);
                //sets checkbox to be a grey with white text
                myControl.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.FromArgb(40, 42, 55);
                // almost black
                myControl.BackColor = Color.FromArgb(40, 42, 55);
                myControl.ForeColor = Color.White;
                //sets rest to be almost black with white text
                foreach (Control subC in myControl.Controls)
                {
                    dark_mode(subC);
                    //does this for eacg component
                }
            }
        }

        private void light_mode(Control myControl)
        {
            if (myControl is Label)
            {
                myControl.BackColor = Color.Transparent;
                //clears label backgrounds
                myControl.ForeColor = Color.Black;
                //sets text black
            }
            else
            {
                this.BackColor = Color.FromArgb(184, 212, 244);
                myControl.BackColor = Color.RoyalBlue;
                //sets to normal colours
                myControl.ForeColor = Color.White;

                foreach (Control subC in myControl.Controls)
                {
                    light_mode(subC);
                    //does for every component
                }
            }
        }

        private void accessibility_screen_Shown(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.dark_mode_on == true)
                //checks if on dark mode
            {
                foreach (Control c in this.Controls)
                {
                    dark_mode(c);
                    //sets all to dark
                }
                bkg_png_pnl.BackgroundImage = Properties.Resources.night;
                //changes image
                dark_mode_check.Checked = true;
                //sets button to already be checked as dark mode is on
            }
        }

        private void dark_mode_check_CheckedChanged(object sender, EventArgs e)
        {
            if (dark_mode_check.Checked == true)
                //checks if they want dark mode
            {
                foreach (Control c in this.Controls)
                {
                    dark_mode(c);
                    //sets colours
                }
                Properties.Settings.Default.dark_mode_on = true;
                //sets dark mode to true
                Properties.Settings.Default.Save();
                //saves
                bkg_png_pnl.BackgroundImage = Properties.Resources.night;
                //changes background image to be darker
            }
            else
            //if they changed it to light mode
            {
                foreach (Control c in this.Controls)
                {
                    light_mode(c);
                }
                Properties.Settings.Default.dark_mode_on = false;
                //sets dark mode to false in the setting
                Properties.Settings.Default.Save();
                //saves
                content_panel.BackColor = Color.FromArgb(184, 212, 244);
                //sets all of the colours to what they usually are
                bkg_png_pnl.BackgroundImage = Properties.Resources.day;
            }  
        }
    }
}

