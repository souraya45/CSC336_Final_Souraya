using Final_DAL.Repositories.Airplanes;
using Final_DAL.Repositories.Flights;
using Final_DAL.Repositories.Passengers;
using Final_DAL.Repositories.Pilots;
using Final_DAL.Repositories.Reservations;

namespace Web_API.Extentions
{
    public  static class RepositoryExtention
    {
        public static IServiceCollection AddRepository(this IServiceCollection service)
        {
            service.AddScoped<IAirplaneRepository, AirplaneRepository>();
            service.AddScoped<IFlightRepository, FlightRepository>();
            service.AddScoped<IPassengerRepository, PassengerRepository>();
            service.AddScoped<IPilotRepository, PilotRepository>();
            service.AddScoped<IReservationRepository, ReservationRepository>();



            return service;
        }
    }
}
