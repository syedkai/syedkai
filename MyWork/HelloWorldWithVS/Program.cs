using HelloWorldWithClass;
using System;

namespace HelloWorldWithVS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Shape s = new Shape();
            Console.WriteLine(s.Legs);
        }
    }
}
