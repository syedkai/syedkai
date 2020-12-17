using System;

namespace WorkingWithUnitTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing My work using Unit tests!!");
            CalculationLibrary.CalculationTypes refLib = new CalculationLibrary.CalculationTypes();
            var res = refLib.multiply(2.2, 4.4);
            Console.WriteLine("The result for the caluculation is: " + res);
        }
    }
}
