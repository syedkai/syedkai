using System;
namespace InterfacesandClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interface and classes");
            Sample1();
            PersonInterface Per1 = new Person1();
            Per1.PrintName("abir");
            PersonInterface Per2 = new Person2();
            Per2.PrintName("rushil");
        }
        /// <summary>
        /// Demonstrates how to implement and use two classes, that implement some math algorithms.
        /// </summary>
        private static void Sample1()
            {
                int[] data = new int[] { 1, 22, 42, 11, 44 };
                SumAlgorithm sum = new SumAlgorithm();
                sum.Train(data);
                var sumRes = sum.GetResult();
                Console.WriteLine(sumRes);
                AverageAlgorithm avg = new AverageAlgorithm();
                avg.Train(data);
                var averageRes = avg.GetResult();
                Console.WriteLine(averageRes);
            }
        }
}