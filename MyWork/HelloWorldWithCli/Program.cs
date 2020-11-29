using System;

namespace HelloWorldWithCli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is my first application using command line!");
            Console.WriteLine("Please add a message for me:");
            var msg = Console.ReadLine();
            Console.WriteLine("Your message for me is {0}",msg);
        }
    }
}
