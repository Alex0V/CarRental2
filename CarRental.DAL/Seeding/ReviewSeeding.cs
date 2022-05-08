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
    public class ReviewSeeding : ISeeder<Review>
    {
        private static readonly List<Review> review = new List<Review>()
        {
            new Review()
            {
                Id = 1,
                CarID = 1,
                ClientID = 4,
                Rating = "5",
                TextReviews = "Все на вищому рівні.",
            },
            new Review()
            {
                Id = 2,
                CarID = 2,
                ClientID = 3,
                Rating = "5",
                TextReviews = "Все на вищому рівні.",
            },
            new Review()
            {
                Id = 3,
                CarID = 3,
                ClientID = 3,
                Rating = "5",
                TextReviews = "Все на вищому рівні.",
            },
            new Review()
            {
                Id = 4,
                CarID = 4,
                ClientID = 2,
                Rating = "5",
                TextReviews = "Все на вищому рівні.",
            },
            new Review()
            {
                Id = 5,
                CarID = 5,
                ClientID = 1,
                Rating = "5",
                TextReviews = "Все на вищому рівні.",
            },
        };

        public void Seed(EntityTypeBuilder<Review> builder) => builder.HasData(review);
    }
}
