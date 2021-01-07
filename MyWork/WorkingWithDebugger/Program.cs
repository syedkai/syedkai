using System;
using System.Threading.Tasks;

namespace WorkingWithDebugger
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("working with debugger");

            int n = 10;

            for (int i = 0; i < n; i++)
            {

                Console.WriteLine($"Value {i}.");
                await Task.Delay(100);
            }

            Console.WriteLine(" Press enter to exit");
            Console.ReadLine();

        }
    }
}