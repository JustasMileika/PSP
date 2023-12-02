using Commons;

namespace OrderService.Model
{
    public class Order
    {
        public Guid OrderId { get; set; }
        public Guid CustomerId { get; set; }
        public DateTime CreatedDate { get; set; }
        public OrderStatus Status { get; set; }
        public int TipAmount { get; set; }
        public string Feedback { get; set; }
        public IEnumerable<OrderDetails> OrderItems { get; set; }
    }
}
