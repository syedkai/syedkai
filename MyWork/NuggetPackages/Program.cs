using System;
namespace Workingwithnugget
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MyLibrary.Class1 referencedLib = new MyLibrary.Class1();

            var res = referencedLib.Calculate(23, 13);

            Console.WriteLine(res);

        }
    }
}