using System;

namespace Helloworldwithclass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("My library test!!");
            int input1 = Convert.ToInt16(Console.ReadLine());
            int input2 = Convert.ToInt16(Console.ReadLine());
            Fibonaccigenerator serise = new Fibonaccigenerator();

            int[] vs = serise.SerieseGenrator(input1, input2);
            int[] fibonacciserise = vs;

            Array.ForEach(fibonacciserise, Console.WriteLine);
        }
    }
}
