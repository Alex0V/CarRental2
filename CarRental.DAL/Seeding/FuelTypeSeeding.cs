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
    public class FuelTypeSeeding : ISeeder<FuelType>
    {
        private static readonly List<FuelType> fuelTypes = new List<FuelType>()
        {
            new FuelType()
            {
                Id = 1,
                Fuel_Type ="Бензин",
            },
            new FuelType()
            {
                Id = 2,
                Fuel_Type ="Дизель",
            },
            new FuelType()
            {
                Id = 3,
                Fuel_Type ="Електрика",
            },
        };

        public void Seed(EntityTypeBuilder<FuelType> builder) => builder.HasData(fuelTypes);
    }
}
