using Microsoft.Extensions.Configuration;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //private string _baseAddress = "http://localhost:5555";

        private static IConfiguration _config;
        static void Main(string[] args)
        {
            IConfiguration _config = new ConfigurationBuilder().AddJsonFile("appsettings.json", true, true).Build();

            var a = _config["inputValue"];
            var b = _config["Setting"];
        }

        static async Task sendrequest()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri(_config["servicebaseaddress"]);
            await client.GetAsync("/api/default/1");
        }
    }
}
