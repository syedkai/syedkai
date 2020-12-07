using MyAnotherCoolLibrary;
using MyCoolLibrary;
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

            await RunClassInstanceSampleAsync();

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();

        }

        private static Task RunClassStaticSampleAsync()
        {
            

            Console.WriteLine("Please enter some text and will be calculated the length");

            var txt = Console.ReadLine();

            var len = Newclass.Calculatelength(txt);

            Console.WriteLine($"Lengthe of the text is: {len}");

            return Task.CompletedTask;
        }

        /// <summary>
        /// Looping sample with task delay.
        /// </summary>
        /// <returns>N.a.</returns>
        private static Task RunClassInstanceSampleAsync()

        {

            while (true)
            {
                Console.WriteLine("Please, please arg 1:");
                var arg1 = Console.ReadLine();

                if (arg1 == "exit")
                    break;

                Console.WriteLine("Please, please arg 2:");
                var arg2 = Console.ReadLine();

                if (arg2 == "exit")
                    break;

                try
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    MyApi apiInstance = new MyApi();

                    double res = apiInstance.Divide(int.Parse(arg1), int.Parse(arg2));

                    Console.WriteLine($"Result of {arg1}/{arg2} = {res}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Your input is not the best. Pls. try again :)");
                }
                finally
                {
                    Console.ResetColor();
                }
            }



            return Task.CompletedTask;
        }

        private static async Task LoopSample()
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
