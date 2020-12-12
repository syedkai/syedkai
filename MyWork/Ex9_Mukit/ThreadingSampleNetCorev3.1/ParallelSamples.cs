using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingSampleNetCorev3._1
{

    class ParallelSamples
    {


        private long m_FinishCounter = 0;

        public void StartJobInSeqence(int sequences, Action<object> func)
        {
            try
            {
                Thread.CurrentThread.Name = "Single Main Thread";
            }
            catch { }
            finally
            {
                for (int i = 0; i < sequences; i++)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Job Sequence No: {0}", i);
                    func(null);
                }

            }

        }



        public void StartEachJobInOwnThread(int threads, Action<object> func)
        {
            for (int i = 0; i < threads; i++)
            {
                Thread t = null;
                try
                {
                    t = new Thread(new ParameterizedThreadStart(func));
                }
                catch
                {

                }
                finally
                {

                    t.Name = i.ToString();
                    t.Start(new Action<string>(OnThreadFinished));
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
                }
                catch
                {
                }
                finally
                {
                    tList.Add(t);
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
