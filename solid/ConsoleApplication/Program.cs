using Entities;
using Interfaces.Application;
using System;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            var somethingAppService = AppServiceDependencyInjection.GetSomethingAppService();
            var thing = ThingGenerator.GenerateSomething();
            somethingAppService.DoSomething(thing);
        }
    }
}
