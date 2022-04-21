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
    public partial class graph_screen : navigation_bar
    {
        public graph_screen(string name)
        {
            InitializeComponent();
            student_name.Text = name;
            //gets the student username passed to this form and puts it in a label
            plot_data();
            //plots the graph
        }

        private Tuple<List<string>, List<double>> get_points_to_plot()
        {
            account_creation_screen form = new account_creation_screen();
            MySqlConnection db = form.connect_to_db();
            form.Close();
            //connects to database using account creation subroutine

            int score = 0;
            string date = "";
            //initialises the date of the test and the score

            string command = "SELECT dateOfTest, score FROM tests WHERE studentUsername=@username ORDER BY dateOfTest asc";
            //selects the date and score where the username is of the correct student. It also orders it by the date

            List<string> dates = new List<string>();
            List<double> scores = new List<double>();
            //creates lists to store them in

            using (db)
            {
                MySqlCommand find_user = new MySqlCommand(command, db);
                find_user.Parameters.Add("@username", MySqlDbType.VarChar);
                find_user.Parameters["@username"].Value = student_name.Text;
                //adds parameters for the sql command

                try
                {
                    db.Open();
                    //opens database
                    MySqlDataReader myDataReader = find_user.ExecuteReader();
                    while (myDataReader.Read())
                        //does while theres still data
                    {
                        date = myDataReader.GetString(0);
                        //gets the values
                        score = myDataReader.GetInt32(1);
                        string date_only = date.Substring(0, 8);
                        //shortens the date, as it selects the date and time, and we only need the data
                        //so it removes the time
                        dates.Add(date_only);
                        //adds them to their appropriate lists
                        scores.Add(score);
                    }
                    myDataReader.Close();
                    db.Close();
                    //closes database
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    //shows error message
                }
            }
            return Tuple.Create(dates, scores);
            //returns the dates and score in a tuple
        }

        private void plot_data()
        {
            var data = get_points_to_plot();
            //gets the tuple of dates and scores
            List<string> dates = data.Item1;
            List<double> scores = data.Item2;
            //seperates them into two seperate lists
            string[] x_axis = dates.ToArray();
            double[] points = scores.ToArray();
            //makes them into arrays

            double[] y_axis = points;
            //adds y axis

            // clear old curves
            student_data_graph.GraphPane.CurveList.Clear();

            // plot the data as curves
            var curve1 = student_data_graph.GraphPane.AddCurve(null, null, y_axis, Color.Blue);
            curve1.Line.IsAntiAlias = true;
            curve1.Symbol.IsVisible = false;


            student_data_graph.GraphPane.XAxis.Type = ZedGraph.AxisType.Text;
            student_data_graph.GraphPane.XAxis.Scale.TextLabels = x_axis;
            //gets data for x axis


            // style the plot
            student_data_graph.GraphPane.Title.Text = $"Line graph for Student";
            student_data_graph.GraphPane.XAxis.Title.Text = "Date";
            student_data_graph.GraphPane.YAxis.Title.Text = "Score";

            // auto-axis and update the display
            student_data_graph.GraphPane.XAxis.ResetAutoScale(student_data_graph.GraphPane, CreateGraphics());
            student_data_graph.GraphPane.YAxis.ResetAutoScale(student_data_graph.GraphPane, CreateGraphics());
            student_data_graph.Refresh();
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            this.Close();
            //closes
            monitoring_screen form = new monitoring_screen();
            form.Show();
            //makes next form and shows it
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

        private void graph_screen_Shown(object sender, EventArgs e)
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
