using Final_BLL.DTO;
using Final_BLL.Services.Flights;
using Final_BLL.Services.Passengers;
using Microsoft.AspNetCore.Mvc;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengerController :GenericController<PassengerDTO>
    {
        private readonly IPassengerService _passengerService;
        public PassengerController(IPassengerService passengerService) : base(passengerService)
        {
            _passengerService = passengerService;
        }
    }
}
