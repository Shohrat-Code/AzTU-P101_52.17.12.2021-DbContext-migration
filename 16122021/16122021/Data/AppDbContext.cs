using _16122021.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _16122021.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<Ad> Ads { get; set; }
        public DbSet<AdImage> AdImages { get; set; }
        public DbSet<BanType> BanTypes { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<DriveUnit> DriveUnits { get; set; }
        public DbSet<FuelType> FuelTypes { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Transmission> Transmissions { get; set; }
        public DbSet<Unit> Units { get; set; }
    }
}
