using ClassLibrary12;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World This is my project!");
            Person usman = new Person("Usman Ali");
            Console.WriteLine("Hello I am " + usman.Name);
        }
    }
}
