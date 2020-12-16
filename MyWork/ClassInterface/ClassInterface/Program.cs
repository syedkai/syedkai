using System;

namespace ClassInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            IArea rectangle = new Rectangle(14.5, 11);
            IArea circle = new Circle(5);
            Console.WriteLine($"Area of rectangle is: {rectangle.Area()}");
            Console.WriteLine($"Area of circle is: {circle.Area()}");
        }
    }
}
