using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace HelloWorldWithParallel
{
    class ParallelClass
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

            for(int i = 0; i < sequences; i++)
            {
                func(null);
            }

        } 

        /// <summary>
        /// Execute each job in its own Thread
        /// </summary>
        public void StartJobInItsThread()
        {

        }

        /// <summary>
        /// Execute Jobs in parallel
        /// </summary>
        public void StartJobParallel()
        {

        }
}
