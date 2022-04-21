using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Task2_Code
{
    public partial class learning_resources_screen : navigation_bar
    {
        public learning_resources_screen()
        {
            InitializeComponent();
        }

        private void games_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form games_screen = new games_resources_screen();
            games_screen.Show();
        }

        private void collaboration_student_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form collaboration_screen = new collaboration_student_screen();
            collaboration_screen.Show();
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
            else if (education_level_drop_down.SelectedIndex == 1)
            //checks if its selected the high school level
            {
                subject_drop_down.Items.Clear();
                subject_drop_down.Items.AddRange(new string[] { "English", "Maths",
                    "Science", "Design and Technology", "History", "Geography", "Art and Design",
                    "Music", "PE", "ICT", "Modern Foreign Languages", "Citizenship",
                    "Design and Technology"});
                //adds high school subjects
            }
            else //as theres only 3 options, then it must be on the higher education choice
            {
                subject_drop_down.Items.Clear();
                subject_drop_down.Items.AddRange(new string[] { "Accounting",
                    "Anthropology", "Archaeology", "Architecture", "Art and Design",
                    "Biology", "Business", "Chemistry", "Computer Science","Criminology",
                    "Education","Technology","English","Games Design","Geography",
                    "History","Languages","Maths","Music","Politics"});
                //adds higher education subjects
            }
        }

        private void subject_drop_down_Click(object sender, EventArgs e)
        {
            //checks that the education level is selected before selecting subject
            if (education_level_drop_down.SelectedItem == null)
            {
                MessageBox.Show("Please choose your education level first!");
            }
        }

        private void subject_drop_down_SelectedIndexChanged(object sender, EventArgs e)
        {
            subjects_pnl.Visible = true;
            //shows the panel with the buttons on
            if (education_level_drop_down.SelectedIndex == 0)
            //checks if at primary school level
            {
                if (subject_drop_down.SelectedIndex == 0)
                //checks if english is selected, the first item 
                {
                    //English - Primary
                    button1.Text = "Themes";
                    //adds the subject name on the button
                    button1.Click += (sender1, EventArgs) =>
                    {
                        create_resource(sender, EventArgs, File.ReadAllText("H:/Task2 Unfinished/resources/" +
                            "primary_school/english/themes.txt"));
                    };
                    button1.Visible = true;
                    //adds the button function based on the topic

                    button2.Text = "Language and Structure";
                    button2.Click += (sender1, EventArgs) =>
                    {
                        create_resource(sender, EventArgs, File.ReadAllText("H:/Task2 Unfinished/resources/" +
                            "primary_school/english/language.txt"));
                    };
                    button2.Visible = true;
                    //repeats this for each resource we want

                    button3.Text = "Vocabulary";
                    button3.Click += (sender1, EventArgs) =>
                    {
                        create_resource(sender, EventArgs, File.ReadAllText("H:/Task2 Unfinished/resources/" +
                            "primary_school/english/vocab.txt"));
                    };
                    button3.Visible = true;
                    button4.Visible = false;
                    //i only did 3 to show as an example for this topic

                }
                else if (subject_drop_down.SelectedIndex == 1)
                {
                    //repeats whats above with the subject selected
                    //Maths - Primary
                    button1.Text = "Whole Numbers";
                    button1.Click += (sender1, EventArgs) =>
                    {
                        create_resource(sender, EventArgs, File.ReadAllText("H:/Task2 Unfinished/resources/" +
                            "primary_school/maths/whole_numbers.txt"));
                    };
                    button1.Visible = true;

                    button2.Text = "Decimals";
                    button2.Click += (sender1, EventArgs) =>
                    {
                        create_resource(sender, EventArgs, File.ReadAllText("H:/Task2 Unfinished/resources/" +
                            "primary_school/maths/decimals.txt"));
                    };
                    button2.Visible = true;
                    //repeats this for each resource we want

                    button3.Text = "Fractions";
                    button3.Click += (sender1, EventArgs) =>
                    {
                        create_resource(sender, EventArgs, File.ReadAllText("H:/Task2 Unfinished/resources/" +
                            "primary_school/maths/fractions.txt"));
                    };
                    button3.Visible = true;

                    button4.Text = "Multiples and Factors";
                    button4.Click += (sender1, EventArgs) =>
                    {
                        create_resource(sender, EventArgs, File.ReadAllText("H:/Task2 Unfinished/resources/" +
                            "primary_school/maths/multiples_and_factors.txt"));
                    };
                    button4.Visible = true;
                }
                else
                {
                    MessageBox.Show("This module does not work right now as this is only a prototype!");
                    //message box as to why the button does not work
                }
            }
            else if (education_level_drop_down.SelectedIndex == 1)
                //Secondary
            {
                
                if (subject_drop_down.SelectedIndex == 0)
                //checks if english is selected, the first item 
                {
                    //English - Secondary
                    button1.Text = "Themes";
                    //adds the subject name on the button
                    button1.Click += (sender1, EventArgs) =>
                    {
                        create_resource(sender, EventArgs, File.ReadAllText("H:/Task2 Unfinished/resources/" +
                            "secondary_school/english/themes.txt"));
                    };
                    button1.Visible = true;
                    //adds the button function based on the topic

                    button2.Text = "Language and Structure";
                    button2.Click += (sender1, EventArgs) =>
                    {
                        create_resource(sender, EventArgs, File.ReadAllText("H:/Task2 Unfinished/resources/" +
                            "secondary_school/english/language.txt"));
                    };
                    button2.Visible = true;
                    //repeats this for each resource we want

                    button3.Text = "Vocabulary";
                    button3.Click += (sender1, EventArgs) =>
                    {
                        create_resource(sender, EventArgs, File.ReadAllText("H:/Task2 Unfinished/resources/" +
                            "secondary_school/english/vocab.txt"));
                    };
                    button3.Visible = true;
                    button4.Visible = false;
                    //i only did 3 to show as an example for this topic

                }
                else if (subject_drop_down.SelectedIndex == 1)
                {
                    //repeats whats above with the subject selected
                    //Maths - Secondary
                    button1.Text = "Whole Numbers";
                    button1.Click += (sender1, EventArgs) =>
                    {
                        create_resource(sender, EventArgs, File.ReadAllText("H:/Task2 Unfinished/resources/" +
                            "secondary_school/maths/whole_numbers.txt"));
                    };
                    button1.Visible = true;

                    button2.Text = "Decimals";
                    button2.Click += (sender1, EventArgs) =>
                    {
                        create_resource(sender, EventArgs, File.ReadAllText("H:/Task2 Unfinished/resources/" +
                            "secondary_school/maths/decimals.txt"));
                    };
                    button2.Visible = true;
                    //repeats this for each resource we want

                    button3.Text = "Fractions";
                    button3.Click += (sender1, EventArgs) =>
                    {
                        create_resource(sender, EventArgs, File.ReadAllText("H:/Task2 Unfinished/resources/" +
                            "secondary_school/maths/fractions.txt"));
                    };
                    button3.Visible = true;

                    button4.Text = "Multiples and Factors";
                    button4.Click += (sender1, EventArgs) =>
                    {
                        create_resource(sender, EventArgs, File.ReadAllText("H:/Task2 Unfinished/resources/" +
                            "secondary_school/maths/multiples_and_factors.txt"));
                    };
                    button4.Visible = true;
                }
                else
                {
                    MessageBox.Show("This module does not work right now as this is only a prototype!");
                    //message box as to why the button does not work
                }
            }
            else
            {
                if (subject_drop_down.SelectedIndex == 0)
                //checks if english is selected, the first item 
                {
                    //Accounting - Higher
                    button1.Text = "Income Statements";
                    //adds the subject name on the button
                    button1.Click += (sender1, EventArgs) =>
                    {
                        create_resource(sender, EventArgs, File.ReadAllText("H:/Task2 Unfinished/resources/" +
                            "higher_education/accounting/income_statement.txt"));
                    };
                    button1.Visible = true;
                    //adds the button function based on the topic

                    button2.Text = "Financial Records";
                    button2.Click += (sender1, EventArgs) =>
                    {
                        create_resource(sender, EventArgs, File.ReadAllText("H:/Task2 Unfinished/resources/" +
                            "higher_education/accounting/financial_records.txt"));
                    };
                    button2.Visible = true;
                    //repeats this for each resource we want

                    button3.Text = "Financial Performance Analysis";
                    button3.Click += (sender1, EventArgs) =>
                    {
                        create_resource(sender, EventArgs, File.ReadAllText("H:/Task2 Unfinished/resources/" +
                            "higher_education/accounting/analysing_performance.txt"));
                    };
                    button3.Visible = true;
                    button4.Visible = false;
                    //i only did 3 to show as an example for this topic

                }
                else if (subject_drop_down.SelectedIndex == 1)
                {
                    //repeats whats above with the subject selected
                    //Anthropology - Higher
                    button1.Text = "Introduction";
                    button1.Click += (sender1, EventArgs) =>
                    {
                        create_resource(sender, EventArgs, File.ReadAllText("H:/Task2 Unfinished/resources/" +
                            "higher_education/anthropology/intro.txt"));
                    };
                    button1.Visible = true;

                    button2.Text = "Sociocultural";
                    button2.Click += (sender1, EventArgs) =>
                    {
                        create_resource(sender, EventArgs, File.ReadAllText("H:/Task2 Unfinished/resources/" +
                            "higher_education/anthropology/sociocultural.txt"));
                    };

                    button2.Visible = true;
                    button3.Visible = false;
                    button4.Visible = false;
                }
                else if (subject_drop_down.SelectedIndex == 2)
                {
                     button1.Text = "Introduction";
                    button1.Click += (sender1, EventArgs) =>
                    {
                        create_resource(sender, EventArgs, File.ReadAllText("H:/Task2 Unfinished/resources/" +
                            "higher_education/archaeology/intro.txt"));
                    };
                    button1.Visible = true;

                    button2.Text = "History";
                    button2.Click += (sender1, EventArgs) =>
                    {
                        create_resource(sender, EventArgs, File.ReadAllText("H:/Task2 Unfinished/resources/" +
                            "higher_education/archaeology/history.txt"));
                    };

                    button2.Visible = true;
                    button3.Visible = false;
                    button4.Visible = false;
                }
                else
                {
                    MessageBox.Show("This module does not work right now as this is only a prototype!");
                    //message box as to why the button does not work
                }
            }
        }

        public void scroll_to_top(Panel p)
        {
            using (Control c = new Control() { Parent = p, Dock = DockStyle.Top })
                //creates a new control and sets the dock style
                //we need top as it will scroll to the top of the panel
            {
                p.ScrollControlIntoView(c);
                //uses the control to scroll the panel into view
                c.Parent = null;
                //sets to null
            }
        }

        private void close_topic_btn_Click(object sender, EventArgs e)
        {
            scroll_to_top(topic_pnl);
            //scrolls to top
            topic_pnl.Visible = false;
            //hides topic
            subjects_pnl.Visible = true;
            //shows topics to pick again
            close_topic_btn.Visible = false;
            //hides the button again
        }

        private void create_resource(object sender, EventArgs e, string text)
        //passes the file path for the game
        {
            close_topic_btn.Visible = true;
            subjects_pnl.Visible = false;
            //hides the panel with the buttons
            //creates label

            Label lbl = new Label();
            lbl.BorderStyle = BorderStyle.None;
            lbl.MaximumSize = new Size(940,0);
            lbl.AutoSize = true;
            //sets size
            lbl.Font = new Font("Tahoma", 18);
            lbl.BackColor = Color.Transparent;
            if (Properties.Settings.Default.dark_mode_on)
            {
                lbl.ForeColor = Color.White;
            }
            //sets its design
            lbl.Text = text;
            //adds text from the text file


            topic_pnl.Visible = true;
            //shows panel wit label on
            topic_pnl.BringToFront();
            //ensures its at the front
            topic_pnl.Controls.Add(lbl);
            //adds the lbl to the panel
            lbl.BringToFront();
            //brings label to front
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

        private void learning_resources_screen_Shown(object sender, EventArgs e)
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
