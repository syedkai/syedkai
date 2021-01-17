using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.EnvironmentVariables;

namespace read_settings
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("json1.json", optional: false, reloadOnChange: true)
           .AddEnvironmentVariables();
            if (args != null)
            {
                builder.AddCommandLine(args);
            }

            IConfigurationRoot configuration = builder.Build();

            // Following are comming from command line.           
            var Username = configuration["Username"];            
            var Password = configuration["Password"];
            var Email = configuration["Email"];
            Console.WriteLine($"{Username}");
            Console.WriteLine($"{Password}");
            Console.WriteLine($"{Email}");
        }
    }
}
