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
            var Country = configuration["Country"];
            var CountryCode = configuration["CountryCode"];
            var State = configuration["State"];

            //reading environment variables
            // var userName = configuration["USERNAME"];

            //loading settings
            //AllSettings allSettings = new AllSettings();
            //configuration.Bind(allSettings);

            Console.WriteLine($"My Country is {Country}");
            Console.WriteLine($"Country Code is {CountryCode}");
            Console.WriteLine($"State is {State}");
            Console.ReadLine();

        }
    }
}