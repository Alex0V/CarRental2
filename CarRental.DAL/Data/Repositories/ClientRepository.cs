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
    public class ClientRepository : GenericRepository<Client>, IClientRepository
    {
        public ClientRepository(CarRentalDBContext dbContext) : base(dbContext)
        {
        }

        public async Task<PagedList<Client>> GetClients(ClientParameters clientParameters)
        {
            var clients = this.context.Set<Client>()
                .Where(o => o.DateOfBirth.Year == clientParameters.YearOfBirth)
                .OrderBy(s => s.Id)
                .AsNoTracking();

            return PagedList<Client>.ToPagedList(clients,
            clientParameters.PageNumber,
            clientParameters.PageSize);
        }
    }
}
