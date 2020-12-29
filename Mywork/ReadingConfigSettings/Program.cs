using Microsoft.Extensions.Configuration;
using System;
using System.Globalization;
using System.IO;

namespace ReadingConfigSettings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            var builder = new ConfigurationBuilder()

           .SetBasePath(Directory.GetCurrentDirectory())
           .AddCommandLine(args)
           .AddEnvironmentVariables();


            IConfigurationRoot configuration = builder.Build();


            var cmdInput = configuration["aspect"];
            Console.WriteLine("{0}", cmdInput);

            builder.AddJsonFile("AppConfiguration.json", optional: false, reloadOnChange: true);
            IConfigurationRoot configuration1 = builder.Build();

            var fontSize = configuration1["Font-Family"];
            Console.WriteLine("{0}", fontSize);
            var state = configuration1["Background"];

            var setting1 = configuration1["Background"];
            var setting2 = configuration1["Font-Family"];
            var setting3 = configuration1["Setting3"];

            Console.WriteLine("{0}", setting3);

            float i = float.Parse(setting3, CultureInfo.InvariantCulture);

            var section = configuration1.GetSection("SubSettings");
            var subSetting1 = section["Setting1"];
            var subSetting2 = section["Setting2"];
            var subSetting3 = section["Setting3"];


            //
            // Reads environment variables
            var machineName = configuration1["COMPUTERNAME"];
            var processor = configuration["PROCESSOR_IDENTIFIER"];
            var aaaa = configuration["AAAA"];
            //
            // Demonstrates how to read typed settings
            //MySettings mySettings = new MySettings();
            //configuration.GetSection("MySetting").Bind(mySettings);
            ////Console.ReadLine();

            ////
            //// Demonstrate how to load all settings.
            //AllSettings allsettings = new AllSettings();
            //configuration.Bind(allsettings);


            Console.ReadLine();
        
       }
    }
}
