using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingSampleNetCorev3._1
{
    class Parallel
    {

        private long m_FinishCounter = 0;

        public void StartEachJobInOwnThread(int threads, Action<object> func)
        {
            for (int i = 0; i < threads; i++)
            {
                Thread t = null;
                try
                {
                    t = new Thread(new ParameterizedThreadStart(func));
                    t.Name = i.ToString();
                    t.Start(new Action<string>(OnThreadFinished));
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            while (true)
            {
                if (Interlocked.Read(ref m_FinishCounter) == threads)
                    break;
                else
                    Thread.Sleep(500);
            }
        }

        public void StartJobInSeqence(int sequences, Action<object> func)
        {
            try
            {
                Thread.CurrentThread.Name = "Single Thread";
                for (int i = 0; i < sequences; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Sequence No: {0}", i);
                    func(null);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        private void OnThreadFinished(string threadName)
        {
            Interlocked.Increment(ref m_FinishCounter);
        }



        public void StartJobsInParallelTask(int threads, Action<object> func)
        {


            List<Task> tList = new List<Task>();

            for (int i = 0; i < threads; i++)
            {
                Task t = null;
                try
                {
                    t = new Task(func, new Action<string>(OnThreadFinished));
                    tList.Add(t);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            foreach (var t in tList)
            {
                t.Start();
            }

            Task.WaitAll(tList.ToArray());

        }

    }
}
