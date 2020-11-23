using System;
using System.Threading.Tasks;

namespace Lesson3
{
    /// <summary>
    /// Ctrl+K+D
    /// </summary>
    class Program
    {
        /// <summary>
        /// Standard simplified version of Task.Delay.
        /// </summary>
        /// <param name="args"></param>
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello lesson3! Deep dive in .NET 5.0");

            int n = 100;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Counter {i}.");

                await Task.Delay(500);
            }

            Console.WriteLine("Press ay key to exit...");
            Console.ReadLine();
        }



        /// <summary>
        /// More complex version with the Task.Delay.
        /// </summary>
        /// <param name="args"></param>
        static void Main2(string[] args)
        {
            Console.WriteLine("Hello lesson3! Deep dive in .NET 5.0");

            int n = 1;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Counter {n}.");

                Task.Delay(10000).ContinueWith((t) =>
                {
                    Console.WriteLine("Done with delay!!");
                })
                    ;
            }

            Console.WriteLine("Press ay key to exit...");
            Console.ReadLine();
        }
    }
}
