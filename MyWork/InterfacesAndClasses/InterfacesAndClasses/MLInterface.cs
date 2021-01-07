using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAndClasses
{
    interface MLInterface
    {
        public Result GetResult();

        public void Train(double[] data);
    }
}
