using Microsoft.Extensions.Configuration;
using System;

namespace ReadingConfiguration
{
    class Program
    {
        static void Main(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .Build();


            var nationality = config["nationality"];
            var color = config["color"];
            Console.WriteLine(nationality);
        }
    }
}
