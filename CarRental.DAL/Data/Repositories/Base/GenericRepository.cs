using CarRental.DAL.Context;
using CarRental.DAL.Entities;
using CarRental.DAL.Interfaces.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRental.DAL.Data.Repositories.Base
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : Entity, new()
    {
        protected readonly CarRentalDBContext context;
        private DbSet<T> table;
        public bool AutoSaveChanges { get; set; } = true;

        public GenericRepository(CarRentalDBContext dbContext)
        {
            this.context = dbContext;
            table = context.Set<T>();
        }

        public async void Delete(int id)
        {
            var entity = table.SingleOrDefault(s => s.Id == id);
            table.Remove(entity);
            await context.SaveChangesAsync();
        }
        public async Task<IEnumerable<T>> GetAll()
        {
            return await table.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await table.FindAsync(id);
        }

        public async Task Insert(T obj)
        {
            table.Add(obj);
            await context.SaveChangesAsync();
        }

        public async void Update(T obj)
        {
            var entity = table.SingleOrDefault(s => s.Id == obj.Id);
            table.Update(entity);
            await context.SaveChangesAsync();
        }
    }
}
