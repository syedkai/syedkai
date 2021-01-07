using System;
using System.Threading.Tasks;
namespace WorkingWithDebugger
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Below You Will See Some Variable Values");
            int S = 20;
            for (int P = 5; P < S; P++)
            {
                Console.WriteLine($"Reading Value = {P}.");
                await Task.Delay(200);
            }
            Console.WriteLine(" Please press Enter key to exit ");
            Console.ReadLine();
        }
    }
}