using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HelloStudents
{
    class Counter
    {
        public void IncrementalCounter()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine(i);
                Thread.Sleep(250);
            }
        }

        public void DecrementalCounter()
        {
            for (int i = 50; i >= 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(250);
            }
        }
    }
}
