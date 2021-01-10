using System;
using System.Threading.Tasks;

namespace publish_independent
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Deep Dive in Net 5.0!");

            int n = 30;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Counter {i}.");

                await Task.Delay(500);
            }
        }
    }
}