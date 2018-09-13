using Entities;
using Interfaces.Business;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business
{
    public class SomethingService : ISomethingService
    {
        public void DoSomething(Something thing)
        {
            WriteThing(thing);
            WriteTime();
            WaitForInput();
        }

        private void WriteThing(Something thing)
        {
            Console.WriteLine(thing.Name);
        }

        private void WriteTime()
        {
            Console.WriteLine("Hello, as horas são: " + DateTime.Now.ToShortTimeString());
        }

        private void WaitForInput()
        {
            Console.Read();
        }
    }
}
