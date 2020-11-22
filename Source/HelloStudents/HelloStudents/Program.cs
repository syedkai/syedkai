using System;
using System.Threading;

namespace HelloStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World From Console!\n");
            Console.Title = "Changed file";
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WindowHeight = 20;

            Console.WriteLine("After few changes!");
            Console.WriteLine("Press any key do exit...");
            Console.ReadLine();
        }
    }
}
