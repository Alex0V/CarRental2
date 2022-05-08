using CarRental.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.DAL.Configurations;

namespace CarRental.DAL.Context
{
    public class CarRentalDBContext : DbContext
    {

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<CarType> CarTypes { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<FuelType> FuelTypes { get; set; }
        public DbSet<GearboxType> GearboxTypes { get; set; }
        public DbSet<LocationDetails> LocationDetails { get; set; }


        public CarRentalDBContext(DbContextOptions<CarRentalDBContext> options)
              : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BookingConfig());
            modelBuilder.ApplyConfiguration(new CarConfig());
            modelBuilder.ApplyConfiguration(new CarTypeConfig());
            modelBuilder.ApplyConfiguration(new CityConfig());
            modelBuilder.ApplyConfiguration(new ClientConfig());
            modelBuilder.ApplyConfiguration(new ContactConfig());
            modelBuilder.ApplyConfiguration(new FuelTypeConfig());
            modelBuilder.ApplyConfiguration(new GearboxTypeConfig());
            modelBuilder.ApplyConfiguration(new LocationDetailsConfig());
            modelBuilder.ApplyConfiguration(new ReviewConfig());
        }
    }
}
