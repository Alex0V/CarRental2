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
    public class GearboxTypeConfig : IEntityTypeConfiguration<GearboxType>
    {
        public void Configure(EntityTypeBuilder<GearboxType> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Gearbox_Type)
                .HasMaxLength(15)
                .IsRequired();

            new GearboxTypeSeeding().Seed(builder);
        }
    }
}
