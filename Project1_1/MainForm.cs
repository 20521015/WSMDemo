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
    public partial class MainForm : Form
    {
        List<StationInfo> station = new List<StationInfo>();
        public MainForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            CreateData();
            reloadform();
        }
        public void CreateData()
        {
            AddStationData("ST01", "HCM", "VietNam", "10°22'33\" N, 106°01'25\" E", "Live", 80, "Online", "Function");
            AddWeatherData(station[station.Count - 1], "01", "02/12/2022", "25", "92", "2.48", "N", "1009", "0.7");
            AddWeatherData(station[station.Count - 1], "02", "03/12/2022", "27", "94", "5.59", "ENE", "1006", "10.5");
            AddWeatherData(station[station.Count - 1], "03", "04/12/2022", "26", "94", "6.83", "NE", "1007", "10.5");
            AddStationData("ST02", "DN", "VietNam", "15°55'20\" N, 107°18'30\" E", "Live", 90, "Online", "Function");
            AddWeatherData(station[station.Count - 1], "01", "02/12/2022", "24", "94", "10.56", "N", "1014", "15.2");
            AddWeatherData(station[station.Count - 1], "02", "03/12/2022", "26", "99", "12.42", "NNE", "1012", "26.4");
            AddWeatherData(station[station.Count - 1], "03", "04/12/2022", "27", "94", "6.83", "ENE", "1013", "10.5");
            AddStationData("ST03", "HN", "VietNam", "20°53' N, 105°44' E", "Live", 95, "Online", "Function");
            AddWeatherData(station[station.Count - 1], "01", "02/12/2022", "21", "94", "3.72", "NE", "1020", "0");
            AddWeatherData(station[station.Count - 1], "02", "03/12/2022", "21", "96", "6.83", "N", "1021", "1.2");
            AddWeatherData(station[station.Count - 1], "03", "04/12/2022", "17", "94", "8.08", "N", "1019", "0.8");
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        public void reloadform(string A="")
        {
            label_stationname.Text = A;
            label_battery.Text = A;
            label_connection.Text = A;
            label_coordinate.Text = A;
            label_location.Text = A;
            label_status.Text = A;
            label_temperature.Text = A;
            label_humidity.Text = A;
            label_winds.Text = A;
            label_windd.Text = A;
            label_pressure.Text = A;
            label_rain.Text = A;
            label_hardware.Text = A;
            checkBox_temperature.CheckState = CheckState.Checked;
            checkBox_Humidity.CheckState = CheckState.Checked;
            checkBox_windspeed.CheckState = CheckState.Checked;
            checkBox_windDirection.CheckState = CheckState.Checked;
            checkBox_pressure.CheckState = CheckState.Checked;
            checkBox_rainrate.CheckState = CheckState.Checked;
            button2.Enabled = false;
            button_config.Enabled = false;
            comboBox_ID.Text = A;
            comboBox_ID.Items.Clear();
            for (int i = 0; i < station.Count; i++)
                comboBox_ID.Items.Add(station[i].stationID);
        }
        public void partReloadForm(string A="")
        {
            label_battery.Text = A;
            label_connection.Text = A;
            label_status.Text = A;
            label_temperature.Text = A;
            label_humidity.Text = A;
            label_winds.Text = A;
            label_windd.Text = A;
            label_pressure.Text = A;
            label_rain.Text = A;
            label_hardware.Text = A;
        }
        public void updateStationInfo()
        {
            int i = comboBox_ID.SelectedIndex;
            label_stationname.Text = station[i].stationName;
            label_battery.Text = Convert.ToString(station[i].stationStatus.battery) + " %";
            label_connection.Text = station[i].stationStatus.connectionstatus;
            label_coordinate.Text = station[i].stationCoordinate;
            label_location.Text = station[i].stationLocation;
            label_status.Text = station[i].stationStatus.operatingstatus;
            label_hardware.Text = station[i].stationStatus.hardwarestatus;

        }
        public void updateWeatherData()
        {
            int k = comboBox_ID.SelectedIndex;
            weatherdataview.Rows.Clear();
            for (int i = 0; i < station[k].weatherData.Count-1; i++)
            {
                weatherdataview.Rows.Add(station[k].weatherData[i].ID, station[k].weatherData[i].date, station[k].weatherData[i].temperature, station[k].weatherData[i].humidity,
                    station[k].weatherData[i].windspeed, station[k].weatherData[i].winddirection, station[k].weatherData[i].pressure, station[k].weatherData[i].rainrate);
            }
            label_temperature.Text = station[k].weatherData[station[k].weatherData.Count - 1].temperature+ "℃";
            label_humidity.Text = station[k].weatherData[station[k].weatherData.Count - 1].humidity+"%";
            label_winds.Text = station[k].weatherData[station[k].weatherData.Count - 1].windspeed+"mph";
            label_windd.Text = station[k].weatherData[station[k].weatherData.Count - 1].winddirection;
            label_pressure.Text = station[k].weatherData[station[k].weatherData.Count - 1].pressure+"hPa";
            label_rain.Text = station[k].weatherData[station[k].weatherData.Count - 1].rainrate+"mm";
        }

        private void comboBox_ID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(comboBox_ID.Text))
            {
                button2.Enabled = true;
                button_config.Enabled = true;
            }
            updateStationInfo();
            updateWeatherData();
            
        }
        public void AddStationData(string ID, string name, string location, string coordinate, string status,int battery, string connection, string hardware)
        {
            StationStatus stationStatus = new StationStatus(status, battery, connection, hardware);  
            StationInfo A = new StationInfo(ID, name, location, coordinate, stationStatus);
            station.Add(A);
        }
        public void AddWeatherData(StationInfo stationI, string ID, string date, string temp, string humid, string winds, string windd, string press, string rain)
        {
            WeatherData A =new WeatherData(ID, date, temp, humid, winds, windd, press, rain);
            stationI.weatherData.Add(A);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Report A = new Report(station);
            A.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label_status.Text=="Live")
            {
                partReloadForm("N/A");
                label_status.Text = "Stopped";
            }
            else
            {
                partReloadForm("");
                updateStationInfo();
                updateWeatherData();
            }
        }

        private void comboBox_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_config_Click(object sender, EventArgs e)
        {
            ConfigForm A = new ConfigForm();
            A.Show();
        }

        private void checkBox_temperature_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_temperature.CheckState == CheckState.Unchecked)
                weatherdataview.Columns[2].Visible = false;
            else
                weatherdataview.Columns[2].Visible = true;
        }

        private void checkBox_Humidity_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_Humidity.CheckState == CheckState.Unchecked)
                weatherdataview.Columns[3].Visible = false;
            else
                weatherdataview.Columns[3].Visible = true;
        }

        private void checkBox_windspeed_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_windspeed.CheckState == CheckState.Unchecked)
                weatherdataview.Columns[4].Visible = false;
            else
                weatherdataview.Columns[4].Visible = true;
        }

        private void checkBox_windDirection_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_windDirection.CheckState == CheckState.Unchecked)
                weatherdataview.Columns[5].Visible = false;
            else
                weatherdataview.Columns[5].Visible = true;
        }

        private void checkBox_pressure_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_pressure.CheckState == CheckState.Unchecked)
                weatherdataview.Columns[6].Visible = false;
            else
                weatherdataview.Columns[6].Visible = true;
        }

        private void checkBox_rainrate_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_rainrate.CheckState == CheckState.Unchecked)
                weatherdataview.Columns[7].Visible = false;
            else
                weatherdataview.Columns[7].Visible = true;
        }
    }
}
