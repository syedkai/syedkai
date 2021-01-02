using System;
using System.Diagnostics;
using System.Threading;
using System.Linq;

namespace ParallelandSequenceWIthTHREAD
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Number of threads is 100");

            int threadnumber = 100;
            Thread.CurrentThread.Name = "Main Thread";
            Thread t = new Thread(new ThreadStart(MainThread));
            t.Name = "t instance Thread";
            t.Start();

            ThreadExsercise.SequentialExecution(threadnumber, Executable: Work);

            Stopwatch sw = new Stopwatch();
            sw.Start();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(Thread.CurrentThread.Name);
            }
            
            //Thread.Sleep(0);
            Console.WriteLine("from main function.");
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
            Console.ReadKey();

        }
        static void Work(object actiontest)
        {
            Console.WriteLine("from work function.");
            Console.WriteLine((string)actiontest);
        }
        static void MainThread()
        {
            Console.WriteLine("!!!!!!!!!!!!!!!!!!!");
            //Console.WriteLine((string)actiontest);
        }


        //static int numThreads = 100;

        //static void Main(string[] args)
        //{

        //    Console.WriteLine("Press any Key to start.");
        //    Console.ReadKey();
        //    //Console.ReadLine();

        //    Stopwatch sw = new Stopwatch();
        //    sw.Start();

        //    ParallelSamples nt = new ParallelSamples();

        //    // Executes all tasks sequentianally
        //    //nt.StartSequenced(numThreads, workerFunction);

        //    // Executes with spaning of every worker on a single thread.
        //    nt.StartMultithreadedNative(numThreads, workerFunction);

        //    //nt.StartMultithreadedNativeV2(numThreads, workerFunction);

        //    //nt.StartWithTpl(numThreads, workerFunction);
        //    sw.Stop();

        //    Console.ForegroundColor = ConsoleColor.Cyan;
        //    Console.WriteLine("{0} ms", sw.ElapsedMilliseconds);

        //    Console.ReadLine();
        //}

        //private static void workerFunction(object onFinishDelegate)
        //{
        //    Console.ForegroundColor = ConsoleColor.Yellow;

        //    Console.WriteLine($"Started thread: {Thread.CurrentThread.Name} - {Thread.CurrentThread.ManagedThreadId}");

        //    double r = 202020203030442;
        //    for (int i = 0; i < 1500000; i++)
        //    {
        //        r = r * 1.94536;
        //    }

        //    if (onFinishDelegate != null)
        //    {
        //        ((Action<string>)onFinishDelegate)(Thread.CurrentThread.Name);
        //    }

        //    Console.ForegroundColor = ConsoleColor.Blue;

        //    Console.WriteLine("Stopped thread: {0}", Thread.CurrentThread.Name);
        //}


    }
}
