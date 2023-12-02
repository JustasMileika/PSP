namespace DiscountService.Model
{
    public class Discount
    {
        public Guid DiscountId { get; set; }
        public string Description { get; set; }
        public int DiscountInAmount { get; set; }
        public int DiscountInPercentage { get; set; }
        public DateTime ValidatyStartDate { get; set; }
        public DateTime ValidatyEndDate { get; set; }
        public Guid OfferingId { get; set; }
        public int MinQuantity { get; set; }
    }
}
