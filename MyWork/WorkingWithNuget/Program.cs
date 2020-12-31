using System;

namespace WorkingWithNuget
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MyLibrary.MyLib referencedLib = new MyLibrary.MyLib();
            var result = referencedLib.calculate(12, 12);
            Console.WriteLine(result);
        }
    }
}
