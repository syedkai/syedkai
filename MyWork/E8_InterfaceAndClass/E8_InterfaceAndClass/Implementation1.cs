using System;
using System.Collections.Generic;
using System.Text;

namespace E8_InterfaceAndClass
{
    class Implementation1:IMyInterface
    {
        public double result;

        public object GetResult()
        {
            return result;
        }

        public void Train(double[] data){
            double sum = 0;
            for(int i = 0; i < data.Length; i++)
            {
                sum += data[i];
            }
            this.result = sum > 100 ? 1 : 0;
        }

    }
}
