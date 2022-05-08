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
    public class ClientSeeding : ISeeder<Client>
    {
        private static readonly List<Client> user = new List<Client>()
        {
            new Client()
            {
                Id = 1,
                ClientName = "Олександр",
                ClientSurename = "Дзюба",
                ClientMiddlename = "Володимирович",
                Gender = "Чоловік",
                Email = "client1@gmail.com",
                PhoneNumber = "+380 500 111 111",
                DateOfBirth = new DateTime(2000, 10, 21)
            },
            new Client()
            {
                Id = 2,
                ClientName = "Денис",
                ClientSurename = "Миронець",
                ClientMiddlename = "Миколайович",
                Gender = "Чоловік",
                Email = "client2@gmail.com",
                PhoneNumber = "+380 500 222 222",
                DateOfBirth = new DateTime(2000, 10, 21)
            },
            new Client()
            {
                Id = 3,
                ClientName = "Сергій",
                ClientSurename = "Гладик",
                ClientMiddlename = "Кирилович",
                Gender = "Чоловік",
                Email = "client3@gmail.com",
                PhoneNumber = "+380 500 333 333",
                DateOfBirth = new DateTime(1987, 07, 11)
            },
            new Client()
            {
                Id = 4,
                ClientName = "Ірина",
                ClientSurename = "Палій",
                ClientMiddlename = "Ігорівна",
                Gender = "Жінка",
                Email = "client4@gmail.com",
                PhoneNumber = "+380 500 444 444",
                DateOfBirth = new DateTime(1990, 02, 01)
            },
        };

        public void Seed(EntityTypeBuilder<Client> builder) => builder.HasData(user);
    }
}
