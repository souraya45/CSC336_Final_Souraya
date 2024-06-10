using Final_BLL.DTO;
using Final_BLL.Services._GenericService;
using Final_BLL.Services.Airplanes;
using Microsoft.AspNetCore.Mvc;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AirplaneController : GenericController<AirplaneDTO>
    {
        private  readonly IAirplaneService _airplaneService;
        public AirplaneController(IAirplaneService airplaneService) : base(airplaneService)
        {
            _airplaneService = airplaneService;
        }
    }
}
