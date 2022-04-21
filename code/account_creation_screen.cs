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
using System.Text.RegularExpressions;
using System.Security.Cryptography;
using System.Net.Mail;

namespace Task2_Code
{
    public partial class account_creation_screen : Form
    {
        public account_creation_screen()
        {
            InitializeComponent();
        }

        public MySqlConnection connect_to_db()
        {
            MySqlConnection db = new MySqlConnection(); //makes new connection
            db.ConnectionString = @"server=localhost; uid=root; database=gidjohn_tutoring"; //details for the database
            return db;
        }
        private bool check_for_teacher()
        {
            int teacher = -1;
            bool teacher_ret = false;
            MySqlConnection db = connect_to_db(); //connects to database
            string command = "SELECT isTeacher FROM codes WHERE code=@code"; //checks if code is teacher or not

            using (db)
            {
                MySqlCommand find_user = new MySqlCommand(command, db);
                find_user.Parameters.Add("@code", MySqlDbType.VarChar);
                find_user.Parameters["@code"].Value = code.Text; // adds code value

                try
                {
                    db.Open();
                    MySqlDataReader myDataReader = find_user.ExecuteReader(); //reads from database
                    if (myDataReader.Read())
                    {
                        teacher = myDataReader.GetInt32(0); //gets 1 if teacher, 0 if not
                    }
                    myDataReader.Close();
                    db.Close(); //closes reader and connection
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message); //shows error
                }
            }
            
            if (teacher == 1)
            {
                teacher_ret = true; //returns true if a teacher
            }
            else if (teacher == 0)
            {
                teacher_ret = false; //returns 0 if not
            }
            else
            {
                MessageBox.Show("Error, code may not be valid, please use a different one");
                // error message for if code isnt in database, as value will be -1, not 1 or 0
            }

            return teacher_ret; //returns if teacher or not
        }

        private void insert_account_student()
        {
            MySqlConnection db = connect_to_db(); //connects to database
            string command = "INSERT INTO students(studentName, studentUsername, studentPassword, studentEmail, code)"
                + "VALUES (@name, @username, @password, @email, @code)";
            // sql for adding an account

            string hashed_password = hashing_password(); // hashes password

            using (db)
            {
                MySqlCommand add_data = new MySqlCommand(command, db);
                add_data.Parameters.Add("@name", MySqlDbType.VarChar);
                add_data.Parameters["@name"].Value = name.Text;
                add_data.Parameters.Add("@username", MySqlDbType.VarChar); //assigning the valued for what im adding to the database
                add_data.Parameters["@username"].Value = username.Text;
                add_data.Parameters.Add("@password", MySqlDbType.VarChar);
                add_data.Parameters["@password"].Value = hashed_password;
                add_data.Parameters.Add("@email", MySqlDbType.VarChar);
                add_data.Parameters["@email"].Value = email.Text;
                add_data.Parameters.Add("@code", MySqlDbType.VarChar);
                add_data.Parameters["@code"].Value = code.Text;

                try
                {
                    db.Open();
                    add_data.ExecuteReader(); //tries to open, add the data then close the database
                    db.Close();
                    MessageBox.Show("Account created!");
                }
                catch (MySqlException ex)
                {
                    int error_code = ex.Number; // gets error code 
                    if (error_code == 1062)
                    {
                        MessageBox.Show("Error\nSome of this data is already in use, please try again"); //shows error if any values are already in use
                    }
                }
                finally
                {
                    if (db == null) //if the database doesnt exist
                    {
                        MessageBox.Show("Failed"); //show error
                    }
                }
            }
        }

        private bool validating_inputs()
        {
            Regex char_only = new Regex("^[a-zA-Z ]+$"); // checks if consists of only characters
            Regex has_num = new Regex(@"[0-9]+"); //checks if has a number
            Regex has_upper = new Regex(@"[A-Z]+"); //checks if has an upper case
            Regex has_lower = new Regex(@"[a-z]+"); //checks if has a lower case
            Regex username_check = new Regex(@"^[a-zA-Z0-9_]+$"); //checks username is characters, numbers or underscores only
            Regex has_special_char = new Regex(@"[!@#$%^&*]"); //checks if has special char


            // check name
            if (char_only.IsMatch(name.Text) != true)
            {
                MessageBox.Show("Name must consist of only characters"); //error if not just char
                return false; //returns false to signify the inputs are not ready to be put into the database
            }


            //check username
            if (username_check.IsMatch(username.Text) != true)
            {
                MessageBox.Show("Username must consist of characters, numbers or underscores");
                return false; //repeats whats done before
            }

            // check email
            try
            {
                MailAddress mail = new MailAddress(email.Text);
                //tries to create a new mail item using email entered
            }
            catch (FormatException) // catches if it cannot create it
            {
                MessageBox.Show("Email must be formatted correctly");
                return false;
            }

            // checks pass for num
            if (has_num.IsMatch(password.Text) != true)
            {
                MessageBox.Show("Password must contain a number");
                return false;
            }

            // checks pass for upper case
            if (has_upper.IsMatch(password.Text) != true)
            {
                MessageBox.Show("Password must contain an upper case character");
                return false;
            }

            // checks pass for lower case
            if (has_lower.IsMatch(password.Text) != true)
            {
                MessageBox.Show("Password must contain an lower case character");
                return false;
            }

            // checks pass length
            if (password.Text.Length > 20 || password.Text.Length < 8)
            {
                MessageBox.Show("Password must be between 8 and 20 characters");
                return false;
            }

            // checks for special char
            if (has_special_char.IsMatch(password.Text) != true)
            {
                MessageBox.Show("Password must contain a special character");
                return false;
            }

            return true;
        }

        private void insert_account_teacher()
        {
            MySqlConnection db = connect_to_db(); //connects to database
            string command = "INSERT INTO teachers(teacherName, teacherUsername, teacherPassword, teacherEmail, code)"
                + "VALUES (@name, @username, @password, @email, @code)";
            // sql for adding teacher details into database

            string hashed_password = hashing_password(); // hashes password

            using (db)
            {
                MySqlCommand add_data = new MySqlCommand(command, db);
                add_data.Parameters.Add("@name", MySqlDbType.VarChar);
                add_data.Parameters["@name"].Value = name.Text;
                add_data.Parameters.Add("@username", MySqlDbType.VarChar); //assigning the valued for what im adding to the database
                add_data.Parameters["@username"].Value = username.Text;
                add_data.Parameters.Add("@password", MySqlDbType.VarChar);
                add_data.Parameters["@password"].Value = hashed_password;
                add_data.Parameters.Add("@email", MySqlDbType.VarChar);
                add_data.Parameters["@email"].Value = email.Text;
                add_data.Parameters.Add("@code", MySqlDbType.VarChar);
                add_data.Parameters["@code"].Value = code.Text;

                try
                {
                    db.Open();
                    add_data.ExecuteReader(); //tries to open, add the data then close the database
                    db.Close();
                    MessageBox.Show("Account created!");
                }
                catch (MySqlException ex)
                {
                    int error_code = ex.Number; // gets error code 
                    if (error_code == 1062)
                    {
                        MessageBox.Show("Error\nSome of this data is already in use, please try again"); //shows error if code is already in use
                    }
                }
                finally
                {
                    if (db == null) //if the database doesnt exist
                    {
                        MessageBox.Show("Failed"); //show error
                    }
                }
            }
        }

        private string hashing_password()
        {
            string source = password.Text; //gets string to hash
            using (SHA512 sha512Hash = SHA512.Create()) //creates a hash
            {
                byte[] sourceBytes = Encoding.UTF8.GetBytes(source); 
                byte[] hashBytes = sha512Hash.ComputeHash(sourceBytes); // uses inbuilt hashing algorithm
                string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);

                return hash; // returns password after hashed
            }
        }

        private void username_Enter(object sender, EventArgs e)
        {
            if (username.Text == "Username") //removes text when on text box 
            {
                username.Text = "";
                username.ForeColor = System.Drawing.Color.Black; // changes text to grey when nothing entered, then black if something is
            }
        }

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Password")
            {
                password.Text = "";
                password.UseSystemPasswordChar = true;
                password.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (username.Text == "") // adds text back if the user doesnt enter anything
            {
                username.Text = "Username";
                username.ForeColor = System.Drawing.Color.Silver;
            }
        }

        private void password_Leave(object sender, EventArgs e)
        {
            if (password.Text == "")
            {
                password.UseSystemPasswordChar = false;
                password.Text = "Password";
                password.ForeColor = System.Drawing.Color.Silver;
            }
        }

        private void name_Leave(object sender, EventArgs e)
        {
            if (name.Text == "")
            {
                name.Text = "Name";
                name.ForeColor = System.Drawing.Color.Silver;
            }
        }

        private void name_Enter(object sender, EventArgs e)
        {
            if (name.Text == "Name")
            {
                name.Text = "";
                name.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void email_Leave(object sender, EventArgs e)
        {
            if (email.Text == "")
            {
                email.Text = "Email";
                email.ForeColor = System.Drawing.Color.Silver;
            }
        }

        private void email_Enter(object sender, EventArgs e)
        {
            if (email.Text == "Email")
            {
                email.Text = "";
                email.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void code_Leave(object sender, EventArgs e)
        {
            if (code.Text == "")
            {
                code.Text = "000-000-000";
                code.ForeColor = System.Drawing.Color.Silver;
            }
        }

        private void code_Enter(object sender, EventArgs e)
        {
            if (code.Text == "000-000-000")
            {
                code.Text = "";
                code.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close(); //closes current form
            Form login_screen = new login_screen(); //creates next screen
            login_screen.Show(); // shows next form
        }

        private void create_account_btn_Click(object sender, EventArgs e)
        {
            bool valid = validating_inputs();

            if (username.Text == "Username" || password.Text == "Password" || email.Text == "Email"
                || name.Text == "Name" || code.Text == "000-000-000") // checks if all boxes has a value and isnt default
            {
                MessageBox.Show("Please make sure you have entered a value for all boxes"); // error message
            }
            else
            {
                if (valid)
                {
                    bool teacher = check_for_teacher(); // checks if teacher
                    if (teacher == true)
                    {
                        insert_account_teacher(); // adds to teacher table in database if so
                        Properties.Settings.Default.teacher = true; // sets if teacher or not
                    }
                    else
                    {
                        insert_account_student(); // adds to student table in database if not
                        Properties.Settings.Default.teacher = false;
                    }

                    Properties.Settings.Default.username = username.Text;
                    Properties.Settings.Default.password = password.Text;
                    Properties.Settings.Default.email = email.Text;
                    Properties.Settings.Default.name = name.Text; // saves details in program
                    Properties.Settings.Default.logged_in = true;
                    Properties.Settings.Default.remembered = true;
                    Properties.Settings.Default.Save();
                    

                    this.Close(); // closes as youll have an account and be logged in
                    Form home_screen = new home_screen();
                    home_screen.Show();
                }
            }
        }

        public void dark_mode(Control myControl)
        {
            if (myControl is CheckBox || myControl is Button)
            {
                myControl.BackColor = Color.FromArgb(84, 97, 140);
                myControl.ForeColor = Color.White;
            }
            else if (myControl is TextBox)
            {
                myControl.BackColor = Color.FromArgb(107, 107, 107);
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

        private void account_creation_screen_Shown(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.dark_mode_on == true)
            {
                foreach (Control c in this.Controls)
                {
                    dark_mode(c);
                }
            }
        }
    }
}
