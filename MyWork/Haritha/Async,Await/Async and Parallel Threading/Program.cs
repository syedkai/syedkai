using System;
using System.Threading.Tasks;



// testing task , await, async functions

namespace Async_and_Parallel_Threading
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Asynchronous, Await Functions");
            int i = 0, n = 100;
            for (i = 0; i < n; i++)
            {
                Console.WriteLine($"{i} - is the count");
                await Task.Delay(1000); // only after delay, next for loop implemented 
                // without await, delay happens separately and writeline happens at one go
            }
        }
    }
}
