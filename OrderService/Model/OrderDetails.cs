namespace OrderService.Model
{
    public class OrderDetails
    {
        public Guid OrderId { get; set; }
        public Guid OfferingId { get; set; }
        public int Quantity { get; set; }
    }
}
