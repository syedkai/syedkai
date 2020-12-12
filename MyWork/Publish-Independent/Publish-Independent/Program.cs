using System;

namespace Publish_Independent
{
    /// <summary>
    /// Exercise 5 demonstrates how to publish a framework independent app
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter some text and I will calculate it's length for you!");
            string text = Console.ReadLine();
            var len = CalculateLength(text);
            Console.WriteLine($"Length of your text is {len}");
            Console.WriteLine("Press any key to exit");
            Console.ReadLine();

        }

        public static double CalculateLength(string input)
        {
            return input.Length;
        }
    }
}
