using System;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Nugget_Configuration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome");
            var configBuilder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            IConfigurationRoot configuration = configBuilder.Build();
              
            //reading nested values
            var client = configuration.GetSection("ClientDetails");
            Console.WriteLine("The client details are: Name - {0} , Age {1}", client["Name"], client["Age"]);
            
        }
    }
}
