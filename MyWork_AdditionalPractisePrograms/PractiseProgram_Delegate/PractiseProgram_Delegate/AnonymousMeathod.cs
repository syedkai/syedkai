using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseProgram_Delegate
{
    public delegate string GreatDelegate(string name);

    class AnonymousMeathod
    {

        

        static void Main()

        {
            GreatDelegate obj5 = delegate (string name)
            {
                return "Hello " + name + " a very Good Morning";
            };
            string str =obj5.Invoke("Shivam");
            Console.WriteLine(str);
            Console.ReadLine();

        }
    }
}
