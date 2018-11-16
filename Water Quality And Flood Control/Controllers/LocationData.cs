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

        [RegularExpression(@"^\$?([0-9]{1,3},([0-9]{3},)*[0-9]{3}|[0-9]+)(.[0-9][0-9]|.)?$", ErrorMessage = "Number is invalid.")]
        public decimal Latitude { get; set; }

        [RegularExpression(@"^\$?([0-9]{1,3},([0-9]{3},)*[0-9]{3}|[0-9]+)(.[0-9][0-9]|.)?$", ErrorMessage = "Number is invalid.")]
        public decimal Longitude { get; set; }
    }
}
