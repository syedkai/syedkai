using System;

namespace HelloWorldWithClass
{
    class Program
    {
        static void Main(string[] args)
        {
            MyCount count = new MyCount();

            double answer = count.classArea(5, 9);

            Console.WriteLine($"Here is the answer, the area of a circle is: { answer}");

        }
    }
}
