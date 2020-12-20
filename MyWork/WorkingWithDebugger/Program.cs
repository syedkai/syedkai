using System;
using System.Threading.Tasks;

namespace WorkingWithDebugger
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Debugger Test");

            int n = 100;

            for (int i = 0; i <n; i++)
            {

                Console.WriteLine($"Counter {i}.");
                await Task.Delay(500);
            }

            Console.WriteLine(" Press any key to exit");
            Console.ReadLine();

        }
    }
}
