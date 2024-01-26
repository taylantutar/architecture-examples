using Product.Application.Repository;
using Product.Persistence.context;
using Product.Persistence.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Product.Persistence
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