using AutoMapper;
using Final_BLL.DTO;
using Final_BLL.Services._GenericService;
using Final_BLL.Services.Airplanes;
using Final_DAL.Models;
using Final_DAL.Repositories.Flights;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_BLL.Services.Flights
{
    public class FlightService : GenericService<Flight, FlightDTO>, IFlightService
    {
        public readonly IFlightRepository _flightRepository;
        public readonly IMapper _mapper;
        public FlightService(IFlightRepository flightRepository, IMapper mapper)
            : base(flightRepository, mapper)
        {
            _flightRepository = flightRepository;
            _mapper = mapper;
        }
    }
}
