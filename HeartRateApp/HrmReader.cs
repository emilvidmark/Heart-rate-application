using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;



namespace HeartRateApp
{
    class HrmReader
    {

        public void UploadHrmToDatabase(string path, string userComment, string sport)
        {
            HRM hrmFile = ReadHRMFile(path);
            UploadToDatabase(hrmFile, userComment, sport);

        }
        /**
         * Used to extract the values from an HRM file and turn them into an HRM object.
         * */
        private HRM ReadHRMFile(string path)
        {

            //Read the HRM file and extract the values we want from it
            string[] hrmFile = File.ReadAllLines(path);
            string date = hrmFile[4].Split('=')[1];
            string startTime = hrmFile[5].Split('=')[1];
            string length = hrmFile[6].Split('=')[1];
            int interval = int.Parse(hrmFile[7].Split('=')[1]);
            int maxHR = int.Parse(hrmFile[18].Split('=')[1]);
            int restHR = int.Parse(hrmFile[19].Split('=')[1]);
            int vo2max = int.Parse(hrmFile[21].Split('=')[1]);
            int weight = int.Parse(hrmFile[22].Split('=')[1]);
            int runningIndex = int.Parse(hrmFile[23].Split('=')[1]);
            string hrValues = GetHRValues(hrmFile);
   
            return new HRM(date, startTime, length, interval, maxHR, restHR, vo2max, weight, runningIndex, hrValues);
        }

        private void UploadToDatabase(HRM hrm, string userComment, string sport)
        {
            //The string with the info to the db.
            string userName = File.ReadAllLines("C:/Users/Public/HeartRateApp/user_data.txt")[0].Split('=')[1];
            string connectionString = "Server=127.0.0.1;Port=3306;Database=mydb;Uid=root;password=root";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = connection.CreateCommand();

            command.CommandText = "INSERT INTO training_sessions(sport, date, start_time, length, meassure_interval, maxhr, resthr, vo2max, weight, runningindex, user_comment, hr_values, username) VALUES(@sport, @date, @start_time, @length, @meassure_interval, @maxhr, @resthr, @vo2max, @weight, @runningindex, @user_comment, @hr_values, @username);";
            command.Parameters.AddWithValue("@sport", sport);
            command.Parameters.AddWithValue("@date", hrm.GetDate());
            command.Parameters.AddWithValue("@start_time", hrm.GetStartTime());
            command.Parameters.AddWithValue("@length", hrm.GetLength());
            command.Parameters.AddWithValue("@meassure_interval", hrm.GetInterval());
            command.Parameters.AddWithValue("@maxhr", hrm.GetMaxHR());
            command.Parameters.AddWithValue("@resthr", hrm.GetRestHR());
            command.Parameters.AddWithValue("@vo2max", hrm.GetVO2Max());
            command.Parameters.AddWithValue("@weight", hrm.GetWeight());
            command.Parameters.AddWithValue("@runningindex", hrm.GetRunningIndex());
            command.Parameters.AddWithValue("@user_comment", userComment);
            command.Parameters.AddWithValue("@hr_values", hrm.GetHRValues());
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
        }

        private string GetHRValues(string[] file)
        {
            int i = 0;
            bool saveToArray = false;
            string hrValues = "";
            foreach (string line in file)
            {
                i++;

                if (saveToArray)
                {
                    if (line == "")
                    {
                        break;
                    }
                    string hrValue = line.Split('\t')[0];
                    hrValues += hrValue + ";";
                }

                if (line == "[HRData]" && !saveToArray)
                {
                    saveToArray = true;
                }
            }

            return hrValues;
        }
    }
}
