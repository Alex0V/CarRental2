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
    public class CarTypeSeeding : ISeeder<CarType>
    {
        private static readonly List<CarType> carTypes = new List<CarType>()
        {
            new CarType()
            {
                Id = 1,
                Car_Type = "Купе",
            },
            new CarType()
            {
                Id = 2,
                Car_Type = "Кросовер",
            },
            new CarType()
            {
                Id = 3,
                Car_Type = "Універсал",
            },
            new CarType()
            {
                Id = 4,
                Car_Type = "Бюджет",
            },
            new CarType()
            {
                Id = 5,
                Car_Type = "Бізнес",
            },
            new CarType()
            {
                Id = 6,
                Car_Type = "Комфорт",
            },
            new CarType()
            {
                Id = 7,
                Car_Type = "Преміум",
            }
        };


        public void Seed(EntityTypeBuilder<CarType> builder) => builder.HasData(carTypes);
    }
}
