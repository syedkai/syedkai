using System;
using System.IO; // directory 
using Microsoft.Extensions.Configuration; 

namespace E7___Reading_Configuration__Files
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reading config from various sources!");

            var builder = new ConfigurationBuilder() // part of Iconfig..
                .AddCommandLine(args)
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
           
           .AddEnvironmentVariables(); // very end semicolon

            // Builds an IConfiguration with keys and values from the set of providers registered in Sources.
            IConfigurationRoot configuration = builder.Build();

            //Changed argument value from command line - dotnet run --t 17
            var cliargument1 = configuration["t"]; 
            Console.WriteLine("{0}", cliargument1);

            // From root of appsettings.json
            var jsonsetting1 = configuration["a"];
            var jsonsetting2 = configuration["b"];
            var jsonsetting3 = configuration["t"];
            Console.WriteLine("{0}", jsonsetting1);
            Console.WriteLine("{0}", jsonsetting2);
            Console.WriteLine("{0}", jsonsetting3);

            // section of .json file
            var subsection = configuration.GetSection("SectionalSettings");
            var jsonsubsetting1 = subsection["a"];
            var jsonsubsetting2 = subsection["b"];
            var jsonsubsetting3 = subsection["t"];
            Console.WriteLine("{0}", jsonsubsetting1);
            Console.WriteLine("{0}", jsonsubsetting2);
            Console.WriteLine("{0}", jsonsubsetting3);

            // CLI - setx phi 999
            // Read environment variables
            var localphi = configuration["phi"];
            var processornumber = configuration["NUMBER_OF_PROCESSORS"];
            Console.WriteLine(localphi);
            Console.WriteLine(processornumber);

            // read class settings 
            Classsettings mySettings = new Classsettings();
            configuration.GetSection("MySettinga").Bind(mySettings);
            Console.WriteLine(mySettings.Age);
            Console.WriteLine(mySettings.Name);
        }


    }
}
