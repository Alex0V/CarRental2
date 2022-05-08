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
    public class GearboxTypeSeeding : ISeeder<GearboxType>
    {
        private static readonly List<GearboxType> gearboxTypes = new List<GearboxType>()
        {
            new GearboxType()
            {
                Id = 1,
                Gearbox_Type = "Автомат",
            },
            new GearboxType()
            {
                Id = 2,
                Gearbox_Type = "Механіка",
            },
        };

        public void Seed(EntityTypeBuilder<GearboxType> builder) => builder.HasData(gearboxTypes);
    }
}
