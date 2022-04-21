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
    public partial class teaching_resources_screen : navigation_bar
    {
        public teaching_resources_screen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form collaborative_teaching_screen = new collaboration_teacher_screen();
            collaborative_teaching_screen.Show();
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

        private void teaching_resources_screen_Shown(object sender, EventArgs e)
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
