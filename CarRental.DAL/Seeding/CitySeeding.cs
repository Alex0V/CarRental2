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
    public class CitySeeding : ISeeder<City>
    {
        private static readonly List<City> cities = new List<City>()
        {
            new City()
            {
                Id = 1,
                CityName = "Київ",
            },
            new City()
            {
                Id = 2,
                CityName = "Львів",
            },
            new City()
            {
                Id = 3,
                CityName = "Одеса",
            },
            new City()
            {
                Id = 4,
                CityName = "Чернівці",
            },
        };

        public void Seed(EntityTypeBuilder<City> builder) => builder.HasData(cities);
    }
}
