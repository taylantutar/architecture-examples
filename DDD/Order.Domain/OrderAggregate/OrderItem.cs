using Order.Domain.Core;

namespace Order.Domain.OrderAggregate
{
    public class OrderItem : Entity
    {

        public int ProductId { get; private set; }
        public string ProductName { get; private set; }
        public decimal Price { get; private set; }
        public int Quantity { get; private set; }

        public OrderItem(int productId, string productName, decimal price, int quantity)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
            Quantity = quantity;
        }

        // You can write methods like this to update entity
        public void UpdateOrderItemPrice(decimal price)
        {
            Price = price;
        }
        public void UpdateOrderItemQuantity(int quantity)
        {
            Quantity = quantity;
        }

    }
}