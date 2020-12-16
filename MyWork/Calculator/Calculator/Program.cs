using System;
using CalculationLibrary;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Hello World!");

            Console.WriteLine("Enter 1st values for division");
            var a=Console.ReadLine();
            Console.WriteLine("Enter 2nd values for division");
            var b=Console.ReadLine();
            var c=Calculation.Ddivide(int.Parse(a),int.Parse(b));
            Console.WriteLine($"Answer ={c}");

            Console.WriteLine("Enter 1st values to multiply");
            a=Console.ReadLine();
            Console.WriteLine("Enter 2nd values to multiply");
            b=Console.ReadLine();
            c = Calculation.Mmultiply(int.Parse(a), int.Parse(b));
            Console.WriteLine($"Answer ={c}");

            Console.WriteLine("Enter 1st values to add");
            a=Console.ReadLine();
            Console.WriteLine("Enter 2nd values to add");
            b=Console.ReadLine(); 
            c = Calculation.Pplus(int.Parse(a), int.Parse(b));
            Console.WriteLine($"Answer ={c}");

            Console.WriteLine("Enter 1st values to subtract");
            a=Console.ReadLine();
            Console.WriteLine("Enter 2nd values to subtract");
            b=Console.ReadLine();
            c = Calculation.Mminus(int.Parse(a), int.Parse(b));
            Console.WriteLine($"Answer ={c}");



        }
    }
}
