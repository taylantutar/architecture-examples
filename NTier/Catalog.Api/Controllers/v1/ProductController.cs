using System;
using Catalog.Service.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Ecom.Catalog.Api.Controllers.v1
{
    [ApiController]
    [Route("api/[controller]")]
    [Route("api/v{version:apiVersion}/[controller]")]
    [ApiVersion("1.0")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;
        

        public ProductController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            var products = await Task.FromResult(productService.GetAll());
            return Ok(products);
        }
    }
}

