using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Threading;

namespace ThreadingSampleNetCorev5._0
{
    class Program
    {


        static int numThreads, coreCount = 0, numProcessors = 0, choicedTestNameNumber = 0;
        static Stopwatch sw;
        static string runtimenetCoreVer,testName;

        static void Main(string[] args)
        {
            
            Regex r = new Regex(@"[1-9]");
           
            //SystemCoreCount();
            runtimenetCoreVer = System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription;
            Console.WriteLine("Framework Version: "+ runtimenetCoreVer);
           


            Console.WriteLine("To stop the programme please type 'exit' ");

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                displayCommonMessage();
                Console.WriteLine("\nPlease enter a choice number from suggested Test Name :");
                string tn = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\nPlease enter number of Threads:");
                string line = Console.ReadLine();
                Console.WriteLine("\nNumber of processors (Affinity in TaskMgr):");
                string np = Console.ReadLine();

                if (line == "exit")
                {
                    break;
                }

                else if (r.IsMatch(line) && r.IsMatch(np) && r.IsMatch(tn))
                {

                    choicedTestNameNumber = int.Parse(tn);
                    numThreads = int.Parse(line);
                    numProcessors = int.Parse(np);
                    Process.GetCurrentProcess().ProcessorAffinity = (System.IntPtr)numProcessors;
                    sw = new Stopwatch();
                    sw.Start();
                    ParallelSamples sample = new ParallelSamples();
                    /*
                    * set number of processors (affinity in taskMgr)
                    */

                    switch (choicedTestNameNumber) {
                        case 1:
                            /*
                             * start all jobs sequencially using main single thread
                            */
                            testName = "a job in Sequence";
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nStarting Run a job in Sequence....\n");
                            sample.StartJobInSeqence(numThreads, Workerfuntion);
                            sw.Stop();
                            FormatOutput(1, 1);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;

                        case 2:
                            /*
                            * start all jobs in each thread separately to perfrom multithreading
                            */
                            testName = "a job in Sequence";
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nStarting to  Run every job in its own thread....\n");
                            sw.Restart();
                            sample.StartEachJobInOwnThread(numThreads, Workerfuntion);
                            sw.Stop();
                            FormatOutput(2, numThreads);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;

                        case 3:
                            /*
                             *  start all jobs Parallel Task
                            */
                            testName = "jobs as parallel Tasks";
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\nStarting to  Run jobs as parallel Tasks....\n");
                            sw.Restart();
                            sample.StartJobsInParallelTask(numThreads, Workerfuntion);
                            sw.Stop();
                            FormatOutput(3, numThreads);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;
                            

                    }

       
                    //GC.SuppressFinalize(sample);

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\ninvalid input. input number should be > 0 . please try again\n");
                }
                  
            }  
        }

        private static void displayCommonMessage()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Please choose a Test Name from following three dwon there:");
            Console.WriteLine("1->Run a job in Sequence");
            Console.WriteLine("2->Run every job in its own thread");
            Console.WriteLine("3->Run jobs as parallel Tasks");
            Console.WriteLine("-----------------------------------");

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
            Console.ForegroundColor = ConsoleColor.White;
            switch (p_type)
            {

                case 1:
                    Console.WriteLine("Approach: "+ testName+"; number of processors: " +numProcessors + "; total_threads:" + numberOfthreds + "; execution time: " + "{0} ms", sw.ElapsedMilliseconds);
                    break;
                case 2:
                    Console.WriteLine("Approach: " + testName + "; number of processors: " + numProcessors+ "; total_threads: " + numberOfthreds + "; execution time: " + "{0} ms", sw.ElapsedMilliseconds);
                    break;
                case 3:
                    Console.WriteLine("Approach: " + testName + "; number of processors: " + numProcessors + "; total_threads: " + numberOfthreds + "; execution time: " + "{0} ms", sw.ElapsedMilliseconds);
                    break;
                
            }
        }

        private static void SystemCoreCount()
        {
            coreCount = Environment.ProcessorCount;
        }


    }
}
