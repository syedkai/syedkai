using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesDemo
{
    internal class Cat : AnimalBase
    {
        internal Cat() : base(1)
        {

        }

        internal Cat(int age) : base(age, "Anna")
        {

        }

        internal Cat(string name) : base(1, name)
        {

        }

        internal Cat(int age, string name) : base(age,name)
        {

        }

        internal void PrintName()
        {
            Console.WriteLine(this.Name);
        }

    }
}
