using System;
using TestLibrary;

namespace HelloWorldWIthNuGet
{
    class Program
    {
        static void Main(string[] args)
        {


            double[] data = new double[] { 1.4, 2.5, 0.12, 5.5, 3.6 };

            Console.Write("Given the data : ");
            foreach (var item in data)
            {
                Console.Write(item);
                Console.Write(" ");
            }
            Console.WriteLine("");

            var alg = new MyAlgorithm();

            Console.WriteLine($"Sum of the data is : {alg.CalculateSum(data)}");
            Console.WriteLine($"Average value of the data is : {alg.CalculateAverage(data)}");

            Console.WriteLine("Press any key to end session.");
            Console.ReadLine();
        }
    }
}
