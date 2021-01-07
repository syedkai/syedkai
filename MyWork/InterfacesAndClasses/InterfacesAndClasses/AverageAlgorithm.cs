using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAndClasses
{
    class AverageAlgorithm : MLInterface
    {
        Result avgResult = new Result();
        public Result GetResult()
        {
            return this.avgResult;
        }

        public void Train(double[] data)
        {
            double sum = 0;
            foreach(double item in data)
            {
                sum += item;
            }
            double avg = (double)sum / data.Length;
            avgResult.average = avg;
        }
    }
}
