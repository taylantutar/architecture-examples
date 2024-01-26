using Product.Domain.Entities;

namespace Product.Application.Repository
{
    public interface IProductRepository : IBaseRepository<ProductEntity>
    {
    }
}