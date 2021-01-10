using System;
using Microsoft.Extensions.Configuration.Json;
using Microsoft.Extensions.Configuration;

namespace nuggetreading
{
    class Program
    {
        private static ConfigurationBuilder conbuilder;
        private static IConfigurationRoot conroot;
        static void Main(string[] args)
        {
             conbuilder = new ConfigurationBuilder();

            conbuilder.AddJsonFile("appsettings.json");
            conbuilder.AddCommandLine(args);
            conroot = conbuilder.Build();
            Console.WriteLine(conroot["Setting1"]);
        }
    }
}
