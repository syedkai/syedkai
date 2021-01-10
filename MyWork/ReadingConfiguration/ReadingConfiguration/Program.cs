using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace ReadingConfiguration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reading Configuration sample!");
            Console.WriteLine();

            var builder = new ConfigurationBuilder()


            .AddCommandLine(args)
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddEnvironmentVariables();


            IConfigurationRoot configuration = builder.Build();


            //From command Line

            var name = configuration["name"];
            var color = configuration["color"];
            var windows = configuration["windows"];
            Console.WriteLine("From command line - " + " Name:" + name + "  Color:" + color + "  Windows version:" + windows);
            Console.WriteLine();


            //From root of apppsettings.json

            var message = configuration["Message"];
            var department = configuration["Department"];
            var year = configuration["Year"];
            Console.WriteLine("From appsettings.jason - " + " Message:" + message + "  Dept.:" + department + "  Year:" + year);
            Console.WriteLine();


            //Variable from subsection
            var subSection = configuration.GetSection("SubSection");
            var subSectionMessage = subSection["Message"];
            var subSectionDepartment = subSection["Department"];
            var subSectionYear = subSection["Year"];
            Console.WriteLine("Sub-section fromrom appsettings.jason - " + " Message:" + subSectionMessage + "  Dept.:" + subSectionDepartment + "  Year:" + subSectionYear);
            Console.WriteLine();

            //Reads environment variables
            var Processor = configuration["PROCESSOR_ARCHITECTURE"];
            Console.WriteLine("Reads from environt variable, Processor name : " + Processor);


            // code for read typed setting

            MySetting mySettings = new MySetting();
            configuration.GetSection("MySetting").Bind(mySettings);
            Console.WriteLine("Reads from Typed setting : " + mySettings.String);
            
                        // code for load all setting
                        AllSettings allSettings = new AllSettings();
                        configuration.Bind(allSettings);
            Console.WriteLine("Reads from all settings: " + allSettings.Department);


            Console.ReadLine();


        }
    }
}
