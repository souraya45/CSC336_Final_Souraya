using Final_BLL.DTO;
using Final_BLL.Services.Airplanes;
using Final_BLL.Services.Flights;
using Microsoft.AspNetCore.Mvc;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FlightController : GenericController<FlightDTO>
    {
        private readonly IFlightService _flightService;
        public FlightController(IFlightService flightService) : base(flightService)
        {
            _flightService = flightService;
        }
    }
}
