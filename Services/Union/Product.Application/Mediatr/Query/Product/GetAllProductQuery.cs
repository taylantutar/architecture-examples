using Ecom.Services.Product.Application.Dtos;
using Ecom.Services.Product.Application.Repository;
using MediatR;

namespace Ecom.Services.Product.Application.Mediatr.Query.Product
{
    public class GetAllProductQuery : IRequest<List<ProductViewModel>>
    {
        public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<ProductViewModel>>
        {
            private readonly IProductRepository productRepository;

            public GetAllProductQueryHandler(IProductRepository productRepository)
            {
                this.productRepository = productRepository;
            }

            public async Task<List<ProductViewModel>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
            {
                var products = await productRepository.GetAllAsync();
                return products.Select(p => new ProductViewModel
                {
                    Id = p.Id,
                    Name = p.Name,
                    Price = p.Price
                }).ToList();
            }
        }
    }
}