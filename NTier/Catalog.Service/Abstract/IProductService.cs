using Catalog.Model;

namespace Catalog.Service.Abstract
{
	public interface IProductService
	{
		public  List<GetAllProductDto> GetAll();
	}
}

