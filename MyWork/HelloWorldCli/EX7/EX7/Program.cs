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
            ConfigurationBuilder builder = new ConfigurationBuilder();
            builder.SetBasePath(Directory.GetCurrentDirectory());
            builder.AddJsonFile("appsettings.json");
            IConfiguration config = builder.Build();
            String Num = config["Setting1"];
            Console.WriteLine(config["Setting1"]);
            Console.ReadLine();
        }
    }
}
