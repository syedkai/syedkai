using ClassLibrary12;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", true, true);
            IConfigurationRoot config = builder.Build();
            AppSettings settings = config.Get<AppSettings>();
            Smtp smtp = settings.Smtp;
            Console.WriteLine($"Username: {smtp.Username}\nConnectionString: {settings.ConnectionString}");
            Console.WriteLine("Hello World This is my project!");
            Person usman = new Person("Usman Ali");
            Console.WriteLine("Hello I am " + usman.Name);
        }
    }
}
