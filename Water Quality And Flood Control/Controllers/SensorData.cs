namespace Water_Quality_And_Flood_Control.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SensorData")]
    public partial class SensorData
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(10)]
        [Display(Name = "Name of Location")]
        public string AreaName { get; set; }

        [Key]
        [Column(Order = 1)]
        [Display(Name = "TimeStamp Of Data")]
        public DateTime TimeStamp { get; set; }

        [Display(Name = "Resistance")]
        public decimal? Resistance { get; set; }

        [Display(Name = "Voltage")]
        public decimal? Voltage { get; set; }

        [Range(30, 40)]
        [Display(Name = "Temperature")]
        public decimal? Temperature { get; set; }

        [Range(0, 7)]
        [Display(Name = "pH")]
        public int? PHValue { get; set; }

        [Display(Name = "Dissolved Oxygen")]
        public decimal? DissolvedOxygen { get; set; }

        [StringLength(10)]
        [Display(Name = "Radio Isotope Name")]
        public string RadioIsotopeLevel { get; set; }

        [StringLength(10)]
        [Display(Name = "Stable Isotope Name")]
        public string StableIsotopeLevel { get; set; }

        [Display(Name = "Current Speed")]
        public decimal? CurrentSpeed { get; set; }

        [Range(0, 20)]
        [Display(Name = "Water Level Above Warning Level")]
        public decimal? WaterLevel { get; set; }
    }
}
