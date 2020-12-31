using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceEmplementation
{
    class EvenNumber : ISeriseInterface
    {
        public int[] Serise()
        {
            int[] evenserise = new int[100];
            evenserise[0] = 0;

            for (int i = 1; i < 100; i++)
            {
                evenserise[i] = evenserise[i - 1] + 2;
            }

            return evenserise;
        }
    }
}
