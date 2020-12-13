using System;
using System.Collections.Generic;
using System.Text;

namespace ParallelProcessing
{
    interface IThread
    {
        void sequence(int threadLoop, Action<object> callback);

    }
}
