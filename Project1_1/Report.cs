using Project1_1.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1_1
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
        }
        public Report(List<StationInfo> station)
        {
            InitializeComponent();
            comboBox1.Items.Clear();
            for (int i = 0; i < station.Count; i++)
                comboBox1.Items.Add(station[i].stationID);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(richTextBox1.Text))
            {
                DialogResult result = MessageBox.Show("The detail is empty, do you still want to submit?", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show("Report succesfully submited");
                    this.Close();
                }
                else
                    return;
            }
            else
            {
                MessageBox.Show("Report succesfully submited");
                this.Close();
            }
        }
    }
}
