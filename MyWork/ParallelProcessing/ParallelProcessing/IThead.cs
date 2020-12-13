using System;
using System.Collections.Generic;
using System.Text;

namespace ParallelProcessing
{
    interface IThead
    {
        void sequence(int threadLoop, Action<object> callback);

    }
}
