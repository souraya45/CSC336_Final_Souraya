using Final_DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Web_API.Extentions
{
    public static class StartUpExtention
    {
        public static IServiceCollection AddDb(this IServiceCollection service, ConfigurationManager config)
        {
            var ConnectionString = config.GetConnectionString("DefaultConnection");

            service.AddDbContext< AirplaneSystemContext>(options => options.UseSqlServer(ConnectionString));
            return service;
        }
    }
}
