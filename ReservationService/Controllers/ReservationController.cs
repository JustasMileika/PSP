using Microsoft.AspNetCore.Mvc;
using ReservationService.Model;

namespace ReservationService.Controllers
{
    [Route("api/reservation")]
    [ApiController]
    public class ReservationController : ControllerBase
    {
        [HttpPost]
        public Reservation AddReservation([FromQuery] Reservation reservation)
        {
            return new Reservation();
        }

        [HttpGet("{reservationId}")]
        public Reservation GetReservation(Guid reservationId)
        {
            return new Reservation();
        }

        [HttpGet("{customerId}")]
        public IEnumerable<Reservation> GetReservations(Guid customerId, bool getUpcomingReservations)
        {
            return new Reservation[] { };
        }

        [HttpPut("{reservationId}")]
        public Reservation EditReservation(Guid reservationId)
        {
            return new Reservation();
        }

        [HttpDelete("{reservationId}")]
        public bool DeleteReservation(Guid reservationId)
        {
            return true;
        }
    }
}
