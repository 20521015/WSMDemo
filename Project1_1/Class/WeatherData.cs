using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_1.Class
{
    public class WeatherData
    {
        public string ID { get; set; }
        public string date { get; set; }
        public string temperature { get; set; }
        public string humidity { get; set; }
        public string windspeed { get; set; }
        public string winddirection { get; set; }
        public string pressure { get; set; }
        public string rainrate { get; set; }
        public WeatherData() { }
        public WeatherData(string ID, string date, string temp, string humid, string winds, string windd, string press, string rain)
        {
            this.ID = ID;
            this.date = date;
            this.temperature = temp;
            this.humidity = humid;
            this.windspeed = winds;
            this.winddirection = windd;
            this.pressure = press;
            this.rainrate = rain;              
        }
    }
}
