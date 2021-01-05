using System;
using System.Threading.Tasks;

namespace publish_independent
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Deep dive in NET 5.0");

            int a = 20;

            for (int i = 0; i < a; i++)
            {
                Console.WriteLine($"Counter: {i}");

                await Task.Delay(500);
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
