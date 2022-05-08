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
    public class ClientConfig : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.ClientName)
                   .HasMaxLength(20)
                   .IsRequired();

            builder.Property(e => e.ClientSurename)
                   .HasMaxLength(20)
                   .IsRequired();

            builder.Property(e => e.ClientMiddlename)
                   .HasMaxLength(20)
                   .IsRequired();

            builder.Property(e => e.Gender)
                   .HasMaxLength(20)
                   .IsRequired();

            builder.Property(e => e.Email)
                   .HasMaxLength(40)
                   .IsRequired();

            builder.Property(e => e.PhoneNumber)
                   .HasMaxLength(20)
                   .IsRequired();

            builder.Property(e => e.DateOfBirth)
                   .IsRequired();

            new ClientSeeding().Seed(builder);
        }
    }
}
