namespace ReservationService.Model
{
    public class Reservation
    {
        public Guid ReservationId { get; set; }
        public DateTime RservationDate { get; set; }
        public TimeSpan Duration { get; set; }
        public Guid CustomerId { get; set; }
        public Spot spot { get; set; }
    }
}
