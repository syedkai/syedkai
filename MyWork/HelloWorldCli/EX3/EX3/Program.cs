using System;

namespace EX3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first argument");
            int firstArgs = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter first argument");
            int secondArgs = int.Parse(Console.ReadLine());

            Console.WriteLine("Sum is:=" +Addtion(firstArgs,secondArgs));

            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }

        static int Addtion(int firstArgs, int secondArgs) {

            return firstArgs + secondArgs;
        }
    }
}
