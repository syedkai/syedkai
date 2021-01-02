using System;

namespace WorkingWithNuget
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Working With Nuget Packages");
            MyLibrary.MyLib referencedlib = new MyLibrary.MyLib();

            var result= referencedlib.calc(24, 2);
            Console.WriteLine("Division Result: "+result);


        }
    }
}
