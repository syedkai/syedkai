using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace MyConfiguration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My Name is Sourav Paul Sumit");
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

            Console.WriteLine("The configuration setting:");
            Console.WriteLine($"font size = {font_size} and color = {color}");
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
