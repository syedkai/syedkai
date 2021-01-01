using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Threading;

namespace ThreadingSampleNetCorev3._1
{
    class Program
    {
        private static readonly int numberOfThreads = 10;
        private static readonly int numberOfProcessors = 8;

        static void Main(string[] args)
        {
            Process.GetCurrentProcess().ProcessorAffinity = (System.IntPtr)numberOfProcessors;
            Parallel parallel = new Parallel();
            Stopwatch stopWatch = new Stopwatch();

            /*
             * Execution in Sequence
            */
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Job in Own Thread");
            stopWatch.Start();
            parallel.StartEachJobInOwnThread(10, Workerfuntion);
            stopWatch.Stop();
            Console.WriteLine();
            Console.WriteLine("Type: Job in Own Thread, " + " Number of Processors: " + numberOfProcessors + "; Total Threads: " + numberOfThreads + "; Execution time: " + stopWatch.ElapsedMilliseconds + "ms");

            /*
             * Execution in Sequence
            */
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Job in Sequence");
            stopWatch.Start();
            parallel.StartJobInSeqence(10, Workerfuntion);
            stopWatch.Stop();
            Console.WriteLine();
            Console.WriteLine("Type: Job in Sequence, " + " Number of Processors: " + numberOfProcessors + "; Total Threads: " + numberOfThreads + "; Execution time: " + stopWatch.ElapsedMilliseconds + "ms");

            /*
             * Execution in Parallel
            */

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Job in Parallel");
            stopWatch.Restart();
            parallel.StartJobsInParallelTask(10, Workerfuntion);
            stopWatch.Stop();
            Console.WriteLine();
            Console.WriteLine("Type: Job in Parallel, " + " Number of Processors: " + numberOfProcessors + "; Total Threads: " + numberOfThreads + "; Execution time: " + stopWatch.ElapsedMilliseconds + "ms");
        }

        private static void Workerfuntion(Object onFinishDelegate)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Started thread: {Thread.CurrentThread.Name} - {Thread.CurrentThread.ManagedThreadId}");
            int r = 1;

            for (int i = 0; i < 3; i++)
            {
                r = r + 1;
            }

            if (onFinishDelegate != null)
            {
                ((Action<string>)onFinishDelegate)(Thread.CurrentThread.Name);
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Stopped thread: {0}", Thread.CurrentThread.Name);

        }
    }
}