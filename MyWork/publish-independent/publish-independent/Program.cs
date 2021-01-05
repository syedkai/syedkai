using System;
using System.Threading;


namespace publish_independent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            for (int i = 0; i < 100; i++)
            {
                double result = (i);
                Console.WriteLine($"Hello students from Windows! Iteration :{i} generate the result ={result}");
                Thread.Sleep(500);
            }
            Console.WriteLine("Press any key do exit from ...");

            Console.ReadLine();
        }
    }
}
