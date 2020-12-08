using System;
using System.Threading.Tasks;

namespace Ref_project___Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int n = 10;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Counter{i}");
                // t - temporary variable
                // task.delay - introduce delay in current executing program and
                // do something later
                Task.Delay(20000).ContinueWith((t) =>
                {
                    
                    Console.WriteLine("Done with Delay");

                });

            }
            
        }
    }
}
