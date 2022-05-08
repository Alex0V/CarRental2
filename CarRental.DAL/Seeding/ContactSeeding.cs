using CarRental.DAL.Entities;
using CarRental.DAL.Interfaces;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DAL.Seeding
{
    public class ContactSeeding : ISeeder<Contact>
    {
        private static readonly List<Contact> contact = new List<Contact>()
        {
            new Contact()
            {
                Id = 1,
                LocationID = 1,
                PhoneNumber = "+380 503 456 789",
                Email = "rentuacarKiev@gmail.com",
            },
            new Contact()
            {
                Id = 2,
                LocationID = 2,
                PhoneNumber = "+380 504 456 456",
                Email = "rentuacarLviv@gmail.com",
            },
            new Contact()
            {
                Id = 3,
                LocationID = 3,
                PhoneNumber = "+380 505 567 567",
                Email = "rentuacarOdessa@gmail.com",
            },
            new Contact()
            {
                Id = 4,
                LocationID = 4,
                PhoneNumber = "+380 507 456 321",
                Email = "rentuacarChernivtsi@gmail.com",
            },
        };

        public void Seed(EntityTypeBuilder<Contact> builder) => builder.HasData(contact);
    }
}
