using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseProgram_Inheritence
{

    
    class ParentClass
    {

        public int i;

        public ParentClass(int x)

            {
            Console.WriteLine("Parent Class constructor is calledamd the vslue of x is " +x);

           }

        public void print()
        {

            Console.WriteLine("Print meathod is called ");
        }
        static void Main(string[] args)
        {
        }
    }
}
