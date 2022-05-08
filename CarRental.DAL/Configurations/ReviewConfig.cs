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
    public class ReviewConfig : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Rating)
                   .HasMaxLength(1)
                   .IsRequired();

            builder.Property(e => e.TextReviews)
                   .HasMaxLength(100)
                   .IsRequired();

            builder.HasOne(e => e.Car)
                .WithMany(d => d.Reviews)
                .HasForeignKey(k => k.CarID);

            builder.HasOne(e => e.Client)
                .WithMany(d => d.Reviews)
                .HasForeignKey(k => k.ClientID);


            new ReviewSeeding().Seed(builder);
        }
    }
}
