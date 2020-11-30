using System;

namespace HelloWorldWithCli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HI jiji!");
            Console.WriteLine("My First Commit!");
            Console.Write("What is your name?");
            String name = Console.ReadLine();
            Console.WriteLine("Your name is " + name);
            Console.ReadLine();
        }
    }
}
