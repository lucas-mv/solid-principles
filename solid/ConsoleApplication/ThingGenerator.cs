using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication
{
    public static class ThingGenerator
    {
        public static Something GenerateSomething()
        {
            return new Something()
            {
                Name = "Eu sou a coisa número " + (new Random()).Next()
            };
        }
    }
}
