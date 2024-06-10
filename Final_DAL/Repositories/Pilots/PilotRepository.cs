using Final_DAL.Models;
using Final_DAL.Repositories._GenericRepository;
using Final_DAL.Repositories.Passengers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_DAL.Repositories.Pilots
{
    public class PilotRepository : GenericRepository<Pilot>, IPilotRepository
    {
        public PilotRepository(AirplaneSystemContext Context) : base(Context) //super
        {

        }

    }
}
