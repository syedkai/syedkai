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
        /// </summary>
        /// <param name="threads"></param>
        /// <param name="func"></param>
        public void StartJobParallel(int threads, Action<object> func)
        {
            // create a list of threads
            List<Thread> tList = new List<Thread>();

            for(int i = 0; i < threads; i++)
            {
                var thread = new Thread(new ParameterizedThreadStart(func));
                thread.Name = i.ToString();
                tList.Add(thread);
            }

            // start threads in List
            foreach(var item in tList)
            {
                item.Start(new Action<String>(OnThreadFinished));
            }

            while (true)
            {
                if (Interlocked.Read(ref m_FinishCounter) == threads)
                    break;
                else
                    Thread.Sleep(500);
            }
        }
    }
}
