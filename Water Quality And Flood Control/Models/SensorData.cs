using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Water_Quality_And_Flood_Control.Models
{
    public class SensorData
    {
        [Required]
        [StringLength(10)]
        [Display(Name = "Name of Location")]
        public String AreaName { get; set; }

        [Display(Name = "Resistance")]
        public double Resistance { get; set; }

        [Display(Name = "Voltage")]
        public int Voltage { get; set; }

        [Range(30, 40)]
        [Display(Name = "Temperature")]
        public double Temperature { get; set; }

        [Range(0, 7)]
        [Display(Name = "pH")]
        public int pH { get; set; }

        [Display(Name = "Dissolved Oxygen")]
        public double DissolvedOxygen { get; set; }

        [Display(Name = "Radio Isotope Name")]
        public double RadioIsotope { get; set; }

        [Display(Name = "Stable Isotope Name")]
        public double StableIsotope { get; set; }

        [Display(Name = "TimeStamp Of Data")]
        public DateTime TimeStamp { get; set; }

        [Display(Name = "Current Speed")]
        public double CurrentSpeed { get; set; }

        [Range(0,20)]
        [Display(Name = "Water Level Above Warning Level")]
        public double WaterLevel { get; set; }
    }
}