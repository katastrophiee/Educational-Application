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
using System.Security.Cryptography;


namespace Task2_Code
{
    public partial class login_screen : Form
    {
        public login_screen()
        {
            InitializeComponent();
        }

        private void username_Leave(object sender, EventArgs e)
        {
            if (username.Text == "")
            {
                username.Text = "Username";
                username.ForeColor = System.Drawing.Color.Silver;
            }
        }

        private void username_Enter(object sender, EventArgs e)
        {
            if (username.Text == "Username")
            {
                username.Text = "";
                username.ForeColor = System.Drawing.Color.Black;
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

        private void password_Enter(object sender, EventArgs e)
        {
            if (password.Text == "Password")
            {
                password.Text = "";
                password.UseSystemPasswordChar = true;
                password.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void account_creation_screen_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form account_creation_screen = new account_creation_screen();
            account_creation_screen.Show(); //goes to account creation screen
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            Form home_screen = new home_screen();
            home_screen.Show();

        }

        private string hashing_password()
        {
            string source = password.Text; //gets password to hash
            using (SHA512 sha512Hash = SHA512.Create())
            {
                byte[] sourceBytes = Encoding.UTF8.GetBytes(source);
                byte[] hashBytes = sha512Hash.ComputeHash(sourceBytes); //hashes using inbuilt system hashing
                string hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty); //converts to string

                return hash; //returns the hashed password
            }
        }

        private bool check_account_student()
        {
            bool exists = false; 
            account_creation_screen account_creation = new account_creation_screen();
            MySqlConnection db = account_creation.connect_to_db(); // uses connection subroutine from previous form
            account_creation.Close(); //closes one got

            string command = "SELECT * FROM students WHERE studentUsername=@username AND studentPassword=@password";
            // gets column where the passsword and username are what is entered

            string hashed_password = hashing_password(); //hashes password

            using (db)
            {
                MySqlCommand find_user = new MySqlCommand(command, db);
                find_user.Parameters.Add("@username", MySqlDbType.VarChar);
                find_user.Parameters["@username"].Value = username.Text; //adds values
                find_user.Parameters.Add("@password", MySqlDbType.VarChar);
                find_user.Parameters["@password"].Value = hashed_password;

                try
                {
                    db.Open(); //opens database
                    MySqlDataReader myDataReader = find_user.ExecuteReader(); //creates new data reader
                    if (myDataReader.Read()) //uses it
                    {

                        Properties.Settings.Default.username = username.Text;
                        Properties.Settings.Default.password = password.Text; //saves details
                        Properties.Settings.Default.email = myDataReader.GetString(4);
                        Properties.Settings.Default.name = myDataReader.GetString(1);
                        Properties.Settings.Default.teacher = false; //false as this checks student table
                        Properties.Settings.Default.logged_in = true;
                        Properties.Settings.Default.Save(); //saves
                        exists = true;
                    }
                    myDataReader.Close();
                    db.Close(); //closes
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message); //error
                }
            }
            return exists; //returns if it exists or not
        }

        private bool check_account_teacher()
        {
            bool exists = false;
            account_creation_screen account_creation = new account_creation_screen();
            MySqlConnection db = account_creation.connect_to_db();
            account_creation.Close();

            string command = "SELECT * FROM teachers WHERE teacherUsername=@username AND teacherPassword=@password";
            //checks teacher table instead

            string hashed_password = hashing_password();

            using (db)
            {
                MySqlCommand find_user = new MySqlCommand(command, db);
                find_user.Parameters.Add("@username", MySqlDbType.VarChar);
                find_user.Parameters["@username"].Value = username.Text;
                find_user.Parameters.Add("@password", MySqlDbType.VarChar);
                find_user.Parameters["@password"].Value = hashed_password;

                try
                {
                    db.Open();
                    MySqlDataReader myDataReader = find_user.ExecuteReader();
                    if (myDataReader.Read())
                    {

                        Properties.Settings.Default.username = username.Text;
                        Properties.Settings.Default.password = password.Text;
                        Properties.Settings.Default.email = myDataReader.GetString(4);
                        Properties.Settings.Default.name = myDataReader.GetString(1);
                        Properties.Settings.Default.teacher = true; //true as this is for the teacher table
                        Properties.Settings.Default.logged_in = true;
                        Properties.Settings.Default.Save();
                        exists = true;
                    }
                    myDataReader.Close();
                    db.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            return exists;
        }

        private void sign_in_btn_Click(object sender, EventArgs e)
        {
            bool student = check_account_student(); // sees if user is teacher, student or neither
            bool teacher = check_account_teacher();

            if (student == false && teacher == false) // checks if not a member
            {
                MessageBox.Show("Incorrect details, please try again."); //error if so
            }
            else
            {
                if (remembered_check.Checked == true)
                {
                    Properties.Settings.Default.remembered = true;
                }
                else
                {
                    Properties.Settings.Default.remembered = false;
                }
                Properties.Settings.Default.Save();
                MessageBox.Show("Logged in, welcome " + Properties.Settings.Default.name); //logs in if member
                this.Close(); //closes and opens home screen
                Form home_screen = new home_screen(); 
                home_screen.Show();
            }
        }

        public void dark_mode(Control myControl)
        {
            if (myControl is Button)
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

        private void login_screen_Shown(object sender, EventArgs e)
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
