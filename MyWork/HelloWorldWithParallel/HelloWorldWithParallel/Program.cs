using System;
using System.Diagnostics;
using System.Threading;

namespace HelloWorldWithParallel
{
    class Program
    {
        static int numThreads = 100; //50,100,150
        //public static int rand = new Random();

        static void Main(string[] args)
        {
            Console.WriteLine("This a demonstration of Threading by compared methods with Single sequence, Threading and Task in parallel.");

            int caseTask;

            string instruction = $"-----------------------------------------------------------\n" +
                "Threads number = {0}\n" +
                "1. Single Job in sequences.\n" +
                "2. Start Jobs in its own Thread.\n" +
                "3. Start Jobs in Parallel (List all task and run threads).\n" +
                "4. Change number of Threads.\n" +
                "0. End session\n" +
                "-----------------------------------------------------------\n" +
                "Select from 1-4 to execute or type 0 to end the session.\n";

            do
            {
                ParallelClass task = new ParallelClass();
                
                Console.ForegroundColor = ConsoleColor.Blue;
                
                Console.WriteLine(instruction, numThreads);
                
                Console.Write("Input: ");
                
                var str = Console.ReadLine();
                
                try
                {
                    caseTask = Int32.Parse(str);
                }

                catch
                {
                    continue;
                }

                Stopwatch sw = new Stopwatch();

                switch (caseTask)
                {
                    case 1:
                        // 1. Single Thread
                        sw.Start();
                        task.StartJob(numThreads, workerFunction);
                        sw.Stop();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Elapsed time : {0} ms", sw.ElapsedMilliseconds);
                        break;
                    case 2:
                        // 2. Job in its own Thread
                        sw.Start();
                        task.StartJobInItsThread(numThreads, workerFunction);
                        sw.Stop();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Elapsed time : {0} ms", sw.ElapsedMilliseconds);
                        break;
                    case 3:
                        // 3. Jobs in parallel ( Task )
                        sw.Start();
                        task.StartJobParallel(numThreads, workerFunction);
                        sw.Stop();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Elapsed time : {0} ms", sw.ElapsedMilliseconds);
                        break;
                    case 4:
                        // 4. Change the numThread value;
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.Write("Please type in your desired thread numbers: ");
                        numThreads = Int32.Parse(Console.ReadLine());
                        break;
                    default:
                        break;
                }
                
                if (caseTask == 0)
                    break;

            } while (true);  
        }

        /// <summary>
        /// run a random function
        /// </summary>
        /// <param name="OnfinishDelegate"></param>
        private static void workerFunction(object onFinishDelegate)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine($"Started thread: {Thread.CurrentThread.Name} - {Thread.CurrentThread.ManagedThreadId}");
            
            double r = 202020203;
            int loop = 3500000;
            double factor = 1.5;

            for (int i = 1; i < loop; i++)
            {
                r = r*factor;
            }

            if (onFinishDelegate != null)
            {
                ((Action<string>)onFinishDelegate)(Thread.CurrentThread.Name);
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Stop Thread: {0}", Thread.CurrentThread.Name);
        }
    }
}
