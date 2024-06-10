using Final_DAL.Models;
using Final_DAL.Repositories._GenericRepository;
using Final_DAL.Repositories.Flights;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_DAL.Repositories.Passengers
{
    public class PassengerRepository : GenericRepository<Passenger>, IPassengerRepository
    {
        public PassengerRepository(AirplaneSystemContext Context) : base(Context) //super
        {

        }
    }
}
