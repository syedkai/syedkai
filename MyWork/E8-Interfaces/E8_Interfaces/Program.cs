using System;

namespace E8_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Double[] data = new double[] { 2, 9, 1, 50, 10, 3,7,8 };
            Array.Sort(data);
            foreach (int i in data) { 
                Console.Write(i + " ");
            }
            IMyInterface sum = new SumImpl();
            IMyInterface median = new MedianImpl();
            Binary(sum,data);
            Median(median,data);

        }

        private static void Median(IMyInterface median,double[] data)
        {
            
            median.Train(data);
            Console.WriteLine($"Median ={median.GetResult()}");
        }

        private static void Binary(IMyInterface sum,double[] data)
        {
            
            sum.Train(data);
            Console.WriteLine($"Binary ={sum.GetResult()}");
        }
    }
}
