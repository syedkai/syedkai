using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace EX7
{
    class Program
    {
        private static ConfigurationBuilder builder;
        private static IConfigurationRoot config;

        static void Main(string[] args)
        {

            var builder = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
           .AddEnvironmentVariables();
            if (args != null)         
            {               
                builder.AddCommandLine(args);
            }

            IConfiguration config = builder.Build();
            String setting1 = config["Setting1"];
            Console.WriteLine(setting1);
            Console.ReadLine();
        }
    }
}
