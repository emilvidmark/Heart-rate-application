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
    public partial class ImportHrm : UserControl
    {
        public ImportHrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "HRM file|*.hrm";
            ofd.Title = "Import HRM";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string fileName = ofd.FileName;
                textBox1.Text = fileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fileName = textBox1.Text;
            if (fileName == "") {
                MessageBox.Show("Du måste välja en fil.");

            }
            else {
                HrmReader hrmReader = new HrmReader();
                hrmReader.UploadHrmToDatabase(fileName, textBox2.Text, comboBox1.Text);
                MessageBox.Show("Fil importerad till databasen");
                textBox1.Text = "";
            }
        }
    }
}
