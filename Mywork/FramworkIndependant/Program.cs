using System;

namespace FramworkIndependant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome in your calculator!!!");

            // getting input method
            int[] input1 = gettingInput();

            // action to do
            Console.WriteLine("Give an operation +,-,/,*");
            string action = Console.ReadLine();

            int output;
            Class1 cal = new Class1();
            // calculating output
            switch (action)
            {
                case "+":
                    output = cal.Addition(input1);
                    Console.WriteLine($"Summation of this two values is {output}");
                    break;
                case "-":
                    output = cal.Subtraction(input1);
                    Console.WriteLine($"Summation of this two values is {output}");
                    break;
                case "*":
                    output = cal.Multiplication(input1);
                    Console.WriteLine($"Summation of this two values is {output}");
                    break;
                case "/":
                    output = cal.Divition(input1);
                    Console.WriteLine($"Summation of this two values is {output}");
                    break;
            }
        }

        private static int[] gettingInput()
        {
            int[] inputValue = { 0, 0 };
            inputValue[0] = Convert.ToInt32(Console.ReadLine());
            inputValue[1] = Convert.ToInt32(Console.ReadLine());

            return inputValue;
        }

    }
}
