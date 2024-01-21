using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Ecom.Services.Product.Application
{
    public static class ServiceRegister
    {
        public static void AddApplicationRegistration(this IServiceCollection services)
        {
            var ass = Assembly.GetExecutingAssembly();
            services.AddMediatR(ass);
        }
    }
}