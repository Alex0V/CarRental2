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
    public class CityConfig : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.CityName)
                   .HasMaxLength(30)
                   .IsRequired();


            new CitySeeding().Seed(builder);
        }
    }
}
