using System;
using Compare;

namespace Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is comparison program. Please enter two numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter letter g for greatest number and l for least number");
            string input = Console.ReadLine();
            if(input=="g" || input == "l")
            {
                int c = CompareClass.Comparer(a, b, input);
                Console.WriteLine("Result:{0}", c);
            }
            else
            {
                Console.WriteLine("You have not entered correct letter");
            }
        }
    }
}
