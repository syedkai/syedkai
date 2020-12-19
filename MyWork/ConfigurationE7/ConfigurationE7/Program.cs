using Microsoft.Extensions.Configuration;
using System;
using System.Globalization;
using System.IO;
namespace ConfigurationE7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!,This is E7:Reading Configurations");
            var builder = new ConfigurationBuilder()
                           .AddCommandLine(args)
                           .SetBasePath(Directory.GetCurrentDirectory())
                           .AddJsonFile("appsetting.json", optional: false, reloadOnChange: true)
                           .AddEnvironmentVariables();
            IConfigurationRoot configuration=builder.Build();
            //cmd args
            var clr=configuration["color"];
            var fontsize = configuration["fontsize"];
            var state = configuration["state"];
            Console.WriteLine(clr);
            Console.WriteLine(fontsize);
            Console.WriteLine(state);

            //json configuration
            var IP1= configuration["IP1"];
            var IP2 = configuration["IP2"];
            var IP3 = configuration["IP3"];
            Console.WriteLine(IP1);
            Console.WriteLine(IP2);
            Console.WriteLine(IP3);

            //read sub-section configuration of json file
            var alt = configuration.GetSection("AlternateIps");
            var IP11=alt["IP1"];
            var IP22=alt["IP2"];
            var IP33=alt["IP3"];
            Console.WriteLine(IP11);
            Console.WriteLine(IP22);
            Console.WriteLine(IP33);

            //class
            MySetting my = new MySetting();
            configuration.GetSection("MySettings").Bind(my);
            Console.WriteLine("End");

            //you can: for all config
            MyySetting myy = new MyySetting();
            configuration.Bind(myy);
            Console.WriteLine("End");
        }
    }
}
