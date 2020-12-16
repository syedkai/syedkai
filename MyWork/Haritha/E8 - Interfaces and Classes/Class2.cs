using System;
using System.Collections.Generic;
using System.Text;
using MathNet.Numerics.Statistics;

namespace E8___Interfaces_and_Classes
{
    class Class2 : Itestinterface
    {
        double m_average, m_median, m_variance; double m_sum;
        protected Result resultinstance = new Result();
        
        public void Train(double[] data)
        {
            // average calculation
            foreach (double o in data)
            {
                m_sum = m_sum + o;
            }
            m_average = Convert.ToDouble(m_sum) / data.Length;

            // median calculation
            double m_median = data.Median();
            
        }

        public Result GetResult()
        {
            resultinstance.Average = m_average;
            resultinstance.Median = m_median;
            resultinstance.Variance = m_variance;
            return resultinstance;
        }
        public void SaveResult()
        {
            
        }

        public void LoadResult()
        {
            Console.WriteLine($"{resultinstance.Average} is the Average.");
            Console.WriteLine($"{resultinstance.Median} is the Median.");
            Console.WriteLine($"{resultinstance.Variance} is the Variance.");
            
        }
    }
}
