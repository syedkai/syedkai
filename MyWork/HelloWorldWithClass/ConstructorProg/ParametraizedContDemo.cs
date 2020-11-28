using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorProg
{
    class ParametraizedContDemo
    {
        int x;
        public ParametraizedContDemo(int i)
        {
            x = i;
            Console.WriteLine("The value of i is " +i);
        }

        public void display()
        {

            Console.WriteLine("The value of x is: " +x);
        
        }
        static void Main()
        {

            ParametraizedContDemo cd1 = new ParametraizedContDemo(10);
            ParametraizedContDemo cd2 = new ParametraizedContDemo(20);
            ExplicitContDemo cd3 = new ExplicitContDemo();

            cd1.display();

        }

    }
}
