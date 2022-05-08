using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarRental.BLL.Interfaces.Services;
using CarRental.BLL.Services;

namespace BLL.Registration
{
    public static class ServicesRegistrator
    {
        public static IServiceCollection AddServices(this IServiceCollection services) => services
            .AddTransient<IClientService, ClientService>()
            .AddTransient<IReviewService, ReviewService>()

       ;
    }
}
