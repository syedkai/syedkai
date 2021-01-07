using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace HelloWorldWithParallel
{
    public class ParallelClass
    {
        private long m_FinishCounter = 0;

        /// <summary>
        /// Execute Job after Job as sequence
        /// </summary>
        /// <param name="sequences"></param>
        /// <param name="func"></param>
        public void StartJob(int sequences, Action<object> func)
        {
            Thread.CurrentThread.Name = "SingleThread";

            for (int i = 0; i < sequences; i++)
            {
                func(null);
            }
        }

        /// <summary>
        /// Execute each job in its own thread
        /// Thread support only one job in each thread.
        /// It is how we manipulate the Threads on OS.
        /// </summary>
        /// <param name="threads"></param>
        /// <param name="func"></param>
        public void StartJobInItsThread(int threads, Action<object> func)
        {
            // declare and start each thread
            for (int i = 0; i < threads; i++)
            {
                var t = new Thread(new ParameterizedThreadStart(func));
                t.Name = i.ToString();
                t.Start(new Action<string>(OnThreadFinished));
            }

            while (true)
            {
                if (Interlocked.Read(ref m_FinishCounter) == threads)
                    break;
                else
                    Thread.Sleep(500);
            }
        }

        private void OnThreadFinished(string threadName)
        {
            Interlocked.Increment(ref m_FinishCounter);
        }

        /// <summary>
        /// Execute Jobs in Parallel
        /// by using Tasks, we can run Jobs asynchronously.
        /// </summary>
        /// <param name="threads"></param>
        /// <param name="func"></param>
        public void StartJobParallel(int threads, Action<object> func)
        {
            // create a list of tasks
            List<Task> tList = new List<Task>();

            for (int i = 0; i < threads; i++)
            {
                var t = new Task(func, new Action<string>(OnThreadFinished));
                tList.Add(t);
            }

            // start tasks in List
            foreach(var t in tList)
            {
                t.Start();
            }

            Task.WaitAll(tList.ToArray());
        }
    }
}
