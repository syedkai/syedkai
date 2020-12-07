using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Ex7
{
    class Program
    {
        static void Main(string[] args)
        {
            ConfigurationBuilder Page1 = new ConfigurationBuilder();
            Page1.SetBasePath(Directory.GetCurrentDirectory());
            Page1.AddJsonFile("appsettings.json");
            IConfiguration XYZ = Page1.Build();
            String Num = XYZ["Setting1"];
            Console.WriteLine(XYZ["Setting1"]);
            Console.ReadLine();
        }
    }
}
