using Application;
using Interfaces.Application;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication
{
    public static class AppServiceDependencyInjection
    {
        private static ServiceProvider _serviceProvider;
        public static ServiceProvider ServiceProvider
        {
            get
            {
                if(_serviceProvider == null)
                    _serviceProvider = SetupProvider();
                return _serviceProvider;
            }
        }

        private static ServiceProvider SetupProvider()
        {
            var serviceCollection = new ServiceCollection();
            return serviceCollection
                .AddScoped<ISomethingAppService, SomethingAppService>()
                .BuildServiceProvider();
        }

        public static ISomethingAppService GetSomethingAppService()
        {
            return (ISomethingAppService) ServiceProvider.GetService(typeof(ISomethingAppService));
        }
    }
}
