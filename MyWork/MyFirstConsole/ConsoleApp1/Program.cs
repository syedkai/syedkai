using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is my First Console App! \n\n What's your Name?");
            string response = Console.ReadLine();
            Console.WriteLine($"Hello{response}!");
        }
    }
}
