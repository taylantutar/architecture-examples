using Ecom.Services.Order.Core.Base;

namespace Ecom.Services.Order.Core
{
    public class Product : Entity
    {

        public string Name { get; set; }
        public string Quantity { get; set; }
        public decimal? UnitPrice { get; set; }
        public short? UnitInStock { get; set; }
        public short? UnitOnOrder { get; set; }
        public short? ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
        public string ProductReason { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public static Product Create(int pid, int cid, string name, string quantity, decimal? unitPrice, short? unitInStock, short? unitOnOrder, short? reorderLevel, bool discontinued, string productReason)
        {
            return new Product
            {
                Id = pid,
                Name = name,
                Quantity = quantity,
                CategoryId = cid,
                UnitPrice = unitPrice,
                UnitInStock = unitInStock,
                UnitOnOrder = unitOnOrder,
                ReorderLevel = reorderLevel,
                Discontinued = discontinued,
                ProductReason = productReason
            };
        }

    }
}