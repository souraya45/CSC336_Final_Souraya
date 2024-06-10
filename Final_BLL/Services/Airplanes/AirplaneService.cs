using AutoMapper;
using Final_BLL.DTO;
using Final_BLL.Services._GenericService;
using Final_DAL.Models;
using Final_DAL.Repositories.Airplanes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_BLL.Services.Airplanes
{
    public class AirplaneService : GenericService<Airplane, AirplaneDTO>, IAirplaneService
    {
        public readonly IAirplaneRepository _airplaneRepository;
        public readonly IMapper _mapper;
        public AirplaneService(IAirplaneRepository airplaneRepository, IMapper mapper)
            : base(airplaneRepository, mapper)
        {
            _airplaneRepository = airplaneRepository;
            _mapper = mapper;
        }
    }
}
