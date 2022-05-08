using CarRental.DAL.Context;
using CarRental.DAL.Data.Repositories.Base;
using CarRental.DAL.Entities;
using CarRental.DAL.Entities.Models;
using CarRental.DAL.Entities.PagedList;
using CarRental.DAL.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DAL.Data.Repositories
{
    public class ReviewRepository : GenericRepository<Review>, IReviewRepository
    {
        public ReviewRepository(CarRentalDBContext dbContext) : base(dbContext)
        {
        }

        public async Task<PagedList<Review>> GetReviews(ReviewParameters reviewParameters)
        {
            return  PagedList<Review>.ToPagedList(this.context.Set<Review>().OrderBy(s =>s.Id),
            reviewParameters.PageNumber,
            reviewParameters.PageSize);
        }

    }
}
