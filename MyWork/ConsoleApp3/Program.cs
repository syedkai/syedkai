using System;

namespace WorkingWithDebugger
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b;
            int result = 1;

            Console.WriteLine("Enter Number to Calculate Fictorial ");
            b = int.Parse(Console.ReadLine());


            for (int i = b; i > 1; i--)
            {
                result = result * i;
                Console.WriteLine($"Iterration No {a} and result {result}\n");
                a++;

            }
        }
    }
}