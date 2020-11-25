using System;

namespace My1stProgVS
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Please enter the radius = ");
            String radius = Console.ReadLine();                            // Input given by user and stored in radius
            double area = Math.Pow(double.Parse(radius), 2) * Math.PI;    // String converted into double and power ( A, Power)

            Console.WriteLine($"Area of the Circle is {area}");
        }



    }
}
