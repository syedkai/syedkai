using System;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Calculation.basic calculate = new Calculation.basic();
            var result=calculate.Ddivide(2,3);
            Console.WriteLine(result);
        }
    }
}
