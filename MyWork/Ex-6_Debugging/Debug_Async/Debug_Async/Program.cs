using System;
using System.Threading.Tasks;

namespace Debug_Async
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Debugging my program");
            int count = 100;
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"The count is {i}");
                await Task.Delay(1000);
            }
        }
    }
}
