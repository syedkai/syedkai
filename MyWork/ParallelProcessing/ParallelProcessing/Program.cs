using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace ParallelProcessing
{
    class Program
    {
        private String FilePath = @"C:\Users\dell 5510 i.7 6th HQ\local repo\se-cloud-2020-2021\MyWork\ParallelProcessing\ParallelProcessing\TestNET3.txt";
        static int numThreads = 150;                              // Number of Threads          

        static void Main(string[] args)
        {

           
            Stopwatch sw = new Stopwatch();
            sw.Start();

            ThreadCreator nt = new ThreadCreator();                         // User Defined Class

            // Executes all tasks sequentianally
           // nt.StartSequenced(numThreads, workerFunction);                  // Sequence Thread Execution

            // Executes with spaning of every worker on a single thread.
           // nt.StartMultithreadedNative(numThreads, workerFunction);        // parrallel Thread Execution

             nt.StartMultithreadedNativeV2(numThreads, workerFunction);       // Concurrent Thread Execution

            // nt.StartWithTpl(numThreads, workerFunction);                  
            sw.Stop();

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("{0} ms", sw.ElapsedMilliseconds);

            Program p = new Program();

            p.WriteFile(sw.ElapsedMilliseconds.ToString());

            Console.ReadLine();

        }

        private static void workerFunction(object onFinishDelegate)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"Started thread: {Thread.CurrentThread.Name} - {Thread.CurrentThread.ManagedThreadId}");

            double r = 202020203030442;
            for (int i = 0; i < 1500000; i++)
            {
                r = r * 1.94536;
            }

            if (onFinishDelegate != null)
            {
                ((Action<string>)onFinishDelegate)(Thread.CurrentThread.Name);
            }

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("Stopped thread: {0}", Thread.CurrentThread.Name);
        }



        public void WriteFile(string line)
        {

            StreamWriter rf = File.AppendText(FilePath);

            rf.WriteLine("{0}", line);

            rf.Close();

        }
    }
}
