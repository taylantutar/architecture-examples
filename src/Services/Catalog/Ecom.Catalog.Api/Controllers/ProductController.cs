using System;
using Ecom.Catalog.Service.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Ecom.Catalog.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
	{
        private readonly IProductService productService;

        public ProductController(IProductService productService)
		{
            this.productService = productService;
        }

		[HttpGet]
		public ActionResult Get()
		{
			return Ok(productService.GetAll());
		}
	}
}

