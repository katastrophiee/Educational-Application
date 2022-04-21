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
    public partial class navigation_bar : Form
    {
        public navigation_bar()
        {
            InitializeComponent();

            if (Properties.Settings.Default.teacher)
            {
                learning_resources_btn.Text = "Teaching Resources"; //changes button text
                learning_resources_btn.Click -= learning_resources_btn_Click; //removes current function
                learning_resources_btn.Click += teaching_resources_btn_Click; //adds new one
                assignments_btn.Text = "Set an Assignment";
                assignments_btn.Click -= assignments_btn_Click;
                assignments_btn.Click += set_assignments_btn_Click;
                rewards_btn.Text = "Monitoring and Rewarding";
                rewards_btn.Click -= rewards_btn_Click;
                rewards_btn.Click += monitoring_and_rewards_btn_Click;
            }
        }

        private void home_btn_Click(object sender, EventArgs e)
        {
            this.Close(); //closes current form
            Form home_screen = new home_screen(); //creates new home screen
            home_screen.Show(); //shows it
            
        }

        private void learning_resources_btn_Click(object sender, EventArgs e)
        {
            this.Close(); //closes if not
            Form resources_screen = new learning_resources_screen(); // prepares next form
            resources_screen.Show(); // shows next form

            //repeats for the rest of the buttons
        }

        private void teaching_resources_btn_Click(object sender, EventArgs e)
        {
                this.Close();
                Form resources_screen = new teaching_resources_screen();
                resources_screen.Show();
        }

        private void assignments_btn_Click(object sender, EventArgs e)
        {
                this.Close();
                Form assignments_screen = new assignments_screen();
                assignments_screen.Show();
        }

        private void set_assignments_btn_Click(object sender, EventArgs e)
        {
                this.Close();
                Form assignments_screen = new setting_assignments_screen();
                assignments_screen.Show();
        }

        private void rewards_btn_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.logged_in)
                //checks if logged in
            {
                this.Close();
                Form rewards_screen = new rewards_screen();
                rewards_screen.Show();
                //shows if so
            }
            else
            {
                MessageBox.Show("You will have no recorded progress\nPlease make an account to access this screen");
                //error message if not
            }
        }

        private void monitoring_and_rewards_btn_Click(object sender, EventArgs e)
        {
                this.Close();
                Form rewards_screen = new monitoring_screen();
                rewards_screen.Show();
        }

        private void profile_btn_Click(object sender, EventArgs e)
        {

                this.Close();
                Form profile_screen = new profile_screen();
                profile_screen.Show();
        }

        private void accessability_btn_Click(object sender, EventArgs e)
        {
                this.Close();
                Form accessability_screen = new accessibility_screen();
                accessability_screen.Show();
        }

        private void close_btn_Click(object sender, EventArgs e)
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
            Application.Exit(); //exits the application and ends it
        }
    }
}
