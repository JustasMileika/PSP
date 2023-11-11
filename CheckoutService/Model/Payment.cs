using Commons;

namespace CheckoutService.Model
{
    public class Payment
    {
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public DateTime CreatedDate { get; set; }
        public PaymentType PaymentType { get; set; }
        public Price Amount { get; set; }
    }
}
