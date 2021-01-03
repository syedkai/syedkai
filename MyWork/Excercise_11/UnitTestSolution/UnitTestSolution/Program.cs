using System;

namespace UnitTestSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World: Unit Test!");
            
            Squaremath resolve = new Squaremath();

            double result1 = resolve.Area(5, 6);

            Console.WriteLine($"Area is: {result1}");

            double result2 = resolve.Perimeter(4, 8);

            Console.WriteLine($"Perimeter is: {result2}");

        }
    }
}
