namespace CheckoutService.Model
{
    public class GiftCard
    {
        public Guid GiftCardId { get; set; }
        public int RemainingValue { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ValidUntilDate { get; set; }
    }
}
