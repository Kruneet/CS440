namespace Water_Quality_And_Flood_Control.Controllers
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class WQAFDS_System : DbContext
    {
        public WQAFDS_System()
            : base("name=WQAFDS_System")
        {
        }

        public virtual DbSet<SensorData> SensorDatas { get; set; }
        public virtual DbSet<UserData> UserDatas { get; set; }
        public virtual DbSet<LocationData> LocationDatas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SensorData>()
                .Property(e => e.AreaName)
                .IsUnicode(false);

            modelBuilder.Entity<SensorData>()
                .Property(e => e.Resistance)
                .HasPrecision(10, 3);

            modelBuilder.Entity<SensorData>()
                .Property(e => e.Voltage)
                .HasPrecision(10, 3);

            modelBuilder.Entity<SensorData>()
                .Property(e => e.Temperature)
                .HasPrecision(10, 3);

            modelBuilder.Entity<SensorData>()
                .Property(e => e.DissolvedOxygen)
                .HasPrecision(10, 3);

            modelBuilder.Entity<SensorData>()
                .Property(e => e.RadioIsotopeLevel)
                .IsUnicode(false);

            modelBuilder.Entity<SensorData>()
                .Property(e => e.StableIsotopeLevel)
                .IsUnicode(false);

            modelBuilder.Entity<SensorData>()
                .Property(e => e.CurrentSpeed)
                .HasPrecision(10, 3);

            modelBuilder.Entity<SensorData>()
                .Property(e => e.WaterLevel)
                .HasPrecision(10, 3);

            modelBuilder.Entity<UserData>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<UserData>()
                .Property(e => e.email)
                .IsUnicode(false);

            modelBuilder.Entity<UserData>()
                .Property(e => e.number)
                .IsUnicode(false);

            modelBuilder.Entity<LocationData>()
                .Property(e => e.AreaName)
                .IsUnicode(false);

            modelBuilder.Entity<LocationData>()
                .Property(e => e.Latitude)
                .HasPrecision(14, 8);

            modelBuilder.Entity<LocationData>()
                .Property(e => e.Longitude)
                .HasPrecision(14, 8);
        }
    }
}
