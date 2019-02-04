using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;

namespace HeartRateApp
{
    public partial class ManualRegistration : UserControl
    {
        public ManualRegistration()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Sport.Text == "")
            {
                MessageBox.Show("Du måste välja en sport.");
                return;
            }

            if (hh.Value == 0 && mm.Value == 0 && ss.Value == 0)
            {
                MessageBox.Show("Du måste fylla i tid för passet.");
                return;
            }
            int totalSeconds = 0;

            totalSeconds += int.Parse(hh.Text)*3600;
            totalSeconds += int.Parse(mm.Text)*60;
            totalSeconds += int.Parse(ss.Text);

            string userName = File.ReadAllLines("C:/Users/Public/HeartRateApp/user_data.txt")[0].Split('=')[1];

            string connectionString = "Server=127.0.0.1;Port=3306;Database=mydb;Uid=root;password=root";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = connection.CreateCommand();

            command.CommandText = "INSERT INTO training_sessions(sport, date, start_time, length, username) VALUES(@sport, @date, @start_time, @length, @username);";
            command.Parameters.AddWithValue("@sport", Sport.Text);
            command.Parameters.AddWithValue("@date", Date.Text);
            command.Parameters.AddWithValue("@start_time", StartTime.Text);
            command.Parameters.AddWithValue("@length", calculateTotalTime(totalSeconds));
            command.Parameters.AddWithValue("@username", userName);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                Console.WriteLine("OK");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            

            MessageBox.Show("Data registrerat.");
            Sport.Text = "";
            Date.Text = "";
            StartTime.Text = "";
            hh.Text = "";
        }

        private string calculateTotalTime(int totalSeconds)
        {
            TimeSpan t = TimeSpan.FromSeconds(totalSeconds);
            string answer = string.Format("{0:D2}:{1:D2}:{2:D2}",
                t.Hours,
                t.Minutes,
                t.Seconds);

            return answer;
        }
    }
}
