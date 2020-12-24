using System;

namespace unittest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] abc = { 7, 5, 13, 1, 8, 0 };
            ubbleSort x = new ubbleSort(abc);
            x.bubblesort();
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine(abc[i]);
            }
        }
    }
}
