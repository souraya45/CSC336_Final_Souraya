using AutoMapper;
using Final_BLL.DTO;
using Final_BLL.Services._GenericService;
using Final_BLL.Services.Flights;
using Final_DAL.Models;
using Final_DAL.Repositories.Flights;
using Final_DAL.Repositories.Passengers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_BLL.Services.Passengers
{
    public class PassengerService : GenericService<Passenger, PassengerDTO>, IPassengerService
    {
        public readonly IPassengerRepository _passengerRepository;
        public readonly IMapper _mapper;
        public PassengerService(IPassengerRepository passengerRepository, IMapper mapper)
            : base(passengerRepository, mapper)
        {
            _passengerRepository = passengerRepository;
            _mapper = mapper;
        }
    }
}
