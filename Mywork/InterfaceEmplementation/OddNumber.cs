using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceEmplementation
{
    class OddNumber : ISeriseInterface
    {
        public int[] Serise()
        {
            int[] oddserise = new int[100];
            oddserise[0] = 1;

            for (int i = 1; i < 100; i++)
            {
                oddserise[i] = oddserise[i-1] + 2; 
            }

            return oddserise;
        }
    }
}
