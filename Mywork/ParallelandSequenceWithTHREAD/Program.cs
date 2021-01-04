using System;
using System.Diagnostics;
using System.Threading;

namespace ParallelandSequenceWIthTHREAD
{
    class Program
    {

        static int numThreads = 10;

        static void Main(string[] args)
        {

            Console.WriteLine("Press any Key to start.");
            Console.ReadKey();
            
            ThreadExsercise th = new ThreadExsercise();

            /*
             * ---------------------------------------------------------------------------------------------
             * Exercise No. 1
             * Run a job in Sequence
             * ---------------------------------------------------------------------------------------------
             */
            //Stopwatch ex1 = new Stopwatch();
            //ex1.Start();

            //th.Exercise11(numThreads, Work);

            //ex1.Stop();
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("After Exercise 1.1 finish - " + "{0} ms", ex1.ElapsedMilliseconds);


            /* 
             * ---------------------------------------------------------------------------------------------
             * Exercise No. 2
             * Executes all tasks sequentianally with its own thread
             * ---------------------------------------------------------------------------------------------
             */
            //Stopwatch sequencesw = new Stopwatch();
            //sequencesw.Start();

            //th.SequentialExecution(numThreads, Work);

            //sequencesw.Stop();
            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("From Exercise 2 finish - " + "{0} ms", sequencesw.ElapsedMilliseconds);


            /* 
            * ---------------------------------------------------------------------------------------------
            * Exercise No. 3
            * Executes all thread parallely with its own thread
            * ---------------------------------------------------------------------------------------------
            */
            Stopwatch parallelsw = new Stopwatch();
            parallelsw.Start();

            th.ParallelExecution(numThreads, Work);

            parallelsw.Stop();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("After Exercise 3 finish {0} ms", parallelsw.ElapsedMilliseconds);

            /* 
            * ---------------------------------------------------------------------------------------------
            * Exercise No. 3
            * Executes all tasks parallely with its own thread
            * ---------------------------------------------------------------------------------------------
            */
            //Stopwatch parallelwithtasksw = new Stopwatch();
            //parallelwithtasksw.Start();

            //th.ParallelExecutionWithTask(numThreads, Work);

            //parallelwithtasksw.Stop();

            //Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine("After Exercise 3 finish {0} ms", parallelwithtasksw.ElapsedMilliseconds);

            Console.ReadLine();



        }

        private static void Work(object name)
        {

            Console.WriteLine($"Started thread: {Thread.CurrentThread.Name}");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine((string)name + "count - {0}",i);
            }

            Console.WriteLine("Stopped thread: {0}", Thread.CurrentThread.Name);

        }

    }
}