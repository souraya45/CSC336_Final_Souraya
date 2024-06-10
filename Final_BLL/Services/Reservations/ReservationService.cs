using AutoMapper;
using Final_BLL.DTO;
using Final_BLL.Responses;
using Final_BLL.Services._GenericService;
using Final_BLL.Services.Pilots;
using Final_DAL.Models;
using Final_DAL.Repositories.Flights;
using Final_DAL.Repositories.Passengers;
using Final_DAL.Repositories.Pilots;
using Final_DAL.Repositories.Reservations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using static System.Formats.Asn1.AsnWriter;

namespace Final_BLL.Services.Reservations
{
    public class ReservationService : GenericService<Reservation, ReservationDTO>, IReservationService
    {
        public readonly IReservationRepository _reservationRepository;
        public readonly IFlightRepository _flightRepository;
        public readonly IPassengerRepository _passengerRepository;

        public readonly IMapper _mapper;
        public ReservationService(IReservationRepository reservationRepository, IMapper mapper)
            : base(reservationRepository, mapper)
        {
            _reservationRepository = reservationRepository;
            _mapper = mapper;
        }
        public ApiResponse<ReservationWithPassAndFlightDTO> AddReservationWithPassAndFlight(ReservationWithPassAndFlightDTO reservationWithPassAndFlightDTO)
        {
            var response = new ApiResponse<ReservationWithPassAndFlightDTO>();

            using (TransactionScope scope = new TransactionScope(TransactionScopeOption.RequiresNew))
            {
                var flight = _mapper.Map<Flight>(reservationWithPassAndFlightDTO.Flight);
                _flightRepository.Add(flight);

                var passenger = _mapper.Map<Passenger>(reservationWithPassAndFlightDTO.Passenger);
                _passengerRepository.Add(passenger);

                reservationWithPassAndFlightDTO.FlightId = flight.FlightId;
                reservationWithPassAndFlightDTO.PassengerId = passenger.PassengerId;


                var Reservation = _mapper.Map<IEnumerable<Reservation>>(reservationWithPassAndFlightDTO);

                var res = new ReservationWithPassAndFlightDTO();
                res = _mapper.Map<ReservationWithPassAndFlightDTO>(flight);
                res = _mapper.Map<ReservationWithPassAndFlightDTO>(passenger);


                response.Data = res;



                scope.Complete();
            }
            return response;




        }

             



         


        
    }
}
