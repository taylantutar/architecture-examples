using Ecom.Services.Product.Application.Mediatr.Query.Product;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Ecom.Services.Product.Presentation.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{

    private readonly ILogger<ProductController> _logger;
    private readonly IMediator _mediator;

    public ProductController(ILogger<ProductController> logger, IMediator mediator)
    {
        _logger = logger;
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> Get()
    {
        var q = new GetAllProductQuery();
        return Ok(await _mediator.Send(q));
    }
}
