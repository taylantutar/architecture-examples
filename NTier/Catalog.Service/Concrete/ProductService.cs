
using Catalog.Model;
using Catalog.Service.Abstract;
using Catalog.Service.Data;


namespace Catalog.Service.Concrete
{
	public class ProductService : IProductService
	{
        private readonly CatalogContext context;

        public ProductService(CatalogContext context)
		{
            this.context = context;
        }

        public List<GetAllProductDto> GetAll()
        {
            return  context.Products.Select(p => new GetAllProductDto
            {
                Id = p.Id,
                Category = p.Category,
                Name = p.Category
            }).ToList();
        }
    }
}

