using System;
using WorkingWithUnitTests;

namespace DMAS
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLibrary mylib = new MyLibrary();
            int a = mylib.Add(2, 2);
            int s = mylib.Subtract(4, 6);
            double m = mylib.Multiply(6, 10);
            double d = mylib.Divide(10, 2);

            Console.WriteLine($"{a}");
            Console.WriteLine($"{s}");
            Console.WriteLine($"{m}");
            Console.WriteLine($"{d}");

        }
    }
}
