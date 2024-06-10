using Final_BLL.DTO;
using Final_BLL.Services.Passengers;
using Final_BLL.Services.Pilots;
using Microsoft.AspNetCore.Mvc;

namespace Web_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PilotController : GenericController<PilotDTO>
    {
        private readonly IPilotService _pilotService;
        public PilotController(IPilotService pilotService) : base(pilotService)
        {
            _pilotService = pilotService;
        }
    }
}
