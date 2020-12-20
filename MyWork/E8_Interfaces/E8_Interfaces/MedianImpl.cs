using System;
using System.Collections.Generic;
using System.Text;

namespace E8_Interfaces
{
    class MedianImpl : IMyInterface
    { private double median;
        public object GetResult()
        {
            return this.median;        }

        public void Train(double[] data)
        {
            Array.Sort(data);
            foreach(double value in data)
            {
                this.median+= value;
            }
            if (data.Length % 2 == 0)
            {
                this.median = (data[(data.Length+1) / 2] + data[((data.Length + 1) / 2)-1]) / 2;
               
            }
            else
            { this.median = data[(data.Length) / 2]; }
           
        }
    }
}
