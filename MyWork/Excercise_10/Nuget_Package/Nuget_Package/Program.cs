using MyNugetLibrary;
using System;

namespace Nuget_Package
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World: Its Nuget Package!");

            SimpleInterest SIRate = new SimpleInterest();

            double answer = SIRate.SI(15.6, 60, 31.2);

            Console.WriteLine($"Answer: { answer}");
        }
    }
}
