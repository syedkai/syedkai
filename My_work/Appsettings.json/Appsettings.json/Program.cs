using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.CommandLine;
using Microsoft.Extensions.Configuration.EnvironmentVariables;
using Microsoft.Extensions.Configuration.Json;


namespace ReadConfig_Appsetting.json
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


            var color = configuration["color"];
            var Setting1 = configuration["Setting1"];





            Console.WriteLine("{0}", color);
            Console.WriteLine("{0}", Setting1);

        }
    }
}