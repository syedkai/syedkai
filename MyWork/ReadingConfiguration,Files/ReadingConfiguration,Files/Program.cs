using Microsoft.Extensions.Configuration;
using System;
using System.Globalization;
using System.IO;


namespace ReadConfiguration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reading configuration sample!");
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true) //change appsettings.json file settings to 'copy if newer'
            .AddCommandLine(args)
            .AddEnvironmentVariables();


            IConfigurationRoot configuration = builder.Build();

            //following are coming from command line
            //var color = configuration["color"];
            //var fontSize = configuration["fontSize"];

            //following are coming from appsettings.json
            var Color = configuration["Color1"];
            var fontSize = configuration["fontSize"];


            //reading environment variables
            // var userName = configuration["USERNAME"];
            var Name = configuration["Name"];
            var Course = configuration["Course"];

            //loading settings
            //AllSettings allSettings = new AllSettings();
            // configuration.Bind(allSettings);
            AllSettings allSettings = new AllSettings();
            configuration.Bind(allSettings);

            Console.WriteLine($"{Name}");
            Console.WriteLine($"Your Course name is : {Course}");
            

            Console.WriteLine($"My Color is {Color1}");
            Console.WriteLine($"Font size is {fontSize}");
            
            Console.ReadLine();

        }
    }
}