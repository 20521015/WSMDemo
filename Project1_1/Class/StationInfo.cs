using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_1.Class
{
    public class StationInfo
    {
        public string stationID { get; set; }
        public string stationName { get; set; }
        public string stationLocation { get; set; }
        public string stationCoordinate { get; set; }
        public StationStatus stationStatus = new StationStatus();
        public List<WeatherData> weatherData = new List<WeatherData>();
        public StationInfo()
        {
        }
        public StationInfo(string ID, string name, string location, string coordinate, StationStatus status)
        {
            stationID = ID;
            stationName = name;
            stationLocation = location;
            stationCoordinate = coordinate;
            stationStatus = status;
        }
    }
}
