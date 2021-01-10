
using MyfirstLibrary;
using System;
using System.Threading.Tasks;

namespace HelloWorldWithClass
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Hello here we will deep dive in .NET 5.0");

            //Run Loopsample
            //await Looping();

            //Show how to run the static method in the class.
            //await ExecuteClassStaticsampleAsync();

            await ExecuteClasssInstanceampleAsync();

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();

        }

        private static Task ExecuteClassStaticsampleAsync()
        {
            Console.WriteLine("Please enter some text and will be calculated the length");

            var txt = Console.ReadLine();

            var len = Newapi.Calculatelength(txt);

            Console.WriteLine($"Lengthe of the text is: {len}");
            return Task.CompletedTask;
        }

        private static Task ExecuteClasssInstanceampleAsync()
        {

            while (true)
            {
                Console.WriteLine("Please enter Argum 1: ");
                var argm1 = Console.ReadLine();

                if (argm1 == "exit")
                    break;

                Console.WriteLine("Please enter Argum 2: ");
                var argm2 = Console.ReadLine();

                if (argm2 == "exit")
                    break;

                try
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;

                    Newapi apiInstance = new Newapi();

                    double res = apiInstance.Divide(int.Parse(argm1), int.Parse(argm2));
                    Console.WriteLine($"Result of {argm1}/{argm2} = {res}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Your input is incorrect. Please try again :)");
                }

                finally
                {
                    Console.ResetColor();
                }
               
            }


            return Task.CompletedTask;
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

                Console.WriteLine($"Counter{i}.");

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
