using System;
using Calculator;

namespace CalucatingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to calculator.Please enter two numbers and operation symbol");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            string symbol = Console.ReadLine();
            Operations calObj = new Operations();
            var result = 0;
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
                    result = Operations.Multiply(a, b);
                    Console.WriteLine(result);
                    break;
                case "/":
                    double res = Operations.Divide(a, b);
                    Console.WriteLine(res);
                    break;
                default:
                    Console.WriteLine("Please enter symbols only +,*,/,-");
                    break;
            }
        }
    }
}
