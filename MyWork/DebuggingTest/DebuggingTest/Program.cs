using System;
using System.Threading.Tasks;
namespace DebuggingTest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            int i = 0;
            while (true)
            {
                Console.WriteLine($"{i}Hello World");
                Console.WriteLine($"{i}Hello World, we are debugging");

                Console.WriteLine($"{i}Hello World we are debugging2");

                Console.WriteLine($"{i}Hello World we are debugging3");

                await Task.Delay(1000);
                i++;
            }
        }
    }
}
