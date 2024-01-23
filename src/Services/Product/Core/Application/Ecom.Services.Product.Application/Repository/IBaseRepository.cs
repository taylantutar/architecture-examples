

using Ecom.Services.Product.Domain.Entities;

namespace Ecom.Services.Product.Application.Repository
{
    public interface IBaseRepository<T> where T:BaseEntity
    {
        Task<List<T>> GetAllAsync();
    }
}       