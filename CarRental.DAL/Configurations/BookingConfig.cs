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
    public class BookingConfig : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.FinalPrice)
                   .IsRequired();

            builder.HasOne(e => e.Place1)
                .WithMany(d => d.Bookings1)
                .HasForeignKey(k => k.PlaceOfReceiptID);

            builder.HasOne(e => e.Place2)
                .WithMany(d => d.Bookings2)
                .HasForeignKey(k => k.PlaceOfReturnID);

            builder.Property(e => e.DateTimeOfReceipt)
                   .IsRequired();

            builder.Property(e => e.DateTimeOfReturn)
                   .IsRequired();

            builder.HasOne(e => e.Car)
                .WithMany(d => d.Bookings)
                .HasForeignKey(k => k.CarID);

            builder.HasOne(e => e.Client)
                .WithMany(d => d.Bookings)
                .HasForeignKey(k => k.ClientID);

            new BookingSeeding().Seed(builder);

        }
    }
}
