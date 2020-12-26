using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldWithClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Print print_object = new Print();
            print_object.print_text("Hello World");
        }
    }
}
