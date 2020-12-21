using System;
using CalculatorNugetPackage;

namespace AccessingANugetPackage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to calculator.Please enter two numbers and operation symbol");
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            string symbol = Console.ReadLine();
            Calculate calObj = new Calculate();
            double result = 0;
            switch (symbol)
            {
                case "+":
                    result = calObj.Add(a, b);
                    Console.WriteLine(result);
                    break;
                case "-":
                    result = calObj.Subtract(a, b);
                    Console.WriteLine(result);
                    break;
                case "*":
                    result = Calculate.Multiply(a, b);
                    Console.WriteLine(result);
                    break;
                case "/":
                    double res = Calculate.Divide(a, b);
                    Console.WriteLine(res);
                    break;
                default:
                    Console.WriteLine("Please enter symbols only +,*,/,-");
                    break;
            }
        }
    }
}
