using Product.Domain.Entities;
using Product.Application.Repository;
using Product.Persistence.context;
using Microsoft.EntityFrameworkCore;

namespace Product.Persistence.Repository
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