using System;

namespace HelloWorldwithNugget
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MyLibrary.MyLib referencedLib = new MyLibrary.MyLib();

            var res = referencedLib.Sum(11, 23132);
            Console.WriteLine(referencedLib.Divide(10, 2));
            Console.WriteLine(res);
        }
    }
}
