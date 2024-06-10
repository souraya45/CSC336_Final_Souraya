using Final_BLL.Services.Airplanes;
using Final_BLL.Services.Flights;
using Final_BLL.Services.Passengers;
using Final_BLL.Services.Pilots;
using Final_BLL.Services.Reservations;
using Final_DAL.Repositories.Airplanes;
using Final_DAL.Repositories.Flights;
using Final_DAL.Repositories.Passengers;
using Final_DAL.Repositories.Pilots;
using Final_DAL.Repositories.Reservations;

namespace Web_API.Extentions
{
    public  static class ServiceExtention
    {
        public static IServiceCollection AddService(this IServiceCollection service)
        {
            service.AddScoped<IAirplaneService, AirplaneService>();
            service.AddScoped<IFlightService, FlightService>();
            service.AddScoped<IPassengerService, PassengerService>();
            service.AddScoped<IPilotService, PilotService>();
            service.AddScoped<IReservationService, ReservationService>();



            return service;

        }

    }
}
