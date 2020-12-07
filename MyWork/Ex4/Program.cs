using System;

namespace Ex4
{
    class Program
    {
        static void Main(string[] args)//main method
        {
            int a, b, d; //calling variable
            Console.WriteLine("Hello World with a new class!"); //print line
            Console.WriteLine("..."); // do
            Console.WriteLine("Enter your first value for substraction:"); //do
            a = int.Parse(Console.ReadLine()); //storing input value
            Console.WriteLine("Enter your second value:"); //print line
            b = int.Parse(Console.ReadLine()); //storing input value
            Substraction c = new Substraction (); //memory allocation
            d = c.Sub(a, b); //substraction of return value
            Console.WriteLine("Your result:" + d); //print the return value
            Console.ReadLine();

        }
    }
}
