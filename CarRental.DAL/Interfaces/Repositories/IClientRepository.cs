using CarRental.DAL.Entities;
using CarRental.DAL.Entities.Models;
using CarRental.DAL.Entities.PagedList;
using CarRental.DAL.Interfaces.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.DAL.Interfaces.Repositories
{
    public interface IClientRepository : IGenericRepository<Client>
    {
        Task<PagedList<Client>> GetClients(ClientParameters reviewParameters);
    }
}
