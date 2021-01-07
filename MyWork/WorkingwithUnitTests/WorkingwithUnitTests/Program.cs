using System;

namespace WorkingwithUnitTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing my project using Unit tests!!");
            CalculationLibrary.OperationType refLib = new CalculationLibrary.OperationType();
            var res = refLib.multiply(2.2, 4.4);
            Console.WriteLine("The result for the caluculation is: " + res);
        }
    }
}
