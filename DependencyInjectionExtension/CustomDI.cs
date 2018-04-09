using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInjectionExtension
{
    public static class CustomDI
    {
        public static IServiceCollection AddCustomDI(this IServiceCollection services)
        {
            services.COIS();

            return services;
        }
    }
}
