using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    public class FirstApproach : IMyInterface
    {        
        public object GetResult()
        {
            throw new NotImplementedException();
        }

        public double Train(double[] data)
        {

            double sum = 0;
            for (int i = 0; i < data.Length; i++)
            {
                sum += data[i];
            }

            double average = sum / data.Length;
            return average;
        }
    }
}
