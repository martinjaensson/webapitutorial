using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Api.Entities
{

    public class CityInfoContext : DbContext
    {

        public CityInfoContext(DbContextOptions<CityInfoContext> options): base(options)
        {
            // Creates entities if doesn' exist
            // Database.EnsureCreated();

            // Applies migration on database
            Database.Migrate();
        }
        public DbSet<City> Cities { get; set; }
        public DbSet<PointOfInterest> PointOfInterests { get; set; }

        // One way to provide connection string
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer("connectionstring");
        //    base.OnConfiguring(optionsBuilder);
        //}
    }
}
