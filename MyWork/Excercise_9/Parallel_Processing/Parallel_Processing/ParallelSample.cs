using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingSampleNetCorev3._1
{
    class ParallelSample
    {

        private long FinishCounter = 0;

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
                if (Interlocked.Read(ref FinishCounter) == threads)
                    break;
                else
                    Thread.Sleep(1000);
            }
        }

        public void StartJobInSeqence(int sequences, Action<object> func)
        {
            try
            {
                Thread.CurrentThread.Name = "Single Thread";
                for (int i = 0; i < sequences; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
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
            Interlocked.Increment(ref FinishCounter);
        }

        public void StartJobsInParallel(int threads, Action<object> func)
        {

            List<Task> TaskList = new List<Task>();

            for (int i = 0; i < threads; i++)
            {
                Task T = null;
                try
                {
                    T = new Task(func, new Action<string>(OnThreadFinished));
                    TaskList.Add(T);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            foreach (var i in TaskList)
            {
                i.Start();
            }

            Task.WaitAll(TaskList.ToArray());

        }

    }
}