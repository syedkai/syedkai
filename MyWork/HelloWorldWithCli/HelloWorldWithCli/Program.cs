using System;

namespace HelloWorldWithCli
{
    class Program
    {
        static public void Main(string[] args)
        {
            

            Console.WriteLine("Hello World!");
            Console.WriteLine("This is my first project with C#");
            Console.WriteLine("Addition of two Integers");
            Console.WriteLine("Enter First Integer:");
            string line1 = Console.ReadLine();
            int a = int.Parse(line1);
            Console.WriteLine("Enter Second Integer:");
            string line2 = Console.ReadLine();
            int b = int.Parse(line2);
            int c = a + b;
            Console.WriteLine("The sum is: " + c);


         


        }
    }
}
