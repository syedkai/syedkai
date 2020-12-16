using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;
using System;

namespace E7_ReadingConfigurations
{
    class Program
    {
        private static ConfigurationBuilder m_Builder;
        private static IConfigurationRoot m_Config;

        static void Main(string[] args)
        {
            m_Builder = new ConfigurationBuilder();
            m_Builder.AddJsonFile("appsettings.json");
            m_Builder.AddCommandLine(args);
            m_Config = m_Builder.Build();
            Console.WriteLine(m_Config["Setting1"]);
        }
    }
}
