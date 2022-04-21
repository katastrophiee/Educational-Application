using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Task2_Code
{
    public partial class rewards_screen : navigation_bar
    {
        public rewards_screen()
        {
            InitializeComponent();
        }

        private int get_average()
        {
            account_creation_screen account_creation = new account_creation_screen();
            MySqlConnection db = account_creation.connect_to_db(); // uses connection subroutine from previous form
            account_creation.Close(); //closes one got

            string command = "SELECT score FROM tests WHERE studentUsername=@username";
            //gets all the scores using the username matching the one stored
            List<int> score = new List<int>();
            //initialises list of scores
            int average = 0;
            //initialises average

            using (db)
            {
                MySqlCommand find_user = new MySqlCommand(command, db);
                find_user.Parameters.Add("@username", MySqlDbType.VarChar);
                find_user.Parameters["@username"].Value = Properties.Settings.Default.username;
                //adds peramaters

                try
                {
                    db.Open();
                    //opens database
                    MySqlDataReader myDataReader = find_user.ExecuteReader();
                    while (myDataReader.Read())
                        //does while theres data to read
                    {
                        int test_score = myDataReader.GetInt32(0);
                        score.Add(test_score);
                        //adds score to list
                    }
                    try
                    {
                        average = (int)score.Average();
                    }
                    catch (Exception e)
                    {
                        if (e.GetType().IsAssignableFrom(typeof(System.InvalidOperationException)))
                        {
                            MessageBox.Show("You have no data so your score is 0!\nPlay some games to get some medals!");
                        }
                    }
                    //calculates the average of the list
                    myDataReader.Close();
                    db.Close();
                    //closes
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    //error message
                }
            }
            return average;
            //returns the average
        }

        private void rewards_screen_Shown(object sender, EventArgs e)
        {
            int average = get_average();
            //gets average score of all exams 
            percentage_lbl.Text = Convert.ToString(average) + "%";
            //puts it in label

            if (average < 40)
            {
                medal_png.Image = Image.FromFile("H:/Task2 Unfinished/Pictures/bronze_medal.png");
                medal_png.SizeMode = PictureBoxSizeMode.Zoom;
                //gets and styles image
                award_lbl.Text = "Bronze Medal";
                //tells them what award
            }
            else if (average > 40 && average < 80)
            {
                medal_png.Image = Image.FromFile("H:/Task2 Unfinished/Pictures/silver_medal.png");
                medal_png.SizeMode = PictureBoxSizeMode.Zoom;
                award_lbl.Text = "Silver Medal";
                //repeats based on their average 
            }
            else if (average == 0)
            {
                award_lbl.Text = "No Medal";
            }
            else
            {
                medal_png.Image = Image.FromFile("H:/Task2 Unfinished/Pictures/gold_medal.png");
                medal_png.SizeMode = PictureBoxSizeMode.Zoom;
                award_lbl.Text = "Gold Medal";
                //repeats
            }

            if (Properties.Settings.Default.dark_mode_on == true)
            {
                foreach (Control c in this.Controls)
                {
                    dark_mode(c);
                }
                bkg_png_pnl.BackgroundImage = Properties.Resources.night;
            }
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
    }
}
