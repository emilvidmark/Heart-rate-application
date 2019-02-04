using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HeartRateApp
{
    public partial class TrainingDetails : Form
    {
        int max = 0;
        int avg = 0;
        int total = 0;
        int numberOfValues = 0;
        public TrainingDetails()
        {
            InitializeComponent();
        }

        public TrainingDetails(string id)
        {
            InitializeComponent();
            Initialize(id);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        public void Initialize(string id)
        {
            string[] data = GenerateValueArray(id);
            Title.Text = data[0];
            Date.Text = data[1];
            Time.Text = data[2];
            pictureBox1.Image = Image.FromFile(getImageLocationForSport(data[0]));

            Weight.Text = data[8];

            string[] zoneTimes = CalculateZoneTimes(data[10], data[3], data[5]);

            Zone1.Text = zoneTimes[0];
            Zone2.Text = zoneTimes[1];
            Zone3.Text = zoneTimes[2];
            Zone4.Text = zoneTimes[3];
            Zone5.Text = zoneTimes[4];

            MaxHR.Text = this.max.ToString();
            AvgHR.Text = (this.total / this.numberOfValues).ToString();

            int[] hrValues = GetHRValueArray(data[10]);
            insertValuesIntoChart(hrValues, data[4]);

        }

        
        public string[] GenerateValueArray(string id)
        {
            string connectionString = "Server=127.0.0.1;Port=3306;Database=mydb;Uid=root;password=root";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = connection.CreateCommand();

            command.CommandText = "SELECT * FROM training_sessions WHERE id = @id;";
            command.Parameters.AddWithValue("@id", id);

            string sport = "";
            string date = "";
            string startTime = "";
            string length = "";
            string interval= "";
            string maxHR = "";
            string restHR = "";
            string VO2Max = "";
            string weight = "";
            string runningIndex= "";
            string HRValues = "";
            try
            {

                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    sport = reader[1].ToString();
                    date = reader[2].ToString();
                    startTime = reader[3].ToString();
                    length = reader[4].ToString();
                    interval = reader[5].ToString();
                    maxHR = reader[6].ToString();
                    restHR = reader[7].ToString();
                    VO2Max = reader[8].ToString();
                    weight = reader[9].ToString();
                    runningIndex = reader[10].ToString();
                    HRValues = reader[12].ToString();

                    
                }
                return new string[] { sport, date, startTime, length, interval, maxHR, restHR, VO2Max, weight, runningIndex, HRValues };
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return new string[] { "", "", "", "", "", "", "", "", "", "" };

            }
        }

        //Calculates time in zone 1,2,3,4,5
        private string[] CalculateZoneTimes(string hrValues, string duration, string maxHR)
        {
            string hh = duration.Split(':')[0];
            string mm = duration.Split(':')[1];
            string deltaSS = duration.Split(':')[2];
            string ss = deltaSS.Split('.')[0]; // Removes the decimal, we don't care about it.
            int totalSeconds = int.Parse(hh) * 3600 + int.Parse(mm) * 60 + int.Parse(ss);

            string[] hrValuesArray = hrValues.Split(';');          // HR values is string separated with comma
            int max = int.Parse(maxHR);
            double zone4Max = max*0.899;
            double zone3Max = max*0.799;
            double zone2Max = max*0.699;
            double zone1Max = max*0.599;
            double zone0Max = max * 0.5;

            float zone5values = 0;
            float zone4values = 0;
            float zone3values = 0;
            float zone2values = 0;
            float zone1values = 0;
            float zone0values = 0;

            foreach(string value in hrValuesArray)
            {
                if (value == "")
                {
                    break;
                }

                //This part is to calculate average and max hr
                checkIfMax(int.Parse(value));
                this.total += int.Parse(value);
                this.numberOfValues++;

                int v = int.Parse(value);

                if (v > zone4Max && v < max)
                {
                    zone5values++;
                }

                if (v > zone3Max && v < zone4Max)
                {
                    zone4values++;
                }

                if (v > zone2Max && v < zone3Max)
                {
                    zone3values++;
                }

                if (v > zone1Max && v < zone2Max)
                {
                    zone2values++;
                }

                if (v > zone0Max && v < zone1Max)
                {
                    zone1values++;
                }

                if (v < zone0Max)
                {
                    zone0values++;
                }
            }

            float totalZoneValues = zone0values + zone1values + zone2values + zone3values + zone4values + zone5values;

            double secondsInZone1 = (zone1values / totalZoneValues) * totalSeconds;
            double secondsInZone2 = (zone2values / totalZoneValues) * totalSeconds;
            double secondsInZone3 = (zone3values / totalZoneValues) * totalSeconds;
            double secondsInZone4 = (zone4values / totalZoneValues) * totalSeconds;
            double secondsInZone5 = (zone5values / totalZoneValues) * totalSeconds;

            string timeZone1 = calculateTotalTime(secondsInZone1);
            string timeZone2 = calculateTotalTime(secondsInZone2);
            string timeZone3 = calculateTotalTime(secondsInZone3);
            string timeZone4 = calculateTotalTime(secondsInZone4);
            string timeZone5 = calculateTotalTime(secondsInZone5);

            return new string[] { timeZone1, timeZone2, timeZone3, timeZone4, timeZone5 };
        }

        private string calculateTotalTime(double zoneSeconds)
        {
            TimeSpan t = TimeSpan.FromSeconds(zoneSeconds);
            string answer = string.Format("{0:D2}:{1:D2}:{2:D2}",
                t.Hours,
                t.Minutes,
                t.Seconds);

            return answer;
        }

        private void checkIfMax(int i)
        {
            if(i > this.max)
            {
                max = i;
            }
        }

        private string getImageLocationForSport(string sport)
        {
            if (sport == "Löpning") { return "C:/Users/Public/HeartRateApp/Images/running.png"; }
            if (sport == "Ridning") { return "C:/Users/Public/HeartRateApp/Images/riding.png"; }
            if (sport == "Simning") { return "C:/Users/Public/HeartRateApp/Images/swim.png"; }
            if (sport == "Skidåkning") { return "C:/Users/Public/HeartRateApp/Images/xc_skiing.png"; }
            if (sport == "Gym") { return "C:/Users/Public/HeartRateApp/Images/gym.png"; }
            if (sport == "Cykling") { return "C:/Users/Public/HeartRateApp/Images/cycling.png"; }
            if (sport == "Orientering") { return "C:/Users/Public/HeartRateApp/Images/orienteering.png"; }
            return "C:/Users/Public/HeartRateApp/Images/running.png";
        }

        private int[] GetHRValueArray(string hrValues)
        {
            string[] hrValuesStringArray = hrValues.Split(';');
            int[] hrValueIntArray = new int[hrValuesStringArray.Length-1];
            int i = 0;
            


            foreach (string value in hrValuesStringArray)
            {
                if (value == "")
                {
                    break;
                }
                hrValueIntArray[i] = int.Parse(value);
                i++;
            }
            return hrValueIntArray;
        }

        private void insertValuesIntoChart(int[] hrValues, string intervalString)
        {
            int i = 0;
            int interval = int.Parse(intervalString);

            //chart1.ChartAreas[0].AxisY.ScaleView.Zoom(100, 200);
            chart1.ChartAreas[0].AxisY.ScaleView.Zoomable = true;
            chart1.ChartAreas[0].AxisX.ScaleView.Zoomable = true;


            foreach (int value in hrValues)
            {
                chart1.Series[0].Points.AddXY(i, value);
                i += 5;
                //chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            }

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
        private void chart1_MouseWheel(object sender, MouseEventArgs e)
        {
            var chart = (Chart)sender;
            var xAxis = chart.ChartAreas[0].AxisX;
            var yAxis = chart.ChartAreas[0].AxisY;

            try
            {
                if (e.Delta < 0) // Scrolled down.
                {
                    xAxis.ScaleView.ZoomReset();
                    yAxis.ScaleView.ZoomReset();
                }
                else if (e.Delta > 0) // Scrolled up.
                {
                    var xMin = xAxis.ScaleView.ViewMinimum;
                    var xMax = xAxis.ScaleView.ViewMaximum;
                    var yMin = yAxis.ScaleView.ViewMinimum;
                    var yMax = yAxis.ScaleView.ViewMaximum;

                    var posXStart = xAxis.PixelPositionToValue(e.Location.X) - (xMax - xMin) / 4;
                    var posXFinish = xAxis.PixelPositionToValue(e.Location.X) + (xMax - xMin) / 4;
                    var posYStart = yAxis.PixelPositionToValue(e.Location.Y) - (yMax - yMin) / 4;
                    var posYFinish = yAxis.PixelPositionToValue(e.Location.Y) + (yMax - yMin) / 4;

                    xAxis.ScaleView.Zoom(posXStart, posXFinish);
                    yAxis.ScaleView.Zoom(posYStart, posYFinish);
                }
            }
            catch { }
        }
        
    }
}
