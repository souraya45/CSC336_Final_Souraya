using AutoMapper;
using Final_BLL.DTO;
using Final_BLL.Services._GenericService;
using Final_BLL.Services.Passengers;
using Final_DAL.Models;
using Final_DAL.Repositories.Passengers;
using Final_DAL.Repositories.Pilots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_BLL.Services.Pilots
{
    public class PilotService : GenericService<Pilot, PilotDTO>, IPilotService
    {
        public readonly IPilotRepository _pilotRepository;
        public readonly IMapper _mapper;
        public PilotService(IPilotRepository pilotRepository, IMapper mapper)
            : base(pilotRepository, mapper)
        {
            _pilotRepository = pilotRepository;
            _mapper = mapper;
        }
    }
}
