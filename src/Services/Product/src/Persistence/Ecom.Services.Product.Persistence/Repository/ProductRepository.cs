using Ecom.Services.Product.Application.Repository;
using Ecom.Services.ProductDomain.Entities;

namespace Ecom.Services.Product.Persistence.Repository
{
    public class ProductRepository : BaseRepository<ProductEntity>, IProductRepository<ProductEntity>
    {
        
    }
}