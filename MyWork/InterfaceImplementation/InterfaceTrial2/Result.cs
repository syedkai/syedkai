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
            Console.WriteLine(average);


        }

        static void Main()
        {

            Result obj = new Result();
            obj.train2(new int[] { 10, 20, 30, 50 });

        }



    }
}
