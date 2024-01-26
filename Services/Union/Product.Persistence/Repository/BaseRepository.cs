using Ecom.Services.Product.Application.Repository;
using Ecom.Services.Product.Domain.Entities;
using Ecom.Services.Product.Persistence.context;
using Microsoft.EntityFrameworkCore;

namespace Ecom.Services.Product.Persistence.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;
        public BaseRepository(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public Task<List<T>> GetAllAsync()
        {
            return _context.Set<T>().ToListAsync();
        }
    }
}