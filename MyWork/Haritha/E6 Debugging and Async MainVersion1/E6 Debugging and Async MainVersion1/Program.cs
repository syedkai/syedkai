using System;
using System.Threading.Tasks;

namespace E6_Debugging_and_Async_MainVersion1
{
    // async task main - return type is task
    // await task.delay()

    //breakpoint attached during first iteration of for loop
    // i value read in immediate window

    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello! testing Async Main in Counter");
            int n = 50;
            for (int i =0; i < n; i++)
            {
                Console.WriteLine($"The count right now is {i}");
                await Task.Delay(1000);
            }
        }
    }
}
