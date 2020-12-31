using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceEmplementation
{
    interface ISeriseInterface
    {
        public (int[], int) Serise();

        public void SavingOutput(int[] serise, int iteration);
    }
}
