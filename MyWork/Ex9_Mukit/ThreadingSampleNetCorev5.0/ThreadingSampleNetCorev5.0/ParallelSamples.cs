using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadingSampleNetCorev5._0
{
    class ParallelSamples
    {
        public void StartJobInSeqence(int sequences , Action<object>func) {

            Thread.CurrentThread.Name = "Single Main Thread";


            for (int i = 0; i < sequences; i++) {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Job Sequence No: {0}", i);
                func(null);
            }

        }


  

        public void StartJobInMulitithred() { 
        }

        public void StartJobInParallel() { }

    }
}
