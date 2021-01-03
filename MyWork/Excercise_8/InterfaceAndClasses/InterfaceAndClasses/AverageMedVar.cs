using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndClasses
{
    public class AverageMedVar : IMyInterface
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

            double average = m_Sum / data.Length;

            return average;
        }
    }
}
