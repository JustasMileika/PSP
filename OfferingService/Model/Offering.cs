using Commons;

namespace OfferingService.Model
{
    public class Offering
    {
        public int Id { get; set; }
        public OfferingType OfferingType { get; set; }
        public ServiceConfig? ServiceConfig { get; set; }
        public ProductConfig? ProductConfig { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Price Price { get; set; }
        public LoyaltyPoints LoyaltyCashback { get; set; }
        public IEnumerable<TaxConfig> TaxConfig { get; set; }
    }
}
