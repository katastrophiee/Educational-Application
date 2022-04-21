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
    public partial class monitoring_screen : navigation_bar
    {
        public monitoring_screen()
        {
            InitializeComponent();
        }


        private void classes_btn_Click(object sender, EventArgs e)
        {
            button_title_lbl.Text = "Classes:";
            //sets lable to appropriate title
            button_title_lbl.Visible = true;
            //shows label
            int start_up = -80;
            //sets a start location for where the button will start

            List<string> classes = get_classes();
            // gets all of the classes the teacher is in from the database
            classes_pnl.Controls.Clear();
            //clears the panel
            foreach (var item in classes)
                //does this for each class the teacher is part of
            {
                classes_pnl.Visible = true;
                //shows the panel
                classes_pnl.BringToFront();
                //brings it to front to make sure its seen

                Button btn = new Button();
                //makes new button
                btn.FlatStyle = FlatStyle.Flat;
                //sets flat style
                btn.Size = new Size(155, 81);
                //sets size
                btn.Font = new Font("Tahoma", 18);
                btn.ForeColor = Color.White;
                btn.BackColor = Color.RoyalBlue;
                //sets its design
                btn.Text = item;
                //sets text to be class name
                btn.Click += (sender1, EventArgs) =>
                {
                    show_students_class(sender, EventArgs, item);
                    //adds event on click as well as it passing the class name to the subroutine
                };
                classes_pnl.Controls.Add(btn);
                btn.Padding = new Padding(15);
                //adds to the panel
                btn.Location = new Point(30, start_up+=110);
                //increments the point to create the next button
                btn.BringToFront();
                //brings button to front
            }
        }

        private List<string> get_students(string class_name) //gets class name
        {
            account_creation_screen first_form = new account_creation_screen();
            MySqlConnection db = first_form.connect_to_db();
            first_form.Close();
            //connects to the database using ther subroutine from account creation

            string command = "SELECT classMemberUsername FROM class WHERE className=@classname AND isTeacher=0";
            //gets the username of students where their class is the same as the class name given 

            List<string> students = new List<string>();
            //makes a string to store all of the students that are in this class

            using (db)
            {
                MySqlCommand find_user = new MySqlCommand(command, db);
                find_user.Parameters.Add("@classname", MySqlDbType.VarChar);
                find_user.Parameters["@classname"].Value = class_name;
                //adds value from program

                try
                {
                    db.Open();
                    MySqlDataReader myDataReader = find_user.ExecuteReader();
                    //runs this while the program still has more values to gather
                    while (myDataReader.Read())
                    {
                        string student_name = myDataReader["classMemberUsername"].ToString();
                        //converts the values into a string and reads them
                        students.Add(student_name);
                        // adds all the class names into a list
                    }
                    myDataReader.Close();
                    db.Close();
                    //closes connection
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //error message
                }
            }
            return students;
            //returns the list
        }

        private void open_graph_screen(object sender, EventArgs e, string student_name)
        {
            graph_screen form = new graph_screen(student_name);
            //creates new graph screen and passes the student username
            this.Close();
            //closes this screen
            form.Show();
            //shows the new screen
        }

        private void show_students_class(object sender, EventArgs e, string class_name)
        {
            List<string> students = get_students(class_name);
            if (!students.Any())
                //checks list isnt empty
            {
                MessageBox.Show("No students are in this class!");
            }
            else
            {
            //stores the list of students retrieved from the database
            int start_up_btn = -80;
            //sets start locations for both items
            int start_up_lbl = -80;

            classes_pnl.Controls.Clear();
                //clears the panel
                foreach (var item in students)
                //does this for each student in the class
                {
                    classes_pnl.Visible = true;
                    //shows the panel
                    classes_pnl.BringToFront();
                    //brings to front to make sure its seen

                    Label lbl = new Label();
                    //makes new label
                    lbl.BorderStyle = BorderStyle.None;
                    lbl.MaximumSize = new Size(470, 0);
                    lbl.AutoSize = true;
                    //sets size
                    lbl.Font = new Font("Tahoma", 18);
                    lbl.BackColor = Color.Transparent;
                    //sets its design
                    lbl.Text = item;
                    //adds text from the text file

                    Button btn = new Button();
                    //makes new button
                    btn.FlatStyle = FlatStyle.Flat;
                    // sets flat style
                    btn.Size = new Size(155, 81);
                    //sets size
                    btn.Font = new Font("Tahoma", 18);
                    btn.ForeColor = Color.White;
                    btn.BackColor = Color.RoyalBlue;
                    //sets its design
                    btn.Text = "View Progress";
                    //sets text
                    btn.Click += (sender1, EventArgs) =>
                    {
                    //adds function to it when clicked
                    open_graph_screen(sender, EventArgs, item);
                    };
                    classes_pnl.Controls.Add(btn);
                    //adds both to the panel
                    classes_pnl.Controls.Add(lbl);

                    btn.Location = new Point(750, start_up_btn += 110);
                    lbl.Location = new Point(30, start_up_lbl += 110);
                    //increments the start points for both items
                    btn.BringToFront();
                    lbl.BringToFront();
                    //brings both to front
                }
            }
        }

        private void students_btn_Click(object sender, EventArgs e)
        {
            button_title_lbl.Text = "All Students:";
            button_title_lbl.Visible = true;
            //only changes the title and shows message as button wont be made to function right now
            MessageBox.Show("This module does not work right now as this is only a prototype!");
        }

        private void reward_btn_Click(object sender, EventArgs e)
        {
            button_title_lbl.Text = "Rewards:";
            button_title_lbl.Visible = true;
            //only changes the title and shows message as button wont be made to function right now
            MessageBox.Show("This module does not work right now as this is only a prototype!");
        }

        private void create_class_btn_Click(object sender, EventArgs e)
        {
            button_title_lbl.Text = "Create a Class:";
            button_title_lbl.Visible = true;
            //only changes the title and shows message as button wont be made to function right now
            MessageBox.Show("This module does not work right now as this is only a prototype!");
        }

        private List<string> get_classes()
        {
            account_creation_screen first_form = new account_creation_screen();
            MySqlConnection db = first_form.connect_to_db();
            first_form.Close();
            //connects to database using subroutine from account creation

            List<string> classes = new List<string>();
            //creates list for the classes

            string command = "SELECT * FROM class WHERE classMemberUsername=@teacher AND iSTeacher=1";
            //selects all the class names where the teachers username is the one logged in, and where teacher is true
            //teacher and student can have same username as theyre different tables in the database

            using (db)
            {
                MySqlCommand find_user = new MySqlCommand(command, db);
                find_user.Parameters.Add("@teacher", MySqlDbType.VarChar);
                find_user.Parameters["@teacher"].Value = Properties.Settings.Default.username;
                //adds the username to the sql
                try
                {
                    db.Open();
                    //opens database
                    MySqlDataReader myDataReader = find_user.ExecuteReader();

                    while (myDataReader.Read())
                        //does while there's still data to read
                    { 
                        string name = myDataReader["className"].ToString();
                        //gets class name
                        classes.Add(name);
                        // adds all the class names into a list
                    }
                    myDataReader.Close();
                    db.Close();
                    //closes
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //error message
                }
            }
            return classes;
            //returns the classes list
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

        private void monitoring_screen_Shown(object sender, EventArgs e)
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
