using Final_DAL.Models;
using Final_DAL.Repositories._GenericRepository;
using Final_DAL.Repositories.Pilots;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_DAL.Repositories.Reservations
{
    public class ReservationRepository : GenericRepository<Reservation>, IReservationRepository
    {
        public ReservationRepository(AirplaneSystemContext Context) : base(Context) //super
        {

        }
    }
}
