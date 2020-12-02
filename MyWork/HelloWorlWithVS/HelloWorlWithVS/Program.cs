using System;
using System.Collections.Generic;

namespace HelloWorldWithVS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ///checking inbuilt sort function

            int[] arr1 = { 55, 34, 23, 57, 89, 65, 76 };

            var numlist = new List<int>();
            numlist.AddRange(arr1);

            numlist.Sort();
            foreach (var arr in numlist)
                Console.WriteLine(arr);

            Console.WriteLine();
        }
    }
}

