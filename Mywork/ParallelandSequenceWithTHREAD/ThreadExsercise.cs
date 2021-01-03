using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ParallelandSequenceWIthTHREAD
{
    class ThreadExsercise
    {
        private long m_FinishCounter = 0;

        public void Exercise11(int numberofthreads, Action<object> Worker)
        {

            Thread threadobject = new Thread(new ParameterizedThreadStart(Worker));
            threadobject.Name = "Single thread execution";

            for (int i = 0; i < numberofthreads; i++)
            {
                if (i > 0)
                {
                    Worker(threadobject.Name);
                    continue;
                }
                threadobject.Start(threadobject.Name);
            }

        }


        public void SequentialExecution(int numberofthreads, Action<object> Worker)
        {
            
            for (int i = 0; i < numberofthreads; i++)
            {
                
                Thread threadobject = new Thread(new ParameterizedThreadStart(Worker));
                threadobject.Name = "Sequential Execution " + Convert.ToString(i) + " ";
                threadobject.Start(threadobject.Name);
                threadobject.Join();

            }

            //Thread.Sleep(5000);
        }

        

        public void ParallelExecution(int numberofthreads, Action<object> Worker)
        {
            for (int i = 0; i < numberofthreads; i++)
            {
                var t = new Thread(new ParameterizedThreadStart(Worker));
                t.Name = i.ToString();

                Interlocked.Increment(ref m_FinishCounter);

                t.Start(t.Name);
            }

            while (true)
            {
                if (Interlocked.Read(ref m_FinishCounter) == numberofthreads)
                    break;
                else
                    Thread.Sleep(500);
            }

        }

    }
}
