using System;

namespace Ex6Debug
{
    class Program
    {
        static void Main(string[] args)
        {
            string colour,pluralnoun,celebrity;

            Console.WriteLine("Roses are {colour}");
            Console.WriteLine("{pluralnoun}are blue");
            Console.WriteLine("I love {Celebrity}");


            Console.Write("Enter a colour:");
            colour = Console.ReadLine();

            Console.Write("Enter pluralnoun");
            pluralnoun = Console.ReadLine();

            Console.Write("Enter Celebrity:");
            celebrity = Console.ReadLine();
        }
    }
}
