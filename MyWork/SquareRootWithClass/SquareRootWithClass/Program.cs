using System;

namespace SquareRootWithClass
{
    class Program
    {
        static void Main(string[] args)
        {
            int Z;
            do
            {

                Console.WriteLine("Please, enter a number to be squared or enter 0 to exit:");
                int x = int.Parse(Console.ReadLine());
                Console.WriteLine(SqrtPrecalculated.GetSqrt(x));
                Z = x;

            }
            while (Z != 0);
            Console.WriteLine("End");
            System.Threading.Thread.Sleep(1000);
        }
    }

}
