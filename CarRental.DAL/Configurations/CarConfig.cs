using CarRental.DAL.Entities;
using CarRental.DAL.Seeding;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DAL.Configurations
{
    public class CarConfig : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.CarName)
                   .HasMaxLength(30)
                   .IsRequired();

            builder.Property(e => e.LicensePlates)
                   .HasMaxLength(30)
                   .IsRequired();

            builder.Property(e => e.Price)
                   .IsRequired();

            builder.Property(e => e.Pledge)
                   .IsRequired();

            builder.Property(e => e.PassengerSeats)
                   .HasMaxLength(2)
                   .IsRequired();

            builder.Property(e => e.TrunkVolume)
                   .HasMaxLength(4)
                   .IsRequired();

            builder.Property(e => e.FuelConsumption)
                   .HasMaxLength(15)
                   .IsRequired();

            builder.Property(e => e.NumberOfDoors)
                   .HasMaxLength(1)
                   .IsRequired();

            builder.HasOne(e => e.GearboxType)
                .WithMany(d => d.Cars)
                .HasForeignKey(k => k.GearboxTypeID);

            builder.Property(e => e.EngineCapacity)
                   .HasMaxLength(3)
                   .IsRequired();

            builder.HasOne(e => e.FuelType)
                .WithMany(d => d.Cars)
                .HasForeignKey(k => k.FuelTypeID);

            builder.HasOne(e => e.CarType)
                .WithMany(d => d.Cars)
                .HasForeignKey(k => k.CarTypeID);

            builder.Property(e => e.FotoName)
                   .HasMaxLength(30)
                   .IsRequired();


            new CarSeeding().Seed(builder);
        }
    }
}
