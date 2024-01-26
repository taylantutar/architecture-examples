

namespace Product.Application.Dtos
{
    public class ProductViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = "";
        public decimal Price { get; set; }
    }
}