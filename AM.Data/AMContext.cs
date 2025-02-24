using System;
using System.Collections.Generic;
using AM.Core.Domain;
using Microsoft.EntityFrameworkCore;

namespace AM.Data
{
    internal class AMContext : DbContext
    {
        // DbSet properties for the domain models
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Plane> Planes { get; set; }
        public DbSet<Passenger> Passengers { get; set; }
        public DbSet<Traveller> Travellers { get; set; }
        public DbSet<Staff> Staff { get; set; } // Changed 'Staffs' to 'Staff'

        // OnConfiguring method to set up the database connection
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Recommended: Store the connection string in appsettings.json or environment variables
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;
                Initial Catalog = Airport;
                Integrated Security = true");
        }

      
    }
}
