using Ecom.Services.Product.Application.Repository;
using Ecom.Services.Product.Domain.Entities;
using Ecom.Services.Product.Persistence.context;

namespace Ecom.Services.Product.Persistence.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        public BaseRepository(AppDbContext appDbContext)
        {
        }

        public Task<List<T>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}