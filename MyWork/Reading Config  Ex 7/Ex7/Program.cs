using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace ConfigurationReader
{
    
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("jsconfig.json", optional: false, reloadOnChange: true)
            .AddCommandLine(args)
            .AddEnvironmentVariables();


            IConfigurationRoot configuration = builder.Build();

            //from environment variables
            var user = configuration["USERNAME"];

         

            //from appsettings.json
            var message = configuration["message"];
            var major = configuration["major"];
            var cgpa = configuration["cgpa"];

            //  from command line
            var subject = configuration["subject"];
            var department = configuration["department"];

            //loading settings
            AllSettings allSettings = new AllSettings();
            configuration.Bind(allSettings);

            Console.WriteLine($"{message} {user}");
            Console.WriteLine($"Your major is in {major}");
            Console.WriteLine($"& CGPA is {cgpa} in German Scale");
            Console.ReadLine();

        }
    }
}
