using System;

namespace DebuggingProject
{
    /// <summary>
    /// This code is written to see how a debugger works
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            while (counter < 100)
            {
                Console.WriteLine($"Hello Sabeen! The counter is {counter}");
                counter++;
            }
        }
    }
}
