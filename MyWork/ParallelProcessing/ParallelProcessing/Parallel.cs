using System;
using System.Threading;

namespace ParallelProcessing
{
    class Parallel : IThread
    {
        public void sequence(int threadLoop, Action<object> callback)
        {
            Thread.CurrentThread.Name = "Single Thread";
            for (int i = 0; i < threadLoop; i++) {
                callback(null);
            }
        }
    }
}
