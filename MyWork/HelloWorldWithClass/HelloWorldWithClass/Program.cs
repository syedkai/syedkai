using CarLibrary;
using System;

namespace HelloWorldWithClass
{
    class Program
    {
        public static void Main(string[] args)
        {
            ClassAutomotive Car = new ClassAutomotive("BMW", "Blue", 1991);
            Console.WriteLine(Car.getTheCarDetails());
        }
    }
}
