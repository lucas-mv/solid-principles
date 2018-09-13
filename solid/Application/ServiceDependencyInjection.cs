using Business;
using Interfaces.Business;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public static class ServiceDependencyInjection
    {
        private static ServiceProvider _serviceProvider;
        public static ServiceProvider ServiceProvider
        {
            get
            {
                if (_serviceProvider == null)
                    _serviceProvider = SetupProvider();
                return _serviceProvider;
            }
        }

        private static ServiceProvider SetupProvider()
        {
            var serviceCollection = new ServiceCollection();
            return serviceCollection
                .AddScoped<ISomethingService, SomethingService>()
                .BuildServiceProvider();
        }

        public static ISomethingService GetSomethingService()
        {
            return (ISomethingService) ServiceProvider.GetService(typeof(ISomethingService));
        }
    }
}
