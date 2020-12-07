﻿using System;

namespace InterfaceSamples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            //Sample1();

            double[] data = new double[] { 1.2, 22.3, 42.22, 11.22, 44.55 };
          
            IMyMLAlgorithm alg = new SumAlgorithm();

            Sample2(alg, data);

            Sample2(new AverageAlgorithm(), data);

            // Demonstrates casting

            if (alg is SumAlgorithm)
            {
                SumAlgorithm castedSum = (SumAlgorithm)alg;
            }

            if (alg is AverageAlgorithm)
            {
                AverageAlgorithm avgAlg = (AverageAlgorithm)alg;
            }

            Console.WriteLine("Press any key to exit.");

            Console.ReadLine();
        }


        /// <summary>
        /// Demonstrates how to implement and use two classes, that implement some math algorithms.
        /// </summary>
        private static void Sample1()
        {
            double[] data = new double[] { 1.2, 22.3, 42.22, 11.22, 44.55 };

            SumAlgorithm sum = new SumAlgorithm();
            
            sum.Train(data);

            var sumRes = sum.GetResult();

            Console.WriteLine(sumRes);


            AverageAlgorithm avg = new AverageAlgorithm();

            avg.Train(data);

            var averageRes = avg.GetResult();

            Console.WriteLine(averageRes);
        }
        

        /// <summary>
        /// Demonstrates how to use interface.
        /// </summary>
        private static void Sample2(IMyMLAlgorithm alg, double[] data)
        {
            alg.Train(data);

            var result = alg.GetResult();

            Console.WriteLine(result);
        }
    }
}
