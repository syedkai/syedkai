using System;
using System.Threading.Tasks;
namespace MyApplication
{
    /// <summary>
    /// More simplifies version of Task Delay
    /// </summary>
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello folks! Deep dive in .NET 5.0");
            int n = 100;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"counter {n}.");

                await Task.Delay(500);
               
            }
            Console.WriteLine("Press any key to exit..");
            Console.ReadKey();

        }


        /// <summary>
        /// More complex verion with Task Delay
        /// </summary>


        static void Main2(string[] args)
        {
            Console.WriteLine("Hello folks! Deep dive in .NET 5.0");
            int n = 1;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"counter {n}.");
                Task.Delay(10000).ContinueWith((t) =>
                {
                    Console.WriteLine("Done with delay!");
                });
                ;
            }
            Console.WriteLine("Press any key to exit..");
            Console.ReadKey();

        }
    }
}
