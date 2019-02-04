using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeartRateApp
{
    public partial class TrainingListItem : UserControl
    {
        public TrainingListItem()
        {
            InitializeComponent();
            //  title.Text = title_text;
        }

        public TrainingListItem(string id, string title_text, string date, string time, string duration, string maxhr)
        {
            InitializeComponent();
            title.Text = title_text;
            this.date.Text = date;
            this.time.Text = time;
            this.id.Text = id;
            this.duration.Text = duration;
            string imageLocation = getImageLocationForSport(title_text);
            this.pictureBox1.Image = Image.FromFile(imageLocation);
            if (maxhr == "")
            {
                button1.Visible = false;
            }
     

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void duration_Click(object sender, EventArgs e)
        {

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

        private void TrainingListItem_Load(object sender, EventArgs e)
        {

        }

        private void TrainingListItem_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TrainingDetails td = new TrainingDetails(id.Text);
            td.Show();
       
        }

        //string title_text, string date, string time, string duration, string maxhr
    }
}
