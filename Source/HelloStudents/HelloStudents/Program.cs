using System;
using System.Threading;

namespace HelloStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            BetterCalculator bCalc = new BetterCalculator();

            int res = bCalc.Add(221, 42343);
            int res2 = bCalc.Mul(221, 42343);
            double res3 = bCalc.Div(221, 42343);

            Console.WriteLine(res);
            Console.WriteLine();
            Console.WriteLine(res2);
            Console.WriteLine();
            Console.WriteLine(res3);

            Console.WriteLine("Press any key to exit.");
            Console.ReadLine();

            Counter count = new Counter();
            count.IncrementalCounter();
            Console.WriteLine();
            Thread.Sleep(2000);
            count.DecrementalCounter();

            /* MyAlgorithm alg = new MyAlgorithm();

             for (int i = 0; i < 10; i++)
             {
                 double result = alg.Calculate(i);

                 Console.WriteLine("Haritha Test \n changes");

                 Console.WriteLine($"Hello Students from Windows! Iteration: {i} generated the result = {result}");

                 Thread.Sleep(500);
             }

             Console.WriteLine("Press any key do exit...");
             Console.ReadLine();*/
        }
    }
}
