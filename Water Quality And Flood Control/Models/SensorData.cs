using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Water_Quality_And_Flood_Control.Models
{
    public class SensorData
    {
        public double Resistance { get; set; }
        public double Voltage { get; set; }
        public double Temperature { get; set; }
        public int PHValue{ get; set; }
        public double DissolvedOxygen { get; set; }
        public double RadioIsotopeLevel { get; set; }
        public double StableIsotopeLvl { get; set; }
        public DateTime TimeStamp { get; set; }
        public double CurrentSpeed { get; set; }
        public double WaterLevel { get; set; }
    }

   

}