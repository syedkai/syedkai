using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using Microsoft.Extensions.Configuration.CommandLine;

namespace ConsoleApp1

{
    class Program
    {
        private static ConfigurationBuilder m_Builder;
        private static IConfigurationRoot m_Config;
        // private static object appsettings;

        public static void Main(string[] args)
        {
            var m_Builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddEnvironmentVariables();

            if (args != null)
            {
                m_Builder.AddCommandLine(args);
            }


            m_Config = m_Builder.Build();
            Console.WriteLine(m_Config["Setting1"]);
            Console.WriteLine(m_Config["Setting2"]);

        }


    }
}