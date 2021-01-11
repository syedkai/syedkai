using System;

namespace HelloWorldWithClass
{
    class Program : Class1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Class1 add = new Class1();
            Console.WriteLine( add.calculation(12,14));
            
        }
    }
}
