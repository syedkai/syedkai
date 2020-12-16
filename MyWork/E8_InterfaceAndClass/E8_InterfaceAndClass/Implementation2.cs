using System;
using System.Collections.Generic;
using System.Text;

namespace E8_InterfaceAndClass
{
    class Implementation2:IMyInterface
    {
        public Result result;

        public object GetResult()
        {
            return result;
        }

        public void Train(double[] data)
        {
            double sum = 0;
            for (int i = 0; i < data.Length; i++)
            {
                sum += data[i];
            }
            double average = sum / data.Length;
            double median = this.GetMedian(data);
            double variance = this.GetVariance(average, data);
            this.result = new Result(average, median, variance);
        }

        public double GetMedian(double[] data)
        {
            double[] sortedData = (double[])data.Clone();
            Array.Sort(sortedData);

            int size = sortedData.Length;
            int mid = size / 2;
            double median = (size % 2 != 0) ? (double)sortedData[mid] : ((double)sortedData[mid] + (double)sortedData[mid - 1]) / 2;
            return median;
        }

        public double GetVariance(double average, double[] data)
        {
            double sumOfDerivation = 0;
            foreach (double value in data)
            {
                sumOfDerivation += (value) * (value);
            }
            double sumOfDerivationAverage = sumOfDerivation / (data.Length - 1);

            return Math.Sqrt(sumOfDerivationAverage - (average * average));
        }
    }
}
