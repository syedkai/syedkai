using System;

namespace E8
{
    class Program
    {
        public static void Main(string[] args)
        {
            {
                double[] data = new double[] { 10.0, 20.0, 30.0, 40.0, 50.0 };
                ITrainInterface train = new ClassImplemention1();
                train.Train(data);
                var result1 = train.GetResult();
                Console.WriteLine($"The Result of First Implementation is : {result1}");
                Console.WriteLine();

                IFileInterface stats = new ClassImplemention2();
                stats.Load();

                stats.Train(data);
                Stats result2 = (Stats)stats.GetResult();
                Console.WriteLine("Average value is: " + result2.Avg + ", " +
                    "Median is: " + result2.Med + ", " +
                    "Variance is: " + result2.Var);

                stats.Save();
            }
        }
    }
}
