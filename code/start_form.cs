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
    public partial class start_form : Form
    {
        public start_form()
        {
            InitializeComponent();
            this.Closed += (s, args) => reset_details();
            //runs subroutine when this form is closed
        }

        private void start_form_Shown(object sender, EventArgs e)
        {
            this.Hide(); //hides itself
            Form home_screen = new home_screen();
            home_screen.Show(); // starts the homes screen
        }

        private void reset_details()
        {
            if (Properties.Settings.Default.remembered == false)
            {
                Properties.Settings.Default.name = "";
                Properties.Settings.Default.username = "";
                Properties.Settings.Default.password = "";
                Properties.Settings.Default.email = "";
                // clears all of the details saved and sets to default
                Properties.Settings.Default.teacher = false;
                Properties.Settings.Default.logged_in = false;
                Properties.Settings.Default.Save();
            }
        }

    }
}
