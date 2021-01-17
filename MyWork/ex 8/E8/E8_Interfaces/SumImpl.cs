using System;
using System.Collections.Generic;
using System.Text;

namespace E8_Interfaces
{
    class SumImpl : IMyInterface
    {
        private double sum;
        public object GetResult()
        {
            return this.sum;
        }

        public void Train(double[] data)
        {
            foreach(double Value in data){
                this.sum += Value;
            }
            if (this.sum >= 100)
            {
                this.sum = 1;
            }
            else
                this.sum = 0;
        }
    }
}
