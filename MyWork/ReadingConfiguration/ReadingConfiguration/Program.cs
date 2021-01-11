using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace ReadingConfiguration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reading Configuration");
            Console.WriteLine();

            var builder = new ConfigurationBuilder()


            .AddCommandLine(args)
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddEnvironmentVariables();


            IConfigurationRoot configuration = builder.Build();


            

            var name = configuration["name"];
            var color = configuration["color"];
            var windows = configuration["windows"];
            Console.WriteLine("From command line - " + " Name:" + name + "  Color:" + color + "  Windows version:" + windows);
            Console.WriteLine();


            

            var message = configuration["Message"];
            var type = configuration["type"];
            var time = configuration["time"];
            Console.WriteLine("From appsettings.jason - " + " Message:" + message + "  type :" + type + "  Year:" + time);
            Console.WriteLine();



            
            var Processor = configuration["SystemDrive"];
            Console.WriteLine("Reads from environt variable, Processor name : " + Processor);


            // code for read typed setting

            MySetting mySettings = new MySetting();
            configuration.GetSection("MySetting").Bind(mySettings);
            Console.WriteLine("Reads from Typed setting : " + mySettings.String+ " " + mySettings.Float+" "+ mySettings.Int);
            
                       


            


        }
    }
}
