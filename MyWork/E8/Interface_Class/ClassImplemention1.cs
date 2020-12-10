using System;
using System.Collections.Generic;
using System.Text;

namespace E8
{
    public class ClassImplemention1 : ITrainInterface

    {
        double m_Result = 0;

        public object GetResult()
        {
            return this.m_Result;
        }

        public void Train(double[] data)
        {
            foreach (double fact in data)
            {
                m_Result += fact;
            }

            if (m_Result > 100)

            {
                m_Result = 1;
            }
            else
            {
                m_Result = 0;
            }

        }


    }
}
