using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Parallelprocessing
{
    public class ParallelSamples
    {
        private long m_FinishCounter = 0;

        /// <summary>
        /// Starts all jobs in a single sequence.
        /// </summary>
        /// <param name="sequences"></param>
        /// <param name="func"></param>
        public void StartSequence(int sequences, Action<object> func)
        {
            //if try is absent it throws property already set error when 1 is executed
            try
            {
                Thread.CurrentThread.Name = "SingleThread";
            }
            catch { }

            for (int i = 0; i < sequences; i++)
            {
                func(null);
            }
        }


        /// <summary>
        /// Starts all job in parallel.
        /// </summary>
        /// <param name="threads"></param>
        /// <param name="func"></param>
        public void StartThreadsParallel(int threads, Action<object> func)
        {
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
        /// Creates Tasks, then starts tasks with waiting on all of them to complete.
        /// </summary>
        /// <param name="threads"></param>
        /// <param name="func"></param>
        public void StartParallelTasks(int threads, Action<object> func)
        {
            List<Task> tList = new List<Task>();

            for (int i = 0; i < threads; i++)
            {
                var t = new Task(func, new Action<string>(OnThreadFinished));
                tList.Add(t);
            }

            foreach (var t in tList)
            {
                t.Start();
            }

            Task.WaitAll(tList.ToArray());
        }
    }
}
