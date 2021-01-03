using System;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello lesson3!Deep dive in .Net 5.0");

            int n = 100;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Counter {n}.");
                await Task.Delay(1000).ContinueWith((t) =>
                {
                    Console.WriteLine("Done with Delay!!");
                });
                Console.WriteLine("Press any key to exit");
                Console.ReadLine();



            }
        }
    }
}
