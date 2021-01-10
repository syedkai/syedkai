using System;
using HelloWorldWithClass_library;

namespace ClassLibraryUsed
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
            double Result = obj.addition(2.5,7.5);
            Console.WriteLine(Result);
            Console.ReadLine();
        }
    }
}
