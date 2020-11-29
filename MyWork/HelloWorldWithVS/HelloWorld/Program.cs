using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First console application with VS!");
            Console.WriteLine("Please enter numbers to count :");
            int a = Convert.ToInt32(Console.ReadLine());
            for(var i=0; i <= a; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
