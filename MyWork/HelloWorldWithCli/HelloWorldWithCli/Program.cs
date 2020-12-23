using System;

namespace HelloWorldWithCli
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = "World";
            Console.WriteLine($"Hello {name.ToUpper()}!");
        }
    }
}
