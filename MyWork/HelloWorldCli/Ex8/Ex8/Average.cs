using System;
using System.Collections.Generic;
using System.Text;

namespace Ex8
{
    class Average : IMyInterface
    {
        public int Train(int args1, int args2)
        {
            return (args1 + args2) / 2;
        }
    }
}
