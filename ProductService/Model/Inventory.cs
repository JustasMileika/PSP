namespace OfferingService.Model
{
    public class Inventory
    {
        public Guid InventoryId { get; set; }
        public Guid OfferingId { get; set; }
        public int CurrentStock { get; set; }
    }
}
