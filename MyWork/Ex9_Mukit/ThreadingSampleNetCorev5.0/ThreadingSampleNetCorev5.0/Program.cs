using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Threading;

namespace ThreadingSampleNetCorev5._0
{
    class Program
    {


        static int numThreads, coreCount = 0;
        static Stopwatch sw;
        static string runtimenetCoreVer;

        static void Main(string[] args)
        {

            Regex r = new Regex(@"[0-9]");
            SystemCoreCount();
            runtimenetCoreVer = System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription;
            Console.WriteLine("Framework Version: "+ runtimenetCoreVer);
            Console.WriteLine("This programme will do three things using input threads numbers");
            Console.WriteLine(" 1. Will Run a job in Sequence");
            Console.WriteLine(" 2. Then Run every job in its own thread");
            Console.WriteLine(" 3. Finally, Run jobs as parallel Tasks");
            Console.WriteLine("-----------------------------------");



            Console.WriteLine("To stop the programme please type 'exit' ");

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nPlease enter number of Threads: .");
                string line = Console.ReadLine();

                if (line == "exit")
                {
                    break;
                }

                else if (r.IsMatch(line))
                {
                  
                    
                    numThreads = int.Parse(line);
                    sw = new Stopwatch();
                    sw.Start();
                    ParallelSamples sample = new ParallelSamples();
                    Thread.Sleep(500);

                    ;
                    /*
                     * start all jobs sequencially using main single thread
                     */
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nStarting Run a job in Sequence....\n");
                    sample.StartJobInSeqence(numThreads, Workerfuntion);
                    sw.Stop();
                    FormatOutput(1, 1);
                    Thread.Sleep(500);

                    /*
                    * start all jobs in each thread separately to perfrom multithreading
                    */
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nStarting to  Run every job in its own thread....\n");
                    sw.Restart();
                    sample.StartEachJobInOwnThread(numThreads, Workerfuntion);
                    sw.Stop();
                    FormatOutput(2, numThreads);

                    /*
                    *  start all jobs Parallel Task
                    */
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nStarting to  Run jobs as parallel Tasks....\n");
                    sw.Restart();
                    sample.StartJobsInParallelTask(numThreads, Workerfuntion);
                    sw.Stop();
                    FormatOutput(3, numThreads);

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    //GC.SuppressFinalize(sample);

                }
                else
                {
                    Console.WriteLine("invalid input. please try again");
                }
                  
            }  
        }


        private static void Workerfuntion(Object onFinishDelegate)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Started thread: {Thread.CurrentThread.Name} - {Thread.CurrentThread.ManagedThreadId}");
            int r = 1;
      
            for (int i = 0; i < 35000899; i++)
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


        private static void FormatOutput(int p_type,int numberOfthreds)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            switch (p_type)
            {

                case 1:
                    Console.WriteLine("Job Approach: Job in Sequence; framework_version: " + runtimenetCoreVer+ " cores: " + coreCount + " total_threads: "+ numberOfthreds + " elasped time: " + "{0} ms", sw.ElapsedMilliseconds);
                    break;
                case 2:
                    Console.WriteLine("Job Approach: Job in Each Thread; framework_version: " + runtimenetCoreVer + " cores: " + coreCount + " total_threads: " + numberOfthreds + " elasped time: " + "{0} ms", sw.ElapsedMilliseconds);
                    break;
                case 3:
                    Console.WriteLine("Job Approach: Parallel Task; framework_version: " + runtimenetCoreVer + " cores: " + coreCount + " total_threads: " + numberOfthreds + " elasped time: " + "{0} ms", sw.ElapsedMilliseconds);
                    break;
                
            }
        }

        private static void SystemCoreCount()
        {
            coreCount = Environment.ProcessorCount;
        }

       



   
    }
}
