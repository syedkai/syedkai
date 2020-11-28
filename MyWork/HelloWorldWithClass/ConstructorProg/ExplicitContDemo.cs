using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorProg
{
    class ExplicitContDemo
    {
        public ExplicitContDemo()
        {
            Console.WriteLine("Constructor is called");
        }

        static void Main()
        {

            ExplicitContDemo obj1 = new ExplicitContDemo();

            
        }

    }
}
