using MyApplication2;
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

            //Run  sample
            //await LoopSample();

            RunClassSample();

            Console.WriteLine("Press any key to exit..");
            Console.ReadKey();
            
        }

        private static void RunClassSample()
        {
            Console.WriteLine("Please enter some text and I'll calcute the length of the text.");

            var txt = Console.ReadLine();

            var len = MyClass.GetLength(txt);

            Console.WriteLine($"The Length of the Text is: {len}");
        }


        /// <summary>
        /// Looping samplem with task.delay
        /// </summary>
        /// <returns>N.a.</returns>
        private static async Task LoopSample()
        {
            int n = 100;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"counter {i}.");

                await Task.Delay(500);

            }
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
