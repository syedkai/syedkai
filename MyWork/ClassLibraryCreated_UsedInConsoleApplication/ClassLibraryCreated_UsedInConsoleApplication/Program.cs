using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;

namespace ClassLibraryCreated_UsedInConsoleApplication
{

    
    class Program
    {

       
        static void Main(string[] args)
        {

            Class1 obj = new Class1();


             Console.WriteLine("The final result of addition is " +obj.sum(30, 35));

            Console.ReadLine();

        }
    }
}
