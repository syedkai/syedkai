using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using Microsoft.Extensions.Configuration.CommandLine;
namespace Readingconf
{
    class Program
    {
        static ConfigurationBuilder r_builder;
         static IConfigurationRoot r_Config;
        static void Main(string[] args)
        {
            var r_builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: false, reloadOnChange: true).AddEnvironmentVariables();
            if (args != null)
            {
                r_builder.AddCommandLine(args);
            }

            IConfigurationRoot configuration = r_builder.Build();



            r_Config = r_builder.Build();
            Console.WriteLine(r_Config["Setting1"]);
            Console.WriteLine(r_Config["Setting2"]);
            Console.WriteLine(r_Config["Setting3"]);
        }
    }
}