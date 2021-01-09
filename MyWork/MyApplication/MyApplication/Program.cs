using MyCoolLibrary;
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
            Console.WriteLine("If you want to exit, pass exit command in the arguments. Thank You :)");

            //Run  sample
            //await LoopSample();

            //await RunClassStaticSampleAsync();                          //show how to run static method in the class.

            await RunClassInstanceSampleAsync();

            Console.WriteLine("Press any key to exit..");
            Console.ReadLine();
            
        }
        private static Task RunClassStaticSampleAsync()
        {
            Console.WriteLine("Please enter some text and I'll calcute the length of the text.");

            var txt = Console.ReadLine();

            var len = MyApi.GetLength(txt);                                                   //using static method

            Console.WriteLine($"The Length of the Text is: {len}");

            return Task.CompletedTask;
        }
        private static Task RunClassInstanceSampleAsync()
        {
           
            while (true)
            {
               

                Console.WriteLine("Please enter arg 1:");
                var arg1 = Console.ReadLine();

                if (arg1 == "exit")
                {
                    break;
                }

                Console.WriteLine("Please enter arg 2:");
                var arg2 = Console.ReadLine();

                if (arg2 == "exit")
                {
                    break;
                }

                try
                {
                    Console.ForegroundColor = ConsoleColor.Green;                                     //for highlighting the result

                    MyApi apiInstance = new MyApi();                                                   //using instance method

                    double result = apiInstance.Divide(int.Parse(arg1), int.Parse(arg2));

                    Console.WriteLine($"Result of {arg1}/{arg2} = {result}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Sorry!! You have given incorrect inputs. Try Again!! :)");

                }

                finally
                {
                    Console.ResetColor();
                }
            }

            return Task.CompletedTask;
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
