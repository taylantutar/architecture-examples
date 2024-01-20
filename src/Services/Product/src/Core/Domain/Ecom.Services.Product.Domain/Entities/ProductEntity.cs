using Ecom.Services.Product.Domain.Entities;

namespace Ecom.Services.ProductDomain.Entities;

public class ProductEntity : BaseEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; } = "";
    public string Category { get; set; } = "";
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}
