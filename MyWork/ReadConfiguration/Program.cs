using Microsoft.Extensions.Configuration;
using System;
using System.IO;


namespace ReadConfiguration
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true) //change appsettings.json file settings to 'copy if newer'
            .AddCommandLine(args)
            .AddEnvironmentVariables();


            IConfigurationRoot configuration = builder.Build();

            //following are coming from command line
            //var color = configuration["color"];
            //var fontSize = configuration["fontSize"];

            //following are coming from appsettings.json
            var Name = configuration["Name"];
            var Age = configuration["Age"];
            var City = configuration["City"];

            //reading environment variables
            // var userName = configuration["USERNAME"];

            //loading settings
            //AllSettings allSettings = new AllSettings();
            //configuration.Bind(allSettings);

            Console.WriteLine($"My name is {Name}");
            Console.WriteLine($"Age is {Age}");
            Console.WriteLine($"City is {City}");
            Console.ReadLine();

        }
    }
}