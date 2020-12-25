using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleAppSettings
{
    class Program
    {
        private static ConfigurationBuilder m_Builder;
        private static IConfigurationRoot m_Config;



        static void Main(string[] args)
        {

            Console.WriteLine(Directory.GetCurrentDirectory());
            IConfiguration builder = new ConfigurationBuilder()

           // Fluent API
           //.SetBasePath(filepath2)
           .AddJsonFile("json1.json", optional: true, reloadOnChange: true)
           .AddCommandLine(args)
           .AddEnvironmentVariables()
           .Build();

            var a = builder["Setting2"];                   // using Jason file
            Console.WriteLine($"{a}");

            var b = builder["Setting"];                     // Mentioned in the runtime Debug option in properties
            Console.WriteLine($"{b}");

            b = builder["APPDATA"];                         // Enviourment variable
            Console.WriteLine($"{b}");

            MySetting Set = new MySetting();
            builder.GetSection("SomeInt").Bind(Set);

            b = builder["MySetting:SomeInt"];
            Console.WriteLine($"{b}");


            AllSetting allSettings = new AllSetting();
            builder.Bind(allSettings);
            Console.ReadLine();



        }
    }
}
