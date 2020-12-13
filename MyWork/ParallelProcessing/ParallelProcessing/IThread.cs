using System;
using System.Collections.Generic;
using System.Text;

namespace ParallelProcessing
{
    interface IThread
    {
        void sequenceTask(int threadLoop, Action<object> callback);
        void ownThreadTask(int numOfThread, Action<object> callback);
        void parallelTask(int numOfThread, Action<object> callback);
    }
}
