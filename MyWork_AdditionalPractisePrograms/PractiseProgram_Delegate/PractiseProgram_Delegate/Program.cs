using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseProgram_Delegate
{
    public delegate string GreetingDelegate(string name);
    class Program
    {

        public static string Greeting(string name)

        {
            return "Hello " + name + " a very Good Morning";

        }
        static void Main(string[] args)
        {
            GreetingDelegate obj = new GreetingDelegate(Greeting);
            string str =obj("Shivam");
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
