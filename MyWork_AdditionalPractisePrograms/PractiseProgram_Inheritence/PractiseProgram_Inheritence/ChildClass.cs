using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseProgram_Inheritence
{
    class ChildClass : ParentClass
    {
        public ChildClass():base(50)

        {

            Console.WriteLine("Child Class constructor is called");
        }

        public void test()

        {


            Console.WriteLine("Test Meathod is called");
        }



        static void Main()

        {
            ChildClass obj = new ChildClass();
            obj.i = 5;
            Console.WriteLine(obj.i);
        }

    }
}
