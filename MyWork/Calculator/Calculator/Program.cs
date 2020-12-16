using System;
using Calculation;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World, this is my basic calculator! What operation do you want,choose number? ");
            Console.WriteLine("1 Divide");
            Console.WriteLine("2 Multiply");
            Console.WriteLine("3 Add");
            Console.WriteLine("4 Subtract");
            var option=Console.ReadLine();
            
            switch (int.Parse(option)) {
                case 1:
                    Console.WriteLine("Type Arg1");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Type Arg2");
                    int b = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{basic.Ddivide(a, b)}");
                    break;
                
                case 2:
                    Console.WriteLine("Type Arg1");
                    int c = int.Parse(Console.ReadLine());
                    Console.WriteLine("Type Arg2");
                    int d = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{basic.Mmultiply(c,d)}");
                    break;
                case 3:
                    Console.WriteLine("Type Arg1");
                    int e = int.Parse(Console.ReadLine());
                    Console.WriteLine("Type Arg2");
                    int f= int.Parse(Console.ReadLine());
                    Console.WriteLine($"{basic.Aadd(e, f)}");
                    break;
                case 4:
                    Console.WriteLine("Type Arg1");
                    int g = int.Parse(Console.ReadLine());
                    Console.WriteLine("Type Arg2");
                    int h = int.Parse(Console.ReadLine());
                    Console.WriteLine($"{basic.Ssubtract(g, h)}");
                    break;

            }



        }
    }
}
