using System;

namespace DataModel
{
    public class Order
    {
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public decimal Price { get; set; }
        public Int16 OrderStatus { get; set; }
    }
}
