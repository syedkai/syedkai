using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ParallelandSequenceWIthTHREAD
{
    static class ThreadExsercise
    {
        public static void SequentialExecution(int numberofthreads, Action<object> Executable)
        {
            Thread threadobject = new Thread(new ParameterizedThreadStart(Executable));
            threadobject.Name = "Sequential Execution";
            threadobject.Start(threadobject.Name);

            Thread.Sleep(5000);
            Console.WriteLine("After second thread sleep");
            
        }

        private static void Executable(object name)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("From thread");
                Console.WriteLine((string)name);
            }
            
        }
    }
}
