using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleAppSettings
{
    class Program
    {
        



        static void Main(string[] args)
        {
            string filepath = @"C:\Users\ICT\OneDrive\Desktop\vs\MyWork\ExerciseNo7\ExerciseNo7\App2.json";
            Console.WriteLine(Directory.GetCurrentDirectory());
            IConfiguration builder = new ConfigurationBuilder()

           .SetBasePath(filepath)
           .AddJsonFile("App2.json", optional: true, reloadOnChange: true)
           .AddCommandLine(args)
           .AddEnvironmentVariables()
           .Build();

            var Set1 = builder["Setting3"];                  
            Console.WriteLine($"{Set1}");

            var Set2 = builder["Sets"];                     
            Console.WriteLine($"{Set2}");

            Set2 = builder["ProgramFiles"];                         
            Console.WriteLine($"{Set2}");

            //MySetting Set = new MySetting();
            //builder.GetSection("SomeInt").Bind(Set);

            Set2 = builder["MySetting:SomeString"];
            Console.WriteLine($"{Set2}");


            //AllSetting allSettings = new AllSetting();
            //builder.Bind(allSettings);
            Console.ReadLine();



        }
    }
}

