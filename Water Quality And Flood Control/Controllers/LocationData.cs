namespace Water_Quality_And_Flood_Control.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LocationData")]
    public partial class LocationData
    {
        [Key]
        [StringLength(10)]
        public string AreaName { get; set; }
        
        public decimal Latitude { get; set; }

        public decimal Longitude { get; set; }

        public string Location { get; set; }

        public string Description { get; set; }
    }
}
