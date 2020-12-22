using System;

namespace Helloworldwithclass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int input1 = Convert.ToInt32(Console.ReadLine());
            int input2 = Convert.ToInt32(Console.ReadLine());
            Fibonaccigenerator serise = new Fibonaccigenerator();

            var fibonacciserise = serise.SerieseGenrator(input1, input2);

            Console.WriteLine(fibonacciserise);
        }
    }
}
