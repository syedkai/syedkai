using MyApplication;
using System;
using System.Threading.Tasks;

namespace Lesson3
{
    /// <summary>
    /// Ctrl+K+D
    /// </summary>
    class Program
    {
        /// <summary>
        /// Standard simplified version of Task.Delay.
        /// </summary>
        /// <param name="args"></param>
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello lesson3! Deep dive in .NET 5.0");
           
            // Run sample.
            //await LoopSample();

            RunClassSample();

            Console.WriteLine("Press ay key to exit...");
            Console.ReadLine();
        }

        private static void RunClassSample()
        {
            Console.WriteLine("Please, please enter some text and I will calulate the lenght.");

            var txt = Console.ReadLine();

            var len = MyClass.GetLength(txt);

            Console.WriteLine($"The length of the text is: {len}");
        }

        /// <summary>
        /// Looping sample with task.delay.
        /// </summary>
        /// <returns>N.a.</returns>
        private static async Task LoopSample()
        {
            int n = 100;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Counter {i}.");

                await Task.Delay(500);
            }
        }



        /// <summary>
        /// More complex version with the Task.Delay.
        /// </summary>
        /// <param name="args"></param>
        static void Main2(string[] args)
        {
            Console.WriteLine("Hello lesson3! Deep dive in .NET 5.0");

            int n = 1;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Counter {n}.");

                Task.Delay(10000).ContinueWith((t) =>
                {
                    Console.WriteLine("Done with delay!!");
                })
                    ;
            }

            Console.WriteLine("Press ay key to exit...");
            Console.ReadLine();
        }
    }
}
