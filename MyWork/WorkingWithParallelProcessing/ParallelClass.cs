using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ParallelProcessing
{
    class ParallelClass
    {
        private long m_FinishCounter = 0;
        /// <param name="sequences"></param>
        /// <param name="func"></param>
        public void StartSequenced(int sequences, Action<object> func)
        {
            Thread.CurrentThread.Name = "SingleThread";
            for (int i = 0; i < sequences; i++)
            {
                func(null);
            }
        }
        /// <param name="threads"></param>
        /// <param name="func"></param>
        public void StartMultithreadedNative(int threads, Action<object> func)
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
        /// <param name="threads"></param>
        /// <param name="func"></param>
        public void StartMultithreadedNativeV2(int threads, Action<object> func)
        {
            List<Thread> tList = new List<Thread>();
            for (int i = 0; i < threads; i++)
            {
                var thread = new Thread(new ParameterizedThreadStart(func));
                thread.Name = i.ToString();
                tList.Add(thread);
            }
            foreach (var item in tList)
            {
                item.Start(new Action<string>(OnThreadFinished));
            }
            while (true)
            {
                if (Interlocked.Read(ref m_FinishCounter) == threads)
                    break;
                else
                    Thread.Sleep(500);
            }
        }
        /// <param name="threads"></param>
        /// <param name="func"></param>
        public void StartWithTpl(int threads, Action<object> func)
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
