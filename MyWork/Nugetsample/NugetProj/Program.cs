using System;
using Calculation;
namespace NugetProj
{
    class Program
    {

        static void Main(string[] args)
        {
            var calc = new Calculation.calculate();
            Console.WriteLine(calc.Add(2,2));
        }
    }
}
