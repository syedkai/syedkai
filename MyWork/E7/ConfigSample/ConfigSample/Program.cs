using Microsoft.Extensions.Configuration;
using System;
using System.Globalization;
using System.IO;

namespace ConfigSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reading configuration sample!");
            var builder = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
           .AddCommandLine(args)
           .AddEnvironmentVariables();


            IConfigurationRoot configuration = builder.Build();

            //
            // Following are comming from command line.
            var color = configuration["color"];
            Console.WriteLine("{0}", color);

            var fontSize = configuration["fontSize"];
            var state = configuration["state"];

            //
            // From root of appsettings.json
            var Name = configuration["Name"];
            var Course = configuration["Course"];
            var CGPA = configuration["CGPA"];

            //
            // Reads environment variables
            var machineName = configuration["COMPUTERNAME"];
            var processor = configuration["PROCESSOR_IDENTIFIER"];
            var aaaa = configuration["AAAA"];
            //
            // Demonstrates how to read typed settings
            //MySettings mySettings = new MySettings();
            //configuration.GetSection("MySetting").Bind(mySettings);
            //Console.ReadLine();

            //
            // Demonstrate how to load all settings.
            AllSettings allSettings = new AllSettings();
            configuration.Bind(allSettings);

            Console.WriteLine($"{Name}");
            Console.WriteLine($"Your Course name is {Course}");
            Console.WriteLine($"& CGPA is {CGPA}");
            Console.ReadLine();
            //Console.ReadLine();
        }

    }
}
