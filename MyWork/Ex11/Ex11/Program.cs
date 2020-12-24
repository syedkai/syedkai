using System;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] EFG = { 30, 31, 2, 33, -1 };
            Class1 XYZ = new Class1(EFG);
            XYZ.binarySort();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(EFG[i]);
            }
            //Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
