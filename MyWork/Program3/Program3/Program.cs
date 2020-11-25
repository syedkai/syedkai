using System;

namespace Program3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number ");                           // Program to Multiply two integers
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a 2nd number");
            int b = int.Parse(Console.ReadLine());

            int result = ReadMulti.Multi(a,b);

            Console.WriteLine($" Multiplication result is {result}");

            Console.WriteLine("Enter a String to get its length");           // Program to calculate the lenght of ta string
            string c = Console.ReadLine();
            int len = ReadMulti.Read(c);

            
            Console.WriteLine($" length of // {c} // is {len}");
        }
    }
}
