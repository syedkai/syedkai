﻿using System;
using System.IO;
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

            var cmdArgLocation = config["location"];
            Console.WriteLine("{0}", cmdArgLocation);


            var username = config["username"];
            var mode = config["mode"];

            Console.WriteLine("Username={0} .. Mode={1}", username, mode);
        }
    }
}
