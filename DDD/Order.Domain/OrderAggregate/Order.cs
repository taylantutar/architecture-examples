using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Order.Domain.Core;

namespace Order.Domain.OrderAggregate
{
    public class Order : Entity, IAggregateRoot
    {
        public Address Address { get; private set; }
        public DateTime CreateDate { get; private set; }
        public int CreateBy { get; private set; }
        public int BuyerId { get; private set; }

        private readonly List<OrderItem> _orderItems;

        public IReadOnlyCollection<OrderItem> OrderItems => _orderItems;

        public Order(int buyerId, Address address, int createBy)
        {
            BuyerId = buyerId;
            Address = address;
            CreateBy = createBy;
            CreateDate = DateTime.Now;
            _orderItems = new List<OrderItem>();
        }

        public void AddOrderItem(int productId, string productName, decimal price, int quantity)
        {
            // validations 

            var orderItem = _orderItems.FirstOrDefault(s => s.ProductId == productId);

            if (orderItem != null)
            {
                _orderItems.Add(new OrderItem(productId, productName, price, 1));
            }
            else
            {
                orderItem.UpdateOrderItemQuantity(orderItem.Quantity + 1);
            }

        }

        public decimal GetTotalPrice => _orderItems.Sum(p => p.Price * p.Quantity);


    }
}