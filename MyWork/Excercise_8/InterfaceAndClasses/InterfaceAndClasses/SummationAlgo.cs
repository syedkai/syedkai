using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndClasses
{
    public class SummationAlgo : IMyInterface
    {
        public object GetResult()
        {
            throw new NotImplementedException();
        }

        public double Train(double[] data)
        {
            double m_Sum = 0;

            for (int i = 0; i < data.Length; i++)
            {
                m_Sum += data[i];
            }

            ///double result = m_Sum;

            if (m_Sum > 100)
            {
                int setResult = 1;
                return setResult;
            }
            else
            {
                int setResult = 0;
                return setResult;
            }
        }
    }
}
