using SharedKernel;
using SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Linq.Expressions;

namespace Infrastructure.Data
{
    public class EfRepository : IRepository
    {
        protected readonly AppDbContext DbContext;

        public EfRepository(AppDbContext context)
        {
            DbContext = context;
        }
        public async Task<T> GetByIdAsync<T>(int id) where T : BaseEntity
        {
            return await DbContext.Set<T>().FindAsync(id);
        }

        public async Task<List<T>> ListAsync<T>(Expression<Func<T, bool>> predicate) where T : BaseEntity
        {
            return await DbContext.Set<T>().Where(predicate).ToListAsync<T>();
        }

        public async Task<T> AddAsync<T>(T entity) where T : BaseEntity
        {
            await DbContext.AddAsync(entity);
            return entity;
        }

        public async Task UpdateAsync<T>(T entity) where T : BaseEntity
        {
            await DbContext.AddAsync(entity);
        }

        public async Task DeleteAsync<T>(T entity) where T : BaseEntity
        {
            DbContext.Remove(entity);
            await DbContext.SaveChangesAsync();
        }
    }
}
