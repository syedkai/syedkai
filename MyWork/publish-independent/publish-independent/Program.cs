using System;
using System.Threading;

namespace publish_independent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello This is a stand alone build/deployment.");
            int length=20;
            for (int i = 0; i < length; i++)
            {

                Console.WriteLine("Updating numbers :"+ i);
                Thread.Sleep(500);
            }

            Console.ReadLine(); 
        }
    }
}
