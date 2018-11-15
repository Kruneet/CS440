namespace Water_Quality_And_Flood_Control.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("UserData")]
    public partial class UserData
    {
        [Key]
        [StringLength(10)]
        public string UserName { get; set; }

        [StringLength(25)]
        public string email { get; set; }

        [StringLength(10)]
        public string number { get; set; }
    }
}
