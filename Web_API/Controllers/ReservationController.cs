using Final_BLL.DTO;
using Final_BLL.Services.Pilots;
using Final_BLL.Services.Reservations;
using Microsoft.AspNetCore.Mvc;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationController : GenericController<ReservationDTO>
    {
        private readonly IReservationService _reservationService;
        public ReservationController(IReservationService reservationService) : base(reservationService)
        {
            _reservationService = reservationService;
        }
    }
}
