using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecom.Services.ProductDomain.Entities;

namespace Ecom.Services.Product.Application.Repository
{
    public interface IProductRepository : IBaseRepository<ProductEntity>
    {
    }
}