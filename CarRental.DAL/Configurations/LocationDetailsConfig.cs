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
    public class LocationDetailsConfig : IEntityTypeConfiguration<LocationDetails>
    {
        public void Configure(EntityTypeBuilder<LocationDetails> builder)
        {
            builder.HasKey(e => e.Id);

            builder.HasOne(e => e.City)
                .WithMany(d => d.LocationDetails)
                .HasForeignKey(e => e.СityID);

            builder.Property(e => e.Street)
                   .HasMaxLength(50)
                   .IsRequired();

            builder.Property(e => e.HouseNumber)
                   .HasMaxLength(10)
                   .IsRequired();

            new LocationDetailsSeeding().Seed(builder);
        }
    }
}
