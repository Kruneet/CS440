using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Water_Quality_And_Flood_Control.Models
{
    public class SensorData
    {
        public String AreaName { get; set; }
        public double Resistance { get; set; }
        public int Voltage { get; set; }
        public double Temperature { get; set; }
        public int pH { get; set; }
        public double DissolvedOxygen { get; set; }
        public double RadioIsotopeLvl { get; set; }
        public double StableIsotopeLvl { get; set; }
        public DateTime TimeStamp { get; set; }
        public double CurrentSpeed { get; set; }
        public double WaterLevel { get; set; }
    }
}