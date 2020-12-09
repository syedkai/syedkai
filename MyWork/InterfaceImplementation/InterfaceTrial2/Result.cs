using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceTrial2
{
    
    class Result: IMyInterface2

    {
        int sum;
        double average;
        public void train2(int[] data)

        {
            for (int i = 0; i < data.Length; i++)
            {
                sum += data[i];
            }

            average = sum / data.Length;


        }



    }
}
