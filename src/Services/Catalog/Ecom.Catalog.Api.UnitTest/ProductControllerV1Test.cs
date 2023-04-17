using Ecom.Catalog.Model;
using Ecom.Catalog.Service.Abstract;
using Ecom.Catalog.Api.Controllers.v1;
using Moq;

namespace Ecom.Catalog.Api.UnitTest
{
    public class ProductControllerV1Test
    {
        private readonly Mock<IProductService> _mocRepository;
        private readonly ProductController _productController;
        private readonly List<GetAllProductDto> _products;

        public ProductControllerV1Test()
        {
            _mocRepository = new Mock<IProductService>();
            _productController = new ProductController(_mocRepository.Object);

            _products = new List<GetAllProductDto>{
                new GetAllProductDto{Id=Guid.NewGuid(),Name="Defter",Category= "A"},
                new GetAllProductDto{Id=Guid.NewGuid(),Name="Kalem",Category= "A"},
                new GetAllProductDto{Id=Guid.NewGuid(),Name="Bilgisayar",Category= "B"},
                new GetAllProductDto{Id=Guid.NewGuid(),Name="Tablet",Category= "B"},
                new GetAllProductDto{Id=Guid.NewGuid(),Name="Mouse",Category= "B"},
            };
        }

        [Fact]
        public async void GetProducts_ExecuteAction_ReturnOkWithProducts()
        {
            _mocRepository.Setup(_ => _.GetAll()).Returns(_products);

            //var result = await _productController.Get();
        }
    }
}