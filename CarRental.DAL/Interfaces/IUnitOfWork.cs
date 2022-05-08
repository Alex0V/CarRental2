using CarRental.DAL.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IReviewRepository ReviewRepository { get; }
        IClientRepository ClientRepository { get; }
        Task SaveChangesAsync();
    }
}
