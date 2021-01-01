using System;

namespace Ex11
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Calculator
    {

        public int Add(int firstArgs, int secondArgs)
        {
            return firstArgs + secondArgs;
        }

        public int Substract(int firstArgs, int secondArgs)
        {
            return firstArgs - secondArgs;
        }

        public int Mutliply(int firstArgs, int secondArgs)
        {
            return firstArgs * secondArgs;
        }

        public double Devide(double firstArgs, double secondArgs)
        {
            return firstArgs / secondArgs;
        }

        public int Square(int args)
        {
            return args * args;
        }
    }
}
