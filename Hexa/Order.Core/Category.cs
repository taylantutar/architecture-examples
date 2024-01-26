using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ecom.Services.Order.Core.Base;

namespace Ecom.Services.Order.Core
{
    public class Category : Entity
    {
        public Category()
        {
            Products = new HashSet<Product>();
        }

        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Product> Products { get; private set; }

        public static Category Create(int id, string name, string description)
        {
            return new Category
            {
                Id = id,
                Name = name,
                Description = description
            };
        }
    }

}