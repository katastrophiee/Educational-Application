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
    public partial class games_resources_screen : navigation_bar
    {
        public games_resources_screen()
        {
            InitializeComponent();
        }

        private void subject_drop_down_SelectedIndexChanged(object sender, EventArgs e)
        {
            subject_pnl.Visible = true;
            //shows the panel with the buttons on
            if (education_level_drop_down.SelectedIndex == 0)
            //checks if at primary school level
            {
                if (subject_drop_down.SelectedIndex == 0)
                //checks if english is selected, the first item 
                {
                    //English - Primary
                    button1.Visible = true;
                    button1.Text = "Cross Word";
                    //adds the subject name on the button
                    button1.Click += (sender1, EventArgs) =>
                    {
                        try
                        {
                            open_game(sender, EventArgs, "http://127.0.0.1:8000/english_cross_word.html");
                            //tries to open using php server
                        }
                        catch
                        {
                            open_game(sender, EventArgs, "H:/Task2 Unfinished/resources/gamified_learning/english/english_cross_word.html");
                            //opens using file path if cannot
                        }
                    };
                }
                else
                {
                    MessageBox.Show("This module does not work right now as this is only a prototype!");
                    //message box as to why the button does not work
                }
            }
        }

        private void education_level_drop_down_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (education_level_drop_down.SelectedIndex == 0)
            //checks if its selected the primary school level
            {
                subject_drop_down.Items.Clear(); //removes all items
                subject_drop_down.Items.AddRange(new string[] { "English", "Maths",
                    "Science", "Design and Technology", "History", "Geography", "Art and Design",
                    "Music", "PE", "Computing", "Languages" });
                //adds primary school subjects
            }
            else
            {
                MessageBox.Show("This module does not work right now as this is only a prototype!");
                //message box as to why the button does not work
            }
        }

        private void subject_drop_down_Click_1(object sender, EventArgs e)
        {
            //checks that the education level is selected before selecting subject
            if (education_level_drop_down.SelectedIndex != 0)
            {
                MessageBox.Show("Please choose your education level first!");
            }
        }

        private void open_game(object sender, EventArgs e, string game_link)
        //passes game to open
        {
            System.Diagnostics.Process.Start(game_link);
            //runs appropriate game in web browser 
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

        private void games_resources_screen_Shown(object sender, EventArgs e)
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

