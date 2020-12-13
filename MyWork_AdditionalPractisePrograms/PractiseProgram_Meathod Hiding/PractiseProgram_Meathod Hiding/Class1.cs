using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseProgram_Meathod_Hiding
{
    class Class1:Program
    {

        public new void test()
        {

            Console.WriteLine("I am child Class");
        }

        public void Parentclass()

            {

            base.test();
        
        }

        static void Main()


        {
            Class1 obj = new Class1();
            obj.test();
            obj.Parentclass();
            Program p;
            p = obj;
            p.test();

        }
    }
}
