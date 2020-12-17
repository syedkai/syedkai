using System;

namespace Interface_Sample
{
    
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Two different implementation for Sum !");

            double[] data = new double[] { 1.1, 2.2, 3.3, 4.4, 5.5 };
            //Sample1(data);

            Class1_SumAlgo sum1 = new Class1_SumAlgo();

            Sample2(sum1, data);

            

            /*Class2_AnotherSumAlgo avg_sum = new Class2_AnotherSumAlgo();
            Sample2(avg_sum, data);*/

            Console.ReadLine();

        }
        /// <summary>
        /// Demonstarte how to implement two classes to implement math algo
        /// </summary>
        /*private static void Sample1(double[] data)
        {
            //double[] data = new double[] { 1.1, 2.2, 3.3, 4.4, 5.5 };
            Class1_SumAlgo sum = new Class1_SumAlgo();
            sum.Train(data);

            var sum_res = sum.GetResult();

            Console.WriteLine(sum_res);

            Class2_AnotherSumAlgo avg = new Class2_AnotherSumAlgo();
            avg.Train(data);
            var avg_res = avg.GetResult();

            Console.WriteLine(avg_res);
        }*/

        /// <summary>
        /// Demonstrate how to use interface
        /// </summary>
         private static void Sample2(IMyInterface alg, double[] data)
        {
            alg.Train(data);
            var result = alg.GetResult();
            Console.WriteLine(result);
            alg.save();
            alg.load();
        }
    }
}
