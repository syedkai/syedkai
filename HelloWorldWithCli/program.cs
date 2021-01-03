using System;

namespace HelloWorldWithCli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My First Program!");
            Console.WriteLine("HelloWorldWithCli");
            Console.WriteLine("This is my first project with C#");
            Console.Write("What is your name?");
            String name = Console.ReadLine();
            Console.WriteLine("Your name is " + name);
            Console.ReadLine();
        }
    }
}