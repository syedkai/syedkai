using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.CommandLine;
using Microsoft.Extensions.Configuration.EnvironmentVariables;
using Microsoft.Extensions.Configuration.Json;

namespace Nugget
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
           .AddCommandLine(args)
           .AddEnvironmentVariables();


            IConfigurationRoot configuration = builder.Build();


            var guitar = configuration["guitar"];
            var phone = configuration["phone"];



            Console.WriteLine("{0}", guitar);
            Console.WriteLine("{0}", phone);

        }
    }
}
