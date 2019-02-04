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
    public partial class training : UserControl
    {
        public training()
        {
  
            InitializeComponent();


        }


        private void training_Load(object sender, EventArgs e)
        {
            load_diary();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        public void load_diary()
        {

            Label label = title1;
            this.Controls.Clear();
            this.Controls.Add(label);
            string connectionString = "Server=127.0.0.1;Port=3306;Database=mydb;Uid=root;password=root";
            MySqlConnection connection = new MySqlConnection(connectionString);
            MySqlCommand command = connection.CreateCommand();
            string userName = File.ReadAllLines("C:/Users/Public/HeartRateApp/user_data.txt")[0].Split('=')[1];
            command.CommandText = "SELECT * FROM training_sessions WHERE username = @username ORDER BY date DESC;";
            command.Parameters.AddWithValue("@username", userName);

            try
            {
                int row = 1;
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TrainingListItem tls = new TrainingListItem(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(), reader[3].ToString(), reader[4].ToString(), reader[6].ToString());
                    
                    
                    tls.Location = new Point(250, 150 * row);
                    row++;
                    this.Controls.Add(tls);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

   
    }
}
