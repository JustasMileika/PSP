namespace TaxService.Model
{
    public class Tax
    {
        public Guid TaxId { get; set; }
        public string TaxName { get; set; }
        public int TaxPercentage { get; set; }
    }
}
