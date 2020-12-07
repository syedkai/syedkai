using HelloWorldWithClass;
using System;

namespace HelloWorldWithVS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Shape s = new Shape();
            Console.WriteLine(s.Legs);

            News news1 = new News();
            news1.Title = "First news!";
            Console.WriteLine(news1.Title);
        }
    }
}
