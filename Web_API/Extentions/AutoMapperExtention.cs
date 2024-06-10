
using Final_BLL.Mapping;

namespace Web_API.Extentions
{
    public static class AutoMapperExtention
    {
        public static IServiceCollection AddAutoMapperConfig(this IServiceCollection service)
        {
            service.AddAutoMapper(cfg =>
            {
                cfg.AddProfile(new Mappingprofile());

            }, typeof(Program));

            return service;
        }
    }
}
