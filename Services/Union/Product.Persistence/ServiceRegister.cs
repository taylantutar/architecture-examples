using Ecom.Services.Product.Application.Repository;
using Ecom.Services.Product.Persistence.context;
using Ecom.Services.Product.Persistence.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Ecom.Services.Product.Persistence
{
    public static class ServiceRegister
    {
        public static void AddPersistenceRegistration(this IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(opt =>
            {
                opt.UseInMemoryDatabase("ecommerceDB");
            });

            services.AddTransient<IProductRepository,ProductRepository>();
        }
    }
}