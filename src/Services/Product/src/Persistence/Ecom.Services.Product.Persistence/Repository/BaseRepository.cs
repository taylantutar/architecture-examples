using Ecom.Services.Product.Application.Repository;
using Ecom.Services.Product.Domain.Entities;

namespace Ecom.Services.Product.Persistence.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        public Task<List<T>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}