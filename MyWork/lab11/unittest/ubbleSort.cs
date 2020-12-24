using System;
using System.Collections.Generic;
using System.Text;

namespace unittest
{
   public class ubbleSort
    {
        int[] data;
        public ubbleSort(int[] xyz) 
        {
            data = xyz;
        }
        public void bubblesort()
        {
            for (int i = 0; i < data.Length - 1; i++)
                for (int j = i + 1; j < data.Length; j++)
                    if (data[i] > data[j])
                    {
                        int temp = data[i];
                        data[i] = data[j];
                        data[j] = temp;
                    }
        }
    }
}
