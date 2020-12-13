using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseProgram_Delegate
{
    public delegate string LamdaDelegate(string name);
    class LamdaExpression
    {


        static void Main()
        {

            LamdaDelegate obj5 = (name) =>
            {
                return "Hello " + name + " a very Good Morning";
            };
            string str = obj5.Invoke("Shivam");
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
