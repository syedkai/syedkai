using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadTaskExample
{
    public class ThreadTask
    {
        private long m_FinishCounter = 0;
        private void OnThreadFinished()
        {
            Interlocked.Increment(ref m_FinishCounter);
        }

        public void StartSequenced(int sequences, Action<object> func)
        {
            for (int i = 0; i < sequences; i++)
            {
                func(null);
            }
        }


        public void StartMultithreadedNative(int threads, Action<object> func)
        {
            for (int i = 0; i < threads; i++)
            {
                var t = new Thread(new ParameterizedThreadStart(func));
                t.Name = i.ToString();
                t.Start(new Action(OnThreadFinished));
            }

            while (true)
            {
                if (Interlocked.Read(ref m_FinishCounter) == threads)
                    break;
                //else
                //    Thread.Sleep(500);
            }
        }


        public void StartWithTpl(int threads, Action<object> func)
        {
            List<Task> tList = new List<Task>();

            for (int i = 0; i < threads; i++)
            {
                var t = new Task(func, new Action(OnThreadFinished));
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
