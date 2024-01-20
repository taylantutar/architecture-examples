using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecom.Services.ProductDomain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Ecom.Services.Product.Persistence.context
{
    public class AppDbContext : DbContext
    {
        public DbSet<ProductEntity> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<ProductEntity>().HasData(
                new ProductEntity { Id = Guid.NewGuid(), Name = "AA", Category = "1A", Price = 10, Quantity = 111 },
                new ProductEntity { Id = Guid.NewGuid(), Name = "BB", Category = "1B", Price = 10, Quantity = 111 },
                new ProductEntity { Id = Guid.NewGuid(), Name = "CC", Category = "1C", Price = 10, Quantity = 111 }
            );

            base.OnModelCreating(modelBuilder);
        }
    }
}