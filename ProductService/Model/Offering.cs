using Commons;

namespace OfferingService.Model
{
    public class Offering
    {
        public Guid OfferingId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public LoyaltyPoints LoyaltyReward { get; set; }
    }
}
