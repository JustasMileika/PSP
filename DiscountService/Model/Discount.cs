using Commons;

namespace DiscountService.Model
{
    public class Discount
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public string Description { get; set; }
        public Price DiscountInAmount { get; set; }
        public int DiscountInPercentage { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int MinimumQuantity { get; set; }
    }
}
