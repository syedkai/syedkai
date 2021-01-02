using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace Library_consumed
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();
          double Result =  obj.addition(2.3, 7);
            Console.WriteLine(Result);
            Console.ReadLine();

        }
    }
}
