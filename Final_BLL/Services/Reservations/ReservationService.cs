using AutoMapper;
using Final_BLL.DTO;
using Final_BLL.Services._GenericService;
using Final_BLL.Services.Pilots;
using Final_DAL.Models;
using Final_DAL.Repositories.Pilots;
using Final_DAL.Repositories.Reservations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_BLL.Services.Reservations
{
    public class ReservationService : GenericService<Reservation, ReservationDTO>, IReservationService
    {
        public readonly IReservationRepository _reservationRepository;
        public readonly IMapper _mapper;
        public ReservationService(IReservationRepository reservationRepository, IMapper mapper)
            : base(reservationRepository, mapper)
        {
            _reservationRepository = reservationRepository;
            _mapper = mapper;
        }
    }
}
