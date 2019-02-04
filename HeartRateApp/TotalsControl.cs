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

namespace HeartRateApp
{
    public partial class TotalsControl : UserControl
    {
        private int totalSeconds = 0;
        public TotalsControl()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            totalSeconds = 0;
            TotalTimeSport(comboBox1.Text);
            TotalTime.Text = calculateTotalTime(totalSeconds);

        }

        private void TotalTimeSport (string sport)
        {
            string connectionString = "Server=127.0.0.1;Port=3306;Database=mydb;Uid=root;password=root";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = connection.CreateCommand();

            if (sport == "Alla")
            {
                command.CommandText = "SELECT length FROM training_sessions";
            }
            else
            {
                command.CommandText = "SELECT length FROM training_sessions WHERE sport = @sport;";
                command.Parameters.AddWithValue("@sport", sport);
            }


            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    AddTotalTime(reader[0].ToString());
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void AddTotalTime(string time)
        {
            string[] timeArray = time.Split(':');
            int hh = int.Parse(timeArray[0]);
            int mm = int.Parse(timeArray[1]);
            int ss;
            try
            {
                ss = int.Parse(timeArray[2].Split('.')[0]);
            }
            catch
            {
                ss = int.Parse(timeArray[2]);
            }

            totalSeconds += hh * 3600 + mm * 60 + ss;

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
