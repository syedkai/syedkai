using System;
using System.Threading;

namespace ParallelProcessing
{
    class Parallel : IThread
    {

        private long finishedCounter = 0;

        public void sequenceTask(int threadLoop, Action<object> callback)
        {
            Thread.CurrentThread.Name = "Single Thread";
            for (int i = 0; i < threadLoop; i++) {
                callback(null);
            }
        }

        public void ownThreadTask(int numOfThread, Action<object> callback)
        {
            for (int i = 0; i < numOfThread; i++)
            {
                var thread = new Thread(new ParameterizedThreadStart(callback));
                thread.Name = i.ToString();
                thread.Start(new Action<string>(onThreadFinished));
            }

            while (true)
            {
                if (Interlocked.Read(ref finishedCounter) == numOfThread)
                {
                    break;
                } else
                {
                    Thread.Sleep(1000);
                }
            }
        }

        public void parallelTask(int numOfThread, Action<object> callback)
        {
            throw new NotImplementedException();
        }

        private void onThreadFinished(string threadName)
        {
            Interlocked.Increment(ref finishedCounter);
        }
    }
}
