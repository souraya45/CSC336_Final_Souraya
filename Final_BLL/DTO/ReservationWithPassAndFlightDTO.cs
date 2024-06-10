using Final_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_BLL.DTO
{
    public class ReservationWithPassAndFlightDTO
    {
        public int ReservationId { get; set; }

        public int? FlightId { get; set; }

        public int? PassengerId { get; set; }

        public string? SeatNumber { get; set; }

        public DateTime? ReservationDate { get; set; }

        public virtual FlightDTO? Flight { get; set; }

        public virtual PassengerDTO? Passenger { get; set; }
    }
}
