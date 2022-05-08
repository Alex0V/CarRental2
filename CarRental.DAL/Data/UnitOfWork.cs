using CarRental.DAL.Context;
using CarRental.DAL.Interfaces;
using CarRental.DAL.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DAL.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly CarRentalDBContext context;

        public IReviewRepository ReviewRepository { get; }
        public IClientRepository ClientRepository { get; }

        public async Task SaveChangesAsync() => await context.SaveChangesAsync();


        public UnitOfWork
        (
        CarRentalDBContext context,
        IReviewRepository reviewRepository,
        IClientRepository clientRepository
        )
        {
          this.context = context;
            ReviewRepository = reviewRepository;
            ClientRepository = clientRepository;
        }

        
    }
}
