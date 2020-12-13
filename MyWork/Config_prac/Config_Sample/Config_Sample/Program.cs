using ConfigSample;
using Microsoft.Extensions.Configuration;
using System;
using System.Globalization;
using System.IO;

namespace Config_Sample
{
    class Program
    {
        static void Main(string[] args)
        
        {
            Console.WriteLine("Reading the configuration sample!");

            var builder = new ConfigurationBuilder()
               .AddCommandLine(args)
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            //.AddEnvironmentVariables();

            IConfigurationRoot configuration = builder.Build();

            //From Command line
            var color = configuration["color"];
            Console.WriteLine("{0}", color);

            var fontsize = configuration["fontsize"];
            Console.WriteLine("{0}", fontsize);
            var state = configuration["state"];
            Console.WriteLine("{0}", state);

            //From root of appsettings.json
            var set = new ConfigurationBuilder().AddJsonFile("appsettings.json", optional: false, reloadOnChange: true).Build();
            var setting1 = set["Setting1"];
            var setting2 = set["Setting2"];
            var setting3 = set["Setting3"];

            float i = float.Parse(setting3, CultureInfo.InvariantCulture);

            //Demonstrates how to read settings from sub section
            var section = configuration.GetSection("SubSettings");
            var subsettings1 = section["Setting1"];
            var subsettings2 = section["Setting2"];
            var subsettings3 = section["Setting3"];

            // Reads environment variables
            var machineName = configuration["COMPUTERNAME"];
            var processor = configuration["PROCESSOR_IDENTIFIER"];
            var aaaa = configuration["AAAA"];
            //
            // Demonstrates how to read typed settings
            MySettings mySettings = new MySettings();
            configuration.GetSection("MySetting").Bind(mySettings);
            //Console.ReadLine();

            //
            // Demonstrate how to load all settings.
            AllSettings allSettings = new AllSettings();
            configuration.Bind(allSettings);
            Console.ReadLine();



        }
    }
}
