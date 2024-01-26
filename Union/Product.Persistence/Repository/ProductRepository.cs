using Product.Application.Repository;
using Product.Domain.Entities;
using Product.Persistence.context;

namespace Product.Persistence.Repository
{
    public class ProductRepository : BaseRepository<ProductEntity>, IProductRepository
    {

        public ProductRepository(AppDbContext appDbContext) :base (appDbContext)
        {
            
        }
        
    }
}