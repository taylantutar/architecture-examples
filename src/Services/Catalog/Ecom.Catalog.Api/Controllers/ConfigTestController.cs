using Microsoft.AspNetCore.Mvc;

namespace Ecom.CatalogService.Controllers;

[ApiController]
[Route("[controller]")]
public class ConfigTestController : ControllerBase
{
    private readonly ILogger<ConfigTestController> _logger;
    private readonly IConfiguration _configuration;

    public ConfigTestController(ILogger<ConfigTestController> logger, IConfiguration configuration)
    {
        _logger = logger;
        _configuration = configuration;
    }

    [HttpGet(Name = "TestConfig")]
    public string Get()
    {
        return _configuration["ConfigTest"].ToString();
    }
}

