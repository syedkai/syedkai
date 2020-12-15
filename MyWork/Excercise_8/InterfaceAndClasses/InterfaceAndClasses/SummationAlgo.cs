using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndClasses
{
    public class SummationAlgo : IMyInterface
    {
        private double m_Sum;
        public SummationAlgo()
        {
            this.m_Sum = 0;
        }
        public object GetResult()
        {
            var sumResult = this.m_Sum;
            double result = Convert.ToDouble(sumResult);
            if (result > 100)
            {
                int setResult = 1;
                return setResult;
            }
            else
            {
                int setResult = 0;
                return setResult;
            }
            ///return this.m_Sum;
        }

        public void Train(double[] data)
        {
            foreach (var value in data)
            {
                this.m_Sum += value;

            }
        }
    }
}
