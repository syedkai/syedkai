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
            Console.WriteLine("Thread ${0}", Thread.CurrentThread.Name);

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
        }
    }
}
