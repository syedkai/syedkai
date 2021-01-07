using System;
//using MyLibrary;


namespace WorkingWithNuget
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Working With Nuget Packages");
            MyLibrary.Mylib referencedlib = new MyLibrary.Mylib();

            var result = referencedlib.calculate(24, 2);
            Console.WriteLine("Division Result: " + result);


        }
    }
}