using Microsoft.Extensions.Configuration;
using System;

namespace NuggetPackages
{
    class Program
    {
        private static ConfigurationBuilder configurationBuilder ;
        private static IConfigurationRoot configurationRoot;

        static void Main(string[] args)
        {
            configurationBuilder = new ConfigurationBuilder();
            configurationBuilder.AddJsonFile("appsettings.json");
            configurationBuilder.AddCommandLine(args);
            configurationRoot = configurationBuilder.Build();
            Console.WriteLine(configurationRoot["Setting1"]);
        }
    }
}
