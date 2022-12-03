
namespace Project1_1
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.stationinfo = new System.Windows.Forms.GroupBox();
            this.label_coordinate = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label_location = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label_stationname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_ID = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.stationstatus = new System.Windows.Forms.GroupBox();
            this.button_config = new System.Windows.Forms.Button();
            this.label_hardware = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label_connection = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label_battery = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label_status = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.weatherdata = new System.Windows.Forms.GroupBox();
            this.checkBox_rainrate = new System.Windows.Forms.CheckBox();
            this.checkBox_pressure = new System.Windows.Forms.CheckBox();
            this.checkBox_windDirection = new System.Windows.Forms.CheckBox();
            this.checkBox_windspeed = new System.Windows.Forms.CheckBox();
            this.checkBox_Humidity = new System.Windows.Forms.CheckBox();
            this.checkBox_temperature = new System.Windows.Forms.CheckBox();
            this.label_rain = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label_pressure = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label_windd = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label_winds = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label_humidity = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label_temperature = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.weatherdataview = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.temperature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.humidity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.windspeed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.winddir = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pressure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rain = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.stationinfo.SuspendLayout();
            this.stationstatus.SuspendLayout();
            this.weatherdata.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weatherdataview)).BeginInit();
            this.SuspendLayout();
            // 
            // stationinfo
            // 
            this.stationinfo.BackColor = System.Drawing.SystemColors.Control;
            this.stationinfo.Controls.Add(this.label_coordinate);
            this.stationinfo.Controls.Add(this.button2);
            this.stationinfo.Controls.Add(this.label7);
            this.stationinfo.Controls.Add(this.label_location);
            this.stationinfo.Controls.Add(this.label5);
            this.stationinfo.Controls.Add(this.label_stationname);
            this.stationinfo.Controls.Add(this.label3);
            this.stationinfo.Controls.Add(this.comboBox_ID);
            this.stationinfo.Controls.Add(this.label2);
            this.stationinfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stationinfo.Location = new System.Drawing.Point(0, 70);
            this.stationinfo.Name = "stationinfo";
            this.stationinfo.Size = new System.Drawing.Size(980, 140);
            this.stationinfo.TabIndex = 0;
            this.stationinfo.TabStop = false;
            this.stationinfo.Text = "Station Info";
            // 
            // label_coordinate
            // 
            this.label_coordinate.AutoSize = true;
            this.label_coordinate.Location = new System.Drawing.Point(620, 83);
            this.label_coordinate.Name = "label_coordinate";
            this.label_coordinate.Size = new System.Drawing.Size(18, 21);
            this.label_coordinate.TabIndex = 7;
            this.label_coordinate.Text = "a";
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Project1_1.Properties.Resources.power_icon_isolated_on_white_background_on_off_button_illustration_free_vector;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Location = new System.Drawing.Point(863, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(56, 54);
            this.button2.TabIndex = 15;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(518, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Coordinate:";
            // 
            // label_location
            // 
            this.label_location.AutoSize = true;
            this.label_location.Location = new System.Drawing.Point(620, 36);
            this.label_location.Name = "label_location";
            this.label_location.Size = new System.Drawing.Size(18, 21);
            this.label_location.TabIndex = 5;
            this.label_location.Text = "a";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(537, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Location:";
            // 
            // label_stationname
            // 
            this.label_stationname.AutoSize = true;
            this.label_stationname.Location = new System.Drawing.Point(163, 83);
            this.label_stationname.Name = "label_stationname";
            this.label_stationname.Size = new System.Drawing.Size(18, 21);
            this.label_stationname.TabIndex = 3;
            this.label_stationname.Text = "a";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Station Name:";
            // 
            // comboBox_ID
            // 
            this.comboBox_ID.FormattingEnabled = true;
            this.comboBox_ID.Location = new System.Drawing.Point(163, 28);
            this.comboBox_ID.Name = "comboBox_ID";
            this.comboBox_ID.Size = new System.Drawing.Size(139, 29);
            this.comboBox_ID.TabIndex = 1;
            this.comboBox_ID.SelectedIndexChanged += new System.EventHandler(this.comboBox_ID_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 21);
            this.label2.TabIndex = 0;
            this.label2.Text = "Station ID:";
            // 
            // stationstatus
            // 
            this.stationstatus.Controls.Add(this.button_config);
            this.stationstatus.Controls.Add(this.label_hardware);
            this.stationstatus.Controls.Add(this.label14);
            this.stationstatus.Controls.Add(this.button1);
            this.stationstatus.Controls.Add(this.label_connection);
            this.stationstatus.Controls.Add(this.label13);
            this.stationstatus.Controls.Add(this.label_battery);
            this.stationstatus.Controls.Add(this.label11);
            this.stationstatus.Controls.Add(this.label_status);
            this.stationstatus.Controls.Add(this.label9);
            this.stationstatus.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stationstatus.Location = new System.Drawing.Point(0, 216);
            this.stationstatus.Name = "stationstatus";
            this.stationstatus.Size = new System.Drawing.Size(980, 140);
            this.stationstatus.TabIndex = 1;
            this.stationstatus.TabStop = false;
            this.stationstatus.Text = "Station Status";
            // 
            // button_config
            // 
            this.button_config.Location = new System.Drawing.Point(801, 82);
            this.button_config.Name = "button_config";
            this.button_config.Size = new System.Drawing.Size(142, 43);
            this.button_config.TabIndex = 16;
            this.button_config.Text = "Configuration";
            this.button_config.UseVisualStyleBackColor = true;
            this.button_config.Click += new System.EventHandler(this.button_config_Click);
            // 
            // label_hardware
            // 
            this.label_hardware.AutoSize = true;
            this.label_hardware.Location = new System.Drawing.Point(620, 94);
            this.label_hardware.Name = "label_hardware";
            this.label_hardware.Size = new System.Drawing.Size(18, 21);
            this.label_hardware.TabIndex = 14;
            this.label_hardware.Text = "a";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(480, 94);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 21);
            this.label14.TabIndex = 13;
            this.label14.Text = "Hardware Status:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(801, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 42);
            this.button1.TabIndex = 12;
            this.button1.Text = "Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_connection
            // 
            this.label_connection.AutoSize = true;
            this.label_connection.Location = new System.Drawing.Point(620, 37);
            this.label_connection.Name = "label_connection";
            this.label_connection.Size = new System.Drawing.Size(18, 21);
            this.label_connection.TabIndex = 11;
            this.label_connection.Text = "a";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(467, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(147, 21);
            this.label13.TabIndex = 10;
            this.label13.Text = "Connection Status:";
            // 
            // label_battery
            // 
            this.label_battery.AutoSize = true;
            this.label_battery.Location = new System.Drawing.Point(163, 94);
            this.label_battery.Name = "label_battery";
            this.label_battery.Size = new System.Drawing.Size(18, 21);
            this.label_battery.TabIndex = 9;
            this.label_battery.Text = "a";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(89, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 21);
            this.label11.TabIndex = 8;
            this.label11.Text = "Battery:";
            // 
            // label_status
            // 
            this.label_status.AutoSize = true;
            this.label_status.Location = new System.Drawing.Point(163, 37);
            this.label_status.Name = "label_status";
            this.label_status.Size = new System.Drawing.Size(18, 21);
            this.label_status.TabIndex = 7;
            this.label_status.Text = "a";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 21);
            this.label9.TabIndex = 6;
            this.label9.Text = "Operating Status:";
            // 
            // weatherdata
            // 
            this.weatherdata.Controls.Add(this.checkBox_rainrate);
            this.weatherdata.Controls.Add(this.checkBox_pressure);
            this.weatherdata.Controls.Add(this.checkBox_windDirection);
            this.weatherdata.Controls.Add(this.checkBox_windspeed);
            this.weatherdata.Controls.Add(this.checkBox_Humidity);
            this.weatherdata.Controls.Add(this.checkBox_temperature);
            this.weatherdata.Controls.Add(this.label_rain);
            this.weatherdata.Controls.Add(this.label21);
            this.weatherdata.Controls.Add(this.label_pressure);
            this.weatherdata.Controls.Add(this.label19);
            this.weatherdata.Controls.Add(this.label_windd);
            this.weatherdata.Controls.Add(this.label17);
            this.weatherdata.Controls.Add(this.label_winds);
            this.weatherdata.Controls.Add(this.label15);
            this.weatherdata.Controls.Add(this.label_humidity);
            this.weatherdata.Controls.Add(this.label12);
            this.weatherdata.Controls.Add(this.label_temperature);
            this.weatherdata.Controls.Add(this.label8);
            this.weatherdata.Controls.Add(this.label6);
            this.weatherdata.Controls.Add(this.label4);
            this.weatherdata.Controls.Add(this.weatherdataview);
            this.weatherdata.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.weatherdata.Location = new System.Drawing.Point(0, 362);
            this.weatherdata.Name = "weatherdata";
            this.weatherdata.Size = new System.Drawing.Size(980, 448);
            this.weatherdata.TabIndex = 2;
            this.weatherdata.TabStop = false;
            this.weatherdata.Text = "Weather Data";
            // 
            // checkBox_rainrate
            // 
            this.checkBox_rainrate.AutoSize = true;
            this.checkBox_rainrate.Location = new System.Drawing.Point(682, 144);
            this.checkBox_rainrate.Name = "checkBox_rainrate";
            this.checkBox_rainrate.Size = new System.Drawing.Size(119, 25);
            this.checkBox_rainrate.TabIndex = 29;
            this.checkBox_rainrate.Text = "Rainfall Rate";
            this.checkBox_rainrate.UseVisualStyleBackColor = true;
            this.checkBox_rainrate.CheckedChanged += new System.EventHandler(this.checkBox_rainrate_CheckedChanged);
            // 
            // checkBox_pressure
            // 
            this.checkBox_pressure.AutoSize = true;
            this.checkBox_pressure.Location = new System.Drawing.Point(560, 144);
            this.checkBox_pressure.Name = "checkBox_pressure";
            this.checkBox_pressure.Size = new System.Drawing.Size(116, 25);
            this.checkBox_pressure.TabIndex = 28;
            this.checkBox_pressure.Text = "Air Pressure";
            this.checkBox_pressure.UseVisualStyleBackColor = true;
            this.checkBox_pressure.CheckedChanged += new System.EventHandler(this.checkBox_pressure_CheckedChanged);
            // 
            // checkBox_windDirection
            // 
            this.checkBox_windDirection.AutoSize = true;
            this.checkBox_windDirection.Location = new System.Drawing.Point(416, 143);
            this.checkBox_windDirection.Name = "checkBox_windDirection";
            this.checkBox_windDirection.Size = new System.Drawing.Size(138, 25);
            this.checkBox_windDirection.TabIndex = 27;
            this.checkBox_windDirection.Text = "Wind Direction";
            this.checkBox_windDirection.UseVisualStyleBackColor = true;
            this.checkBox_windDirection.CheckedChanged += new System.EventHandler(this.checkBox_windDirection_CheckedChanged);
            // 
            // checkBox_windspeed
            // 
            this.checkBox_windspeed.AutoSize = true;
            this.checkBox_windspeed.Location = new System.Drawing.Point(292, 144);
            this.checkBox_windspeed.Name = "checkBox_windspeed";
            this.checkBox_windspeed.Size = new System.Drawing.Size(118, 25);
            this.checkBox_windspeed.TabIndex = 26;
            this.checkBox_windspeed.Text = "Wind Speed";
            this.checkBox_windspeed.UseVisualStyleBackColor = true;
            this.checkBox_windspeed.CheckedChanged += new System.EventHandler(this.checkBox_windspeed_CheckedChanged);
            // 
            // checkBox_Humidity
            // 
            this.checkBox_Humidity.AutoSize = true;
            this.checkBox_Humidity.Location = new System.Drawing.Point(190, 144);
            this.checkBox_Humidity.Name = "checkBox_Humidity";
            this.checkBox_Humidity.Size = new System.Drawing.Size(96, 25);
            this.checkBox_Humidity.TabIndex = 25;
            this.checkBox_Humidity.Text = "Humidity";
            this.checkBox_Humidity.UseVisualStyleBackColor = true;
            this.checkBox_Humidity.CheckedChanged += new System.EventHandler(this.checkBox_Humidity_CheckedChanged);
            // 
            // checkBox_temperature
            // 
            this.checkBox_temperature.AutoSize = true;
            this.checkBox_temperature.Location = new System.Drawing.Point(60, 144);
            this.checkBox_temperature.Name = "checkBox_temperature";
            this.checkBox_temperature.Size = new System.Drawing.Size(122, 25);
            this.checkBox_temperature.TabIndex = 24;
            this.checkBox_temperature.Text = "Temperature";
            this.checkBox_temperature.UseVisualStyleBackColor = true;
            this.checkBox_temperature.CheckedChanged += new System.EventHandler(this.checkBox_temperature_CheckedChanged);
            // 
            // label_rain
            // 
            this.label_rain.AutoSize = true;
            this.label_rain.Location = new System.Drawing.Point(817, 110);
            this.label_rain.Name = "label_rain";
            this.label_rain.Size = new System.Drawing.Size(18, 21);
            this.label_rain.TabIndex = 23;
            this.label_rain.Text = "a";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(707, 110);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(104, 21);
            this.label21.TabIndex = 22;
            this.label21.Text = "Rainfall Rate:";
            // 
            // label_pressure
            // 
            this.label_pressure.AutoSize = true;
            this.label_pressure.Location = new System.Drawing.Point(473, 110);
            this.label_pressure.Name = "label_pressure";
            this.label_pressure.Size = new System.Drawing.Size(18, 21);
            this.label_pressure.TabIndex = 21;
            this.label_pressure.Text = "a";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(366, 110);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(101, 21);
            this.label19.TabIndex = 20;
            this.label19.Text = "Air Pressure:";
            // 
            // label_windd
            // 
            this.label_windd.AutoSize = true;
            this.label_windd.Location = new System.Drawing.Point(150, 110);
            this.label_windd.Name = "label_windd";
            this.label_windd.Size = new System.Drawing.Size(18, 21);
            this.label_windd.TabIndex = 19;
            this.label_windd.Text = "a";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(21, 110);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(123, 21);
            this.label17.TabIndex = 18;
            this.label17.Text = "Wind Direction:";
            // 
            // label_winds
            // 
            this.label_winds.AutoSize = true;
            this.label_winds.Location = new System.Drawing.Point(817, 59);
            this.label_winds.Name = "label_winds";
            this.label_winds.Size = new System.Drawing.Size(18, 21);
            this.label_winds.TabIndex = 17;
            this.label_winds.Text = "a";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(708, 59);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 21);
            this.label15.TabIndex = 16;
            this.label15.Text = "Wind Speed:";
            // 
            // label_humidity
            // 
            this.label_humidity.AutoSize = true;
            this.label_humidity.Location = new System.Drawing.Point(473, 59);
            this.label_humidity.Name = "label_humidity";
            this.label_humidity.Size = new System.Drawing.Size(18, 21);
            this.label_humidity.TabIndex = 15;
            this.label_humidity.Text = "a";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(386, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 21);
            this.label12.TabIndex = 14;
            this.label12.Text = "Humidity:";
            // 
            // label_temperature
            // 
            this.label_temperature.AutoSize = true;
            this.label_temperature.Location = new System.Drawing.Point(150, 59);
            this.label_temperature.Name = "label_temperature";
            this.label_temperature.Size = new System.Drawing.Size(18, 21);
            this.label_temperature.TabIndex = 13;
            this.label_temperature.Text = "a";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 21);
            this.label8.TabIndex = 3;
            this.label8.Text = "Temperature:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Current:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Log:";
            // 
            // weatherdataview
            // 
            this.weatherdataview.AllowUserToOrderColumns = true;
            this.weatherdataview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.weatherdataview.BackgroundColor = System.Drawing.SystemColors.Window;
            this.weatherdataview.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.weatherdataview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.weatherdataview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.weatherdataview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.date,
            this.temperature,
            this.humidity,
            this.windspeed,
            this.winddir,
            this.pressure,
            this.rain});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.weatherdataview.DefaultCellStyle = dataGridViewCellStyle2;
            this.weatherdataview.Location = new System.Drawing.Point(12, 180);
            this.weatherdataview.MultiSelect = false;
            this.weatherdataview.Name = "weatherdataview";
            this.weatherdataview.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.weatherdataview.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.weatherdataview.RowHeadersVisible = false;
            this.weatherdataview.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.weatherdataview.RowTemplate.Height = 25;
            this.weatherdataview.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.weatherdataview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.weatherdataview.Size = new System.Drawing.Size(968, 253);
            this.weatherdataview.TabIndex = 0;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 51;
            // 
            // date
            // 
            this.date.HeaderText = "Date";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // temperature
            // 
            this.temperature.HeaderText = "Temparature (℃)";
            this.temperature.Name = "temperature";
            this.temperature.ReadOnly = true;
            // 
            // humidity
            // 
            this.humidity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.humidity.HeaderText = "Humidity (%)";
            this.humidity.Name = "humidity";
            this.humidity.ReadOnly = true;
            this.humidity.Width = 118;
            // 
            // windspeed
            // 
            this.windspeed.HeaderText = "Wind Speed (mph)";
            this.windspeed.Name = "windspeed";
            this.windspeed.ReadOnly = true;
            // 
            // winddir
            // 
            this.winddir.HeaderText = "Wind Directrion";
            this.winddir.Name = "winddir";
            this.winddir.ReadOnly = true;
            // 
            // pressure
            // 
            this.pressure.HeaderText = "Air Pressure (hPa)";
            this.pressure.Name = "pressure";
            this.pressure.ReadOnly = true;
            // 
            // rain
            // 
            this.rain.HeaderText = "Rainfall Rate (mm)";
            this.rain.Name = "rain";
            this.rain.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(327, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Weather Station Manager";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 807);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.weatherdata);
            this.Controls.Add(this.stationstatus);
            this.Controls.Add(this.stationinfo);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WSM";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.stationinfo.ResumeLayout(false);
            this.stationinfo.PerformLayout();
            this.stationstatus.ResumeLayout(false);
            this.stationstatus.PerformLayout();
            this.weatherdata.ResumeLayout(false);
            this.weatherdata.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weatherdataview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox stationinfo;
        private System.Windows.Forms.GroupBox stationstatus;
        private System.Windows.Forms.GroupBox weatherdata;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_coordinate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_location;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_stationname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_status;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_battery;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView weatherdataview;
        private System.Windows.Forms.Label label_connection;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_winds;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label_humidity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label_temperature;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_rain;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label_pressure;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label_windd;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label_hardware;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button_config;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn temperature;
        private System.Windows.Forms.DataGridViewTextBoxColumn humidity;
        private System.Windows.Forms.DataGridViewTextBoxColumn windspeed;
        private System.Windows.Forms.DataGridViewTextBoxColumn winddir;
        private System.Windows.Forms.DataGridViewTextBoxColumn pressure;
        private System.Windows.Forms.DataGridViewTextBoxColumn rain;
        private System.Windows.Forms.CheckBox checkBox_windspeed;
        private System.Windows.Forms.CheckBox checkBox_Humidity;
        private System.Windows.Forms.CheckBox checkBox_temperature;
        private System.Windows.Forms.CheckBox checkBox_rainrate;
        private System.Windows.Forms.CheckBox checkBox_pressure;
        private System.Windows.Forms.CheckBox checkBox_windDirection;
    }
}