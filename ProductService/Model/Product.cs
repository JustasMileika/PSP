using Commons;

namespace ProductService.Model
{
    public class Product
    {
        public int Id { get; set; }
        public ProductType ProductType { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Price Price { get; set; }
        public LoyaltyPoints LoyaltyCashback { get; set; }
        public Stock Stock { get; set; }
    }
}
