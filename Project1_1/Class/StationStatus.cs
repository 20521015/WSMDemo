using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1_1.Class
{
    public class StationStatus
    {
        public string operatingstatus{ get; set; }
        public int battery { get; set; }
        public string connectionstatus { get; set; }
        public string hardwarestatus { get; set; }

        public StationStatus() { }
        public StationStatus(string status, int battery, string connection, string hardware)
        {
            operatingstatus = status;
            this.battery = battery;
            connectionstatus = connection;
            hardwarestatus = hardware;
        }
    }
}
