 using System;
using Ecom.Catalog.Model;

namespace Ecom.Catalog.Service.Abstract
{
	public interface IProductService
	{
		public  List<GetAllProductDto> GetAll();
	}
}

