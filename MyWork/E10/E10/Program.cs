using MyLib;
using System;

namespace E10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Person person = new Person("Usman", "Ali");
            Console.WriteLine(person.FullName);
        }
    }
}
