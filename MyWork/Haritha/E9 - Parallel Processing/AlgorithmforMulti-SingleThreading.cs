using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace E9___Parallel_Processing
{
    class AlgorithmforMultiSingleThreading
    {
        private long m_FinishCounter = 0;



        // one by one execution
        public void Sequential(int threadcount, Action<object> func)
        {
            Thread.CurrentThread.Name = "Sequential - 1 Thread";

            for (int i = 0; i < threadcount; i++)
            {
                func(null);
            }


        }



        // Multi threading with threads <= no of cores
        public void Multicore(int threads, int Threadcount, Action<object> func)
        {
            List<Thread> threadList = new List<Thread>();
            for (int i = 0; i < Threadcount; i++)
            {
                var t = new Thread(new ParameterizedThreadStart(func));
                t.Name = i.ToString();
                threadList.Add(t);
            }
            if (threads == 2)
            {                
                    for (int j = 0; j < 50; j++)
                    {
                        threadList[j].Start(new Action<string>(OnThreadFinished));
                    }
                    for (int j = 50; j < 100; j++)
                    {
                        threadList[j].Start(new Action<string>(OnThreadFinished));
                    }

            }
            if (threads == 3)
            {
                for (int j = 0; j < 33; j++)
                {
                    threadList[j].Start(new Action<string>(OnThreadFinished));
                }
                for (int j = 33; j < 67; j++)
                {
                    threadList[j].Start(new Action<string>(OnThreadFinished));
                }
                for (int j = 67; j < 100; j++)
                {
                    threadList[j].Start(new Action<string>(OnThreadFinished));
                }

            }
            if (threads == 4)
            {
                for (int j = 0; j < 25; j++)
                {
                    threadList[j].Start(new Action<string>(OnThreadFinished));
                }
                for (int j = 25; j < 50; j++)
                {
                    threadList[j].Start(new Action<string>(OnThreadFinished));
                }
                for (int j = 50; j < 75; j++)
                {
                    threadList[j].Start(new Action<string>(OnThreadFinished));
                }
                for (int j = 75; j < 100; j++)
                {
                    threadList[j].Start(new Action<string>(OnThreadFinished));
                }
            }

            while (true)
            {
                if (Interlocked.Read(ref m_FinishCounter) == Threadcount)
                    break;
                else
                    Thread.Sleep(500);
            }
        }



        // Multi Threading with context switches happening
        public void Multicontextswitch(int threadcount, Action<object> func1)
        {
            List<Thread> threadList = new List<Thread>();

            for (int i = 0; i < threadcount; i++)
            {
                var t = new Thread(new ParameterizedThreadStart(func1));
                t.Name = i.ToString();
                threadList.Add(t);
            }
            // starting the threads
            for (int m = 0; m < threadcount; m++)
            {
                threadList[m].Start(new Action<string>(OnThreadFinished));
                // thread.Start always accepts only one argument, so create an array to pass more than one
            }
            while (true)
            {
                if (Interlocked.Read(ref m_FinishCounter) == threadcount)
                    break;
                else
                    Thread.Sleep(500);
            }
        }



        // internal scheduler doing tasks parallely
        public void Parallel(int threadcount, Action<object> func)
        {
            List<Task> tList = new List<Task>();

            for (int i = 0; i < threadcount; i++)
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


        //Counter mode to exit
        public void OnThreadFinished(string threadName)
        {
            Interlocked.Increment(ref m_FinishCounter);
        }
    }
}
