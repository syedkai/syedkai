using System;
using System.Threading;

namespace HelloWorldWithVS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World from Windows10!");

            NewazAlgorithm alg = new NewazAlgorithm();

            for (int i = 1; i < 200; i++)
            {
                double result = alg.calculate(i);

                Console.WriteLine($"Hello viewers from Windows! Iteration= {i} generated the result = {result}");
                Thread.Sleep(100);

            }

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}
