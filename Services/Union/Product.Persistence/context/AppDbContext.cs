using Ecom.Services.Product.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecom.Services.Product.Persistence.context
{
    public class AppDbContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}