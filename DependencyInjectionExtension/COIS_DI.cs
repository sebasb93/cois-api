using COIS_Business.services;
using COIS_Models.cois_contracts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;
using UtilsDB.contracts;
using UtilsDB.service;
using UtilsJson.contracts;
using UtilsJson.service;

namespace DependencyInjectionExtension
{
    public static class COIS_DI
    {
        public static IServiceCollection COIS(this IServiceCollection services)
        {
            // Utils
            services.AddTransient<IDBService, DBService>();
            services.AddSingleton<IConventionRegistryService, ConventionRegistryService>();

            services.AddTransient<IJsonService, JsonService>();

            // Service
            services.AddTransient<IItemBusiness, ItemBusiness>();
            services.AddTransient<ITransactionBusiness, TransactionBusiness>();

            return services;
        }


    }
}
