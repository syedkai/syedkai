using System;
using System.Threading;

namespace ParallelProcessing
{
    class Program
    {
        static void Main(string[] args)
        {

            Parallel parallel = new Parallel();
            parallel.sequence(5, callback);

            Console.ReadLine();
        }

        private static void callback(object onComplete)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0} : Start Thread name {1}", Thread.CurrentThread.ManagedThreadId,Thread.CurrentThread.Name);
            Console.ResetColor();

            long count = 9999;
            long total = 0;
            for (int i = 0; i < count; i++) {
                Console.WriteLine(i);
                total += (i + 1) * count / 50*16;
            }

            if (onComplete != null)
            {
                ((Action<String>) onComplete)(Thread.CurrentThread.Name);
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("{0} : Stop Thread name {1}", Thread.CurrentThread.ManagedThreadId, Thread.CurrentThread.Name);
            Console.ResetColor();
        }
    }
}
