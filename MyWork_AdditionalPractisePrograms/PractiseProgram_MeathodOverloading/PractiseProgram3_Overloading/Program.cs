using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseProgram3_Overloading
{
    class Program
    {
        public int test2()


        {
             return 5;
           
        }

        public void test1(int i)


        {

           
        }

        public void test1(double x)


        {


        }

        public void test1(bool y, int p)


        {
            Console.WriteLine("The meathod is called");

        }

        public void test1(bool y,string o)


        {
            Console.WriteLine("The value of variables are " + y );
           

        }
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.test1(false, "Mohan") ;
            obj.test1(false, 5);
            int a = obj.test2();

            Console.WriteLine( +a);
        }
    }
}
