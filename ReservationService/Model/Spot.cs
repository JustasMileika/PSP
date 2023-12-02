namespace ReservationService.Model
{
    public class Spot
    {
        public Guid SpotId { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
    }
}