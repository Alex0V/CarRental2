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
    public class BookingSeeding : ISeeder<Booking>
    {
        private static readonly List<Booking> booking = new List<Booking>()
        {
            
            new Booking()
            {
                Id = 1,
                FinalPrice = 25000,
                PlaceOfReceiptID = 1,
                PlaceOfReturnID = 1,
                DateTimeOfReceipt = new DateTime(2021, 6, 11, 10 ,0 ,0),
                DateTimeOfReturn = new DateTime(2021, 6, 15, 10 ,0 ,0),
                CarID = 1,
                ClientID = 1,

            },
            new Booking()
            {
                Id = 2,
                FinalPrice = 45000,
                PlaceOfReceiptID = 2,
                PlaceOfReturnID = 2,
                DateTimeOfReceipt = new DateTime(2021, 9, 15, 10 ,0 ,0),
                DateTimeOfReturn = new DateTime(2021, 9, 20, 10 ,0 ,0),
                CarID = 2,
                ClientID = 2,

            },
            new Booking()
            {
                Id = 3,
                FinalPrice = 35000,
                PlaceOfReceiptID = 3,
                PlaceOfReturnID = 3,
                DateTimeOfReceipt = new DateTime(2021, 11, 11, 10 ,0 ,0),
                DateTimeOfReturn = new DateTime(2021, 11, 15, 10 ,0 ,0),
                CarID = 3,
                ClientID = 4,

            },
        };

        public void Seed(EntityTypeBuilder<Booking> builder) => builder.HasData(booking);
    }
}
