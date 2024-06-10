using AutoMapper;
using Final_BLL.DTO;
using Final_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_BLL.Mapping
{
    public class Mappingprofile : Profile
    {
        public Mappingprofile()
        {
            CreateMap<Airplane, AirplaneDTO>().ReverseMap();
            CreateMap<Flight, FlightDTO>().ReverseMap();
            CreateMap<Passenger, PassengerDTO>().ReverseMap();
            CreateMap<Pilot, PilotDTO>().ReverseMap();
            CreateMap<Reservation, ReservationDTO>().ReverseMap();




        }
    }
}
