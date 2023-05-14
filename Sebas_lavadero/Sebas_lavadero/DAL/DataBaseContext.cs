using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Sebas_lavadero.DAL.Entities;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Sebas_lavadero.DAL // se crea la herencia y se estala  los paqutes de framework sacado del video de  clase  11 de abril
{
    public class DataBaseContext : IdentityDbContext<User>
    {
        public DataBaseContext(DbContextOptions<DataBaseContext> options) : base(options)
        {
        }


        public DbSet<Service> Services { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<VehicleDetail> VehicleDetails { get; set; }


      
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Service>().HasIndex(s => s.Name).IsUnique();
            modelBuilder.Entity<Vehicle>().HasIndex(v => v.Plate).IsUnique();
            modelBuilder.Entity<VehicleDetail>().HasIndex(vd => vd.Id).IsUnique();
        }
    }

}
