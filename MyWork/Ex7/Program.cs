using Microsoft.Extensions.Configuration;
using System;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigurationBuilder me = new ConfigurationBuilder();
            me.AddJsonFile("appsettings.json");
            me.SetBasePath(System.IO.Directory.GetCurrentDirectory());
            IConfigurationRoot cr = me.Build();
            Console.WriteLine(cr["Name"]);
            Console.WriteLine(cr["Nationality"]);
            Console.WriteLine(cr["Profession"]);
        }
    }
}
