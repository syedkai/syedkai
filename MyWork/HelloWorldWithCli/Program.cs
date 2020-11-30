using System;

namespace HelloWorldWithCli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Welcome to my CLI program");
            Console.WriteLine("My Basic console print and for operation");
			for(int i = 0; i < 10; i++)
            {
                 Console.WriteLine("Value of i: {0}", i);
            }
        }
    }
}
