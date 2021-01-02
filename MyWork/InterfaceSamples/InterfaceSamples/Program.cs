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

            double[] multData = new double[] { 3.3, 4.4 };

            IMyMLAlgorithm alg = new SumAlgorithm();

            Sample2(alg, data);
            

            Sample2(new AverageAlgorithm(), data);

            Sample3(new Multiplication(), multData);



            // Demonstrates casting

            if (alg is SumAlgorithm)
            {
                SumAlgorithm castedSum = (SumAlgorithm)alg;
            }

            if (alg is AverageAlgorithm)
            {
                AverageAlgorithm avgAlg = (AverageAlgorithm)alg;
            }

            if (alg is Multiplication)
            {
                Multiplication multi = (Multiplication)alg;
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
        /*private static void Sample2(IMyMLAlgorithm alg, double[] data)
        {
            alg.Train(data);

            var result = alg.GetResult();
            
            Console.WriteLine(result);
        }*/

        /// <summary>
        /// Downloads all data from somewhere => dataProvider of type IData
        /// </summary>
        /// <param name="dataProvider"></param>
        /// <param name="database"></param>
        //public void GetDataAndSaveItToDatabase(IData dataProvider, IRepository database)
        //{

        //    foreach (object dataRecord in dataProvider.DownlodAllRecords{

        //        var email = dataRecord.UserEMail;

        //        var newEmail = remail.Replace("@myoldcompanyname.com", "@mynewcompanyname.com");

        //        database.SaveToDb(changedEmal);

        //    }
        //}

        private static void Sample3(IMyMLAlgorithm alg, double[] multData)
        {
            alg.Train(multData);
            var result = alg.GetResult();

            Console.WriteLine("Multiplication Result");

            Console.WriteLine(result);
        }


        private static void Sample2(IMyMLAlgorithm alg, double[] data)
        {
            alg.Train(data);
            var result = alg.GetResult();
            Console.WriteLine(result);
            alg.save();
            alg.load();
        }



    }
}