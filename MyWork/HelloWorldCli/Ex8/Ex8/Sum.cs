using System;
using System.Collections.Generic;
using System.Text;

namespace Ex8
{
    class Sum : IMyInterface
    {
        public int Train(int args1, int args2)
        {
            return (args1 + args2) > 100 ? 1 : 0;
        }
    }
}
