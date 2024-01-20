using Ecom.Services.Product.Application.Mediatr.Query.Product;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ecom.Services.Product.Presentation.Controllers;

[ApiController]
[Route("[controller]")]
public class ProductController : ControllerBase
{

    private readonly ILogger<ProductController> _logger;
    private readonly IMediator mediator;

    public ProductController(ILogger<ProductController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var q = new GetAllProductQuery();
        return Ok(await mediator.Send(q));
    }
}
