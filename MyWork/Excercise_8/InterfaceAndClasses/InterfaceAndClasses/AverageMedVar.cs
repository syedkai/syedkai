using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndClasses
{
    public class AverageMedVar : IMyInterface
    {
        private double m_Sum;
        public AverageMedVar()
        {
            this.m_Sum = 0;
        }
        public object GetResult()
        {
            return this.m_Sum;
        }

        public void Train(double[] data)
        {
            foreach (var value in data)
            {
                this.m_Sum += value;

            }

            m_Sum = m_Sum / data.Length; 
        }
    }
}
