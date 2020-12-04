using System;

namespace HelloWorldWithCli
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=1; i<200; i++)
                Console.WriteLine($"Hello viewers from Windows10! Iteration= {i}");
                System.Threading.Thread.Sleep(100);
        }
    }
}
