using SharedKernel.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Data
{
    public class UnitOfWork : IUnitOfWork
    {
        private AppDbContext _context;
        public IRepository Repository { get; }

        public UnitOfWork(AppDbContext context, IRepository repository)
        {
            _context = context;
            Repository = repository;
        }

        public Task SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }
    }
}
