using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Threading;

namespace ThreadingSampleNetCorev3._1
{
    class Program
    {
        private static readonly int numberOfThreads = 12;
        private static readonly int numberOfProcessors = 9;

        static void Main(string[] args)
        {
            Process.GetCurrentProcess().ProcessorAffinity = (System.IntPtr)numberOfProcessors;
            ParallelSample parallel = new ParallelSample();
            Stopwatch stopWatch = new Stopwatch();
            ///Job Execution in Sequence
            ///
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Run Job in Own Thread");
            stopWatch.Start();
            parallel.StartEachJobInOwnThread(12, Workerfuntion);
            stopWatch.Stop();
            Console.WriteLine("Type: Run Job in Own Thread, " + " Number of Processors: " + numberOfProcessors + "; Total Threads: ");
            Console.WriteLine(+numberOfThreads + "; Execution time: " + stopWatch.ElapsedMilliseconds + "ms");
            ///Job Execution in Sequence
            ///
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Run Job in Sequence");
            stopWatch.Start();
            parallel.StartJobInSeqence(12, Workerfuntion);
            stopWatch.Stop();
            Console.WriteLine("Type: Job in Sequence, " + " Number of Processors: " + numberOfProcessors + "; Total Threads: " );
            Console.WriteLine(+numberOfThreads + "; Execution time: " + stopWatch.ElapsedMilliseconds + "ms");
            ///Job Execution in Parallel

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Run Job in Parallel");
            stopWatch.Restart();
            parallel.StartJobsInParallel(12, Workerfuntion);
            stopWatch.Stop();
            Console.WriteLine("Type: Running Jobs in Parallel, " + " Number of Processors: " + numberOfProcessors + "; Total Threads: ");
            Console.WriteLine(+ numberOfThreads + "; Execution time: " + stopWatch.ElapsedMilliseconds + "ms");
        }

        private static void Workerfuntion(Object onFinishDelegate)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Started thread: {Thread.CurrentThread.Name} - {Thread.CurrentThread.ManagedThreadId}");
            int n = 1;

            for (int i = 0; i < 6; i++)
            {
                n += 1;
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