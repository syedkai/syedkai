using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace ReadingConfiguration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reading Configuration Test");
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
            var size = configuration["size"];
            Console.WriteLine("From command line - " + " Name:" + name + "  Color:" + color + "  Windows version:" + windows + " size:" + size);
            Console.WriteLine();


            //From root of apppsettings.json
            var message = configuration["Message"];
            var department = configuration["Department"];
            var University = configuration["University"];
            var year = configuration["Year"];
            Console.WriteLine("From appsettings.jason - " + " Message:" + message + "  Dept.:" + department + " University:" + University + " Year:" + year);
            Console.WriteLine();





            //Reads environment variables
            var Computername = configuration["COMPUTERNAME"];
            Console.WriteLine("Reads from environt variable -  Computer name : " + Computername);


            // code for read typed setting
            MySetting mySettings = new MySetting();
            configuration.GetSection("MySetting").Bind(mySettings);
            Console.WriteLine("Reads from Typed setting - " + mySettings.String + "  " + mySettings.Float +"  "+ mySettings.Int );
            

            Console.ReadLine();


        }
    }
}
