using Ecom.Catalog.Service.Abstract;
using Ecom.Catalog.Service.Concrete;
using Ecom.Catalog.Service.Data;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;



var builder = WebApplication.CreateBuilder(args);

//***
var environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
IConfiguration config = new ConfigurationBuilder()
                                        .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                                        .AddJsonFile("appsettings.json", optional: false)
                                        .AddJsonFile($"appsettings.{environment}.json", optional: true)
                                        .AddEnvironmentVariables()
                                        .Build();
builder.Configuration.AddConfiguration(config);

builder.Services.AddApiVersioning(opt =>
{
    opt.DefaultApiVersion = new Microsoft.AspNetCore.Mvc.ApiVersion(1, 0);
    opt.AssumeDefaultVersionWhenUnspecified = true;
    opt.ReportApiVersions = true;
    opt.ApiVersionReader = ApiVersionReader.Combine(new UrlSegmentApiVersionReader(),
                                                    new HeaderApiVersionReader("x-api-version"),
                                                    new MediaTypeApiVersionReader("x-api-version")
                                                    );
});
builder.Services.AddVersionedApiExplorer(conf =>
{
    conf.GroupNameFormat = "'v'VVV";
    conf.SubstituteApiVersionInUrl = true;
});


// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//***
builder.Services.AddHealthChecks();
builder.Services.AddDbContext<CatalogContext>();
builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<CatalogContext>();

var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseHealthChecks("/checkhealt");

app.UseAuthorization();

app.MapControllers();

app.Run();

