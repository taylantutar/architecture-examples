using Ecom.Services.Product.Application.Repository;
using Ecom.Services.Product.Domain.Entities;
using Ecom.Services.Product.Persistence.context;

namespace Ecom.Services.Product.Persistence.Repository
{
    public class ProductRepository : BaseRepository<ProductEntity>, IProductRepository
    {

        public ProductRepository(AppDbContext appDbContext) :base (appDbContext)
        {
            
        }
        
    }
}