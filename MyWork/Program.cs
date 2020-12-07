
using System;
using System.Threading.Tasks;

namespace HelloWorldWithClass
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello in this lesson we will deep dive in .NET 5.0");

            //Run Loopsample
            //await Looping();

            ExecuteClasssample();

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();

        }

        private static void ExecuteClasssample()
        {
            
            Console.WriteLine("Please enter some text and will be calculated the length");

            var txt = Console.ReadLine();

            var len = Newclass.Calculatelength(txt);

            Console.WriteLine($"Lengthe of the text is: {len}");

            //return Task.CompletedTask;
        }

        /// <summary>
        /// Looping sample with task delay.
        /// </summary>
        /// <returns>N.a.</returns>
        //<private static Task RunClassInstanceSampleAsync()

        private static async Task Looping()
        {
            int n = 100;

            for (int i = 0; i < n; i++)
            {

                Console.WriteLine($"Counter{i * 2}.");

                await Task.Delay(300);
            }
        }

        static void Main2(string[] args)
        {
            Console.WriteLine("Hello in this lesson we will deep dive in .NET 5.0");

            int n = 1;

            for (int i = 0; i < n; i++)
            {

                Console.WriteLine($"Counter{n}.");

                Task.Delay(10000).ContinueWith((t) =>
                {
                    Console.WriteLine("Done with delay!!");
                });

            }
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();

        }
    }
}
