using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace ConfigurationReader
{
    /// <summary>
    /// Reading Configuration, Reading Files, Reading file
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true) //change appsettings.json file settings to 'copy if newer'
            .AddCommandLine(args)
            .AddEnvironmentVariables();


            IConfigurationRoot configuration = builder.Build();

            //following are coming from command line
            var color = configuration["color"];
            var fontSize = configuration["fontSize"];

            //following are coming from appsettings.json
            var welcomeText = configuration["welcomeText"];
            var age = configuration["age"];
            var result = configuration["result"];

            //reading environment variables
            var userName = configuration["USERNAME"];

            //loading settings
            AllSettings allSettings = new AllSettings();
            configuration.Bind(allSettings);

            Console.WriteLine($"{welcomeText} {userName}");
            Console.WriteLine($"Your age is {age}");
            Console.WriteLine($"Your result is {result} %");
            Console.ReadLine();

        }
    }
}
