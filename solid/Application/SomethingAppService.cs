using Entities;
using Interfaces.Application;
using Interfaces.Business;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application
{
    public class SomethingAppService : ISomethingAppService
    {
        public void DoSomething(Something thing)
        {
            var somethingService = ServiceDependencyInjection.GetSomethingService();
            somethingService.DoSomething(thing);
        }
    }
}
