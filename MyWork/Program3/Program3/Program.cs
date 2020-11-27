using System;
using ClassLibrary1;

namespace Program3
{
    class Program
    {
        static void Main(string[] args)
        {
            try       // Block for checking errors
            {

                Console.WriteLine("Enter a number ");                           // Program to Multiply two integers
                int a = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter a 2nd number");
                int b = int.Parse(Console.ReadLine());

                int result = ClassMulti.Multi(a, b);
                Console.WriteLine($" Multiplication result is {result}");


            }
            catch (Exception ex)        // Exception Handling  ex will have the error details and you can show it using below statement
            {
                Console.WriteLine($" Error {ex}  \n please enter a number only");

            }
            finally      // will always execute 
            {
                 Console.WriteLine("Multiplication done finally");

                 Console.WriteLine("Enter a String to get its length");           // Program to calculate the lenght of ta string
                 string c = Console.ReadLine();
                 int len = ClassRead.Read(c);


                 Console.WriteLine($" length of // {c} // is {len}"); 


            }




        }
    }
}
