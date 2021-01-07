using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace MyConfiguration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();
            if (args != null)
            {
                builder.AddCommandLine(args);
            }

            IConfiguration config_param = builder.Build();

            var color = config_param["color"];
            var font_size = config_param["fontSize"];

            Console.WriteLine("Printout some configuration setting");
            Console.WriteLine($"color = {color} and font size is {font_size}");
            Console.WriteLine("Press any key to end session");
            Console.ReadLine();
        }
    }
}
