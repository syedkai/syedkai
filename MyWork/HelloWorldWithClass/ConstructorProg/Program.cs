using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorProg
{
    class Program
    {
        int i;
        static void Main(string[] args)
        {
            Program p = new Program ();

            Console.WriteLine("The value of i is: " +p.i);

            
        }
    }
}
