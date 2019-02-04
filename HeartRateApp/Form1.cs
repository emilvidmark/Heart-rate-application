using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeartRateApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label1.Text = "Träningsdata: " + File.ReadAllLines("C:/Users/Public/HeartRateApp/user_data.txt")[0].Split('=')[1];
            training1.BringToFront();
            picker.Location = training_button.Location;
            picker.BringToFront();
            training1.load_diary();

        
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            importHrm1.BringToFront();
            picker.Location = import_button.Location;
            picker.BringToFront();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            training1.BringToFront();
            picker.Location = training_button.Location;
            picker.BringToFront();
            training1.load_diary();
           
           

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            manualRegistration1.BringToFront();
            picker.Location = button3.Location;
            picker.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            totalsControl1.BringToFront();
            picker.Location = button2.Location;
            picker.BringToFront();
        }
    }
}
