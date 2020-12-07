using System;
using System.Threading.Tasks;

namespace PublishIndependdent
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("NET 5.0");

            int a = 5;

            for(int i=0; i < a; i++) 
            {
                Console.WriteLine($"Counter: {i}");

                await Task.Delay(500);
            }

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
