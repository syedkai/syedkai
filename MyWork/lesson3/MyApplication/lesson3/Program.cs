using MyLibrary;
using System;
using System.Threading.Tasks;

namespace Lesson3
{
    class Program
    {
        /// <summary>
        /// / Standard simplified version of Task.Delay.
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Lesson3! Deep dive in .NET 5.0");

            // Run Sample
            // await LoopSample();

            myClass testClass = new myClass();


            Console.WriteLine("Please put in a number : ");
            
            double arg1 = Console.Read();
            
            double res = testClass.multiplyByTwo(arg1);

            Console.WriteLine($"The double value of input is : {res}");

            Console.WriteLine("Press any key to exit...");
            
            Console.ReadLine();

            // Task.CompletedTask();
        }



        /// <summary>
        /// Looping sample with task.delay
        /// </summary>
        /// <returns></returns>
        private static async Task LoopSample()
        {
            int n = 100;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Counter {i}.");

                await Task.Delay(1000);
            }
        }
    }

    //public class MyClass
    //{
    //    public static double GetLength(string input)
    //    {
    //        return a / b;
    //    }
    //    public double SomeMethod(int a, int b)
    //    {
    //        return a / b;
    //    }
    //}
}
