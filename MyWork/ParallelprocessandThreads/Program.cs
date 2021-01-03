using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace Parallelprocessing
{
    class Program
    {
        static int numThreads = 100;
        static void Main(string[] args)
        {
            Console.WriteLine("To compared methods with single thread , multiple threads and multiple tasks");

            int input;
            Console.ForegroundColor = ConsoleColor.Red;

            Console.Write("Enter number of threads:");
            try
            {
                numThreads = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Integer is not entered setting threads to 100");
                numThreads = 100;
            }
            string note = $"1.A Job in sequence\n" +
                "2. Every Jobs in its own Thread\n" +
                "3. Jobs as Parallel tasks\n" +
                "0. To End session";

            do
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(note);

                Console.Write("Enter number of your choice: ");
                try
                {
                    input = int.Parse(Console.ReadLine());
                }

                catch
                {
                    Console.WriteLine("Integer is not entered exiting the program");
                    input = 0;
                }
                ParallelSamples taskToRun = new ParallelSamples();

                Stopwatch sw = new Stopwatch();
                Console.WriteLine("The current affinity {0}", Process.GetCurrentProcess().ProcessorAffinity);

                switch (input)
                {
                    case 1:
                        sw.Start();
                        taskToRun.StartSequence(numThreads, workerFunction);
                        sw.Stop();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Elapsed time : {0} ms", sw.ElapsedMilliseconds);
                        break;
                    case 2:
                        sw.Start();
                        taskToRun.StartThreadsParallel(numThreads, workerFunction);
                        sw.Stop();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Elapsed time : {0} ms", sw.ElapsedMilliseconds);
                        break;
                    case 3:
                        sw.Start();
                        taskToRun.StartParallelTasks(numThreads, workerFunction);
                        sw.Stop();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Elapsed time : {0} ms", sw.ElapsedMilliseconds);
                        break;
                    default:
                        break;
                }

                if (input == 0)
                    break;

            } while (true);
        }

        private static void workerFunction(object onFinishDelegate)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"The thread that started: {Thread.CurrentThread.Name} - {Thread.CurrentThread.ManagedThreadId}");
            //to have some operation happening here.. this could be left empty too to check time.. 
            int r = 1;
            for (int i = 0; i < 100; i++)
            {
                r = r * i * i;
            }

            if (onFinishDelegate != null)
            {
                ((Action<string>)onFinishDelegate)(Thread.CurrentThread.Name);
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("The thread that stopped : {0}", Thread.CurrentThread.Name);
        }
    }
}
