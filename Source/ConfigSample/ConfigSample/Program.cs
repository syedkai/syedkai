using Microsoft.Extensions.Configuration;
using System;
using System.Globalization;
using System.IO;

namespace ConfigSample
{
    /// <summary>
    /// Demonstrates how to read settings
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            //var timeUtc = DateTime.UtcNow;
            //var time = DateTime.Now;

            //var res1 = float.Parse("7,1", CultureInfo.InvariantCulture);
            //var res2 = float.Parse("7.1", CultureInfo.InvariantCulture);

            Console.WriteLine("Reading configuration sample!");

            var builder = new ConfigurationBuilder()

           // Fluent API


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
            var setting1 = configuration["Setting1"];
            var setting2 = configuration["Setting2"];
            var setting3 = configuration["Setting3"];

            float i = float.Parse(setting3, CultureInfo.InvariantCulture);
            //
            // Demonstrates how to read settings from sub section.
            var section = configuration.GetSection("MySubSettings");
            var subSetting1 = section["Setting1"];
            var subSetting2 = section["Setting2"];
            var subSetting3 = section["Setting3"];


            //
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
