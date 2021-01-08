using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesandClasses
{
    class Person1 : PersonInterface
    {
        public void PrintName(string data)
        {
            Console.WriteLine($"Name is :{data}");

        }

    }
}
