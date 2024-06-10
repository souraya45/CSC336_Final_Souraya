using Final_BLL.DTO;
using Final_BLL.Responses;
using Final_BLL.Services._GenericService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_BLL.Services.Reservations
{
    public interface IReservationService : IGenericService<ReservationDTO>
    {
        ApiResponse<ReservationWithPassAndFlightDTO> AddReservationWithPassAndFlight(ReservationWithPassAndFlightDTO reservationWithPassAndFlightDTO);
    }
}
