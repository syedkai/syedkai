using System;

namespace WorkingWithNuget
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unit Tests");
            MyLibrary.MyLib referencedlib = new MyLibrary.MyLib();

            var result1 = referencedlib.divide(24.12, 2.12);
            var result2 = referencedlib.add(1.00001, 2.1223);
            var result3 = referencedlib.multiply(22.11, 12.65);



            Console.WriteLine("Division Result: " + result1);
            Console.WriteLine("Addition Result: " + result2);
            Console.WriteLine("Multiplication Result: " + result3);
        }
    }
}
