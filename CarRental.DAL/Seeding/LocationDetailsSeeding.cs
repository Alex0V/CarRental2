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
    public class LocationDetailsSeeding : ISeeder<LocationDetails>
    {
        private static readonly List<LocationDetails> locationDetails = new List<LocationDetails>()
        {
            new LocationDetails()
            {
                Id = 1,
                СityID = 1,
                Street = "Глибочицька",
                HouseNumber ="21",
            },
            new LocationDetails()
            {
                Id = 2,
                СityID = 2,
                Street = "Лічаківська",
                HouseNumber ="8",
            },
            new LocationDetails()
            {
                Id = 3,
                СityID = 3,
                Street = "Осипова",
                HouseNumber ="43",
            },
            new LocationDetails()
            {
                Id = 4,
                СityID = 4,
                Street = "Героїв Майдану",
                HouseNumber ="35",
            },
        };

        public void Seed(EntityTypeBuilder<LocationDetails> builder) => builder.HasData(locationDetails);
    }
}
