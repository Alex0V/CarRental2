using Microsoft.Extensions.DependencyInjection;

namespace TWS.BusinessLogicLayer.Data
{
    public static class AutoMapperRegistrator
    {
        public static IServiceCollection AddMapper(this IServiceCollection services)
        {
            return services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}
