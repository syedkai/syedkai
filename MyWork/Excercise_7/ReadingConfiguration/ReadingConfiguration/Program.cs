using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace ReadingConfiguration
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World for Knugget Package Manager!");

            var builder = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: false, reloadOnChange: true).AddEnvironmentVariables();
            if (args != null)
            {
                builder.AddCommandLine(args);
            }

            IConfigurationRoot configuration = builder.Build();
            // Following are comming from command line.
            var color = configuration["color"];
            var fontSize = configuration["fontSize"];

        }
    }
}