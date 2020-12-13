using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseProgram_MeathodOverriding
{
    class Class1: Program
    {
        // we can also use new intead of override in that case virtual is not used in parent class
        public override void test2()
        {

            Console.WriteLine("child");

        }


       

        static void Main()

        {
            Program p;
            Class1 obj = new Class1();
            p = obj;
            obj.test2();
            p.tes1();
        }

    }
}
