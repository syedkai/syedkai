using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAndClasses
{
    class SumAlgorithm : MLInterface
    {
        Result sumResult = new Result();
        public Result GetResult()
        {
            return this.sumResult;
        }

        public void Train(double[] data)
        {
            double sum = 0;
            foreach (double item in data)
            {
                sum += item;
            }
            int checkVal = sum > 100 ? 1 : 0;
            sumResult.sum = checkVal;
        }
    }
}