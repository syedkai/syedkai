using System;
using System.Threading;

namespace ParallelProcessing
{
    class Parallel : IThread
    {

        public void sequenceTask(int threadLoop, Action<object> callback)
        {
            Thread.CurrentThread.Name = "Single Thread";
            for (int i = 0; i < threadLoop; i++) {
                callback(null);
            }
        }

        public void ownThreadTask(int numOfThread, Action<object> callback)
        {
            throw new NotImplementedException();
        }

        public void parallelTask(int numOfThread, Action<object> callback)
        {
            throw new NotImplementedException();
        }
    }
}
