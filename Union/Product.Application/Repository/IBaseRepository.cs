using Product.Domain.Entities;

namespace Product.Application.Repository
{
    public interface IBaseRepository<T> where T:BaseEntity
    {
        Task<List<T>> GetAllAsync();
    }
}       