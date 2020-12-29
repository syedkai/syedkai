using System;

namespace Ex3
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add First Int for sum :");
            int firstArgs = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Add Second Int for sum :");
            int secondArgs = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nThe sum of two numbers is : {0} \n", Sum(firstArgs,secondArgs) );

            Console.WriteLine("Press enter key to exit.");
            Console.ReadLine();
        }

        public static int Sum(int a, int b) {
        
           return a + b;
        }
    }
}
