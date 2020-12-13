using System;
using System.IO;
using Configuration.model;
using Microsoft.Extensions.Configuration;

namespace Configuration
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ConfigurationBuilder()
                .AddCommandLine(args)
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables()
                .Build();

            Console.WriteLine("Reading config from cmd Argument");
            var cmdArgLocation = config["location"];
            Console.WriteLine("{0}", cmdArgLocation);
            
            Console.WriteLine("----------------------------------------------------------");

            Console.WriteLine("Reading config from appsettings.json by using key.");
            var username = config["username"];
            var mode = config["mode"];
            Console.WriteLine("Username={0} .. Mode={1}", username, mode);

            Console.WriteLine("----------------------------------------------------------");

            Console.WriteLine("Reading config from appsettings.json (using Typed Settings)");
            UserData userData = new UserData();
            config.GetSection("data").Bind(userData);
            Console.WriteLine("Name={0} .. DOB={1}", userData.Name, userData.Dob);


            Console.WriteLine("----------------------------------------------------------");


            // Read Array from json file
            Console.WriteLine("Reading array of strings from appsettings.json and showing them.");
            var scopes = config.GetSection("scope").Get<string[]>();

            Console.WriteLine("Scopes-------");
            foreach (string scope in scopes)
            {
                System.Threading.Thread.Sleep(300);
                Console.WriteLine(scope);
            }

            Console.ReadLine();
        }
    }
}
