using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace ConfigurationReading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            var configBuilder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true).AddCommandLine(args);
            IConfigurationRoot configuration = configBuilder.Build();
            Console.WriteLine("To search anything use {0}", configuration["url"]);
            if (configuration["consoleColor"] == "yellow")
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
            Console.WriteLine("The console color is {0}", configuration["consoleColor"]);
            //reading nested values
            var client = configuration.GetSection("ClientDetails");
            Console.WriteLine("The client details are: Name - {0} , Age {1}",client["Name"],client["Age"]);
            //readign from class could be used for database in future
            SettingsClass classSetting = new SettingsClass();
            configuration.GetSection("ClassSettings").Bind(classSetting);
            var clientCred = configuration.GetSection("ClassSettings");
            Console.WriteLine("The settings in file are {0} ", clientCred["ClientId"]);
            //reading command line
            Console.WriteLine("Reading command line command method {0}", configuration["commandName"]);
        }
    }
}
