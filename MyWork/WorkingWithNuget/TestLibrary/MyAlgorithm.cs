using System;

namespace TestLibrary
{
    public class MyAlgorithm
    {
        /// <summary>
        /// calculate sum from data array
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public double CalculateSum(double[] data)
        {
            double sum = 0;

            foreach(var item in data)
            {
                sum += item;
            }

            return sum;
        }

        /// <summary>
        /// calculate average value from data array
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public double CalculateAverage(double[] data)
        {
            return this.CalculateSum(data) / data.Length;
        }
    }
}
