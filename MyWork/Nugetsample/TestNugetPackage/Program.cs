using System;
namespace TestNugetPackage
{
    class Program
    {

        static void Main(string[] args)
        {
            var calc = new Calculation.Calculation();
            Console.WriteLine(calc.sum(2,2));
        }
    }
}
