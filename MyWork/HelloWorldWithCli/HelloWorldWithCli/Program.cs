using System;

namespace HelloWorldWithCli
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("I created my first project");
            Console.Write("Enter your fav colour: ");
            string fav_color = Console.ReadLine();
            Console.Write("YOUR FAV COLOUR IS " + fav_color);
            Console.ReadLine();
        }
    }
}
