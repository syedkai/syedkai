using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Ex9
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadHandling t = new ThreadHandling();
            t.mutlithreadingExicution();
            t.StartJobInSeqence();
        }
    }
}

class ThreadHandling
{
    Action<Action> measure = (body) => {
        var startTime = DateTime.Now;
        body();
        Console.WriteLine("{0} {1}", DateTime.Now - startTime, Thread.CurrentThread.ManagedThreadId);
    };

    int finishCounter = 0;

    public void mutlithreadingExicution()
    {
        Action CalcJob = () => { for (int i = 0; i < 3500000; i++) ; };
        Action ioJob = () => { Thread.Sleep(1000); };

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Multi Threading");
        measure(() =>
        {

            var tasks = Enumerable.Range(1, 10)
            .Select(_ => Task.Factory.StartNew(() => measure(ioJob)))
            .ToArray();
            Task.WaitAll(tasks);
            Console.ReadLine();
        });
    }


    public void StartJobInSeqence()
    {
        Console.WriteLine("Start Job In Seqence");
        try
        {
            Thread.CurrentThread.Name = "Single Main Thread";
        }
        catch { }
        finally
        {
            for (int i = 0; i < 20; i++)
            {
                measure(() =>
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Job Sequence No: {0}", i);
                });
            }

        }

    }
}