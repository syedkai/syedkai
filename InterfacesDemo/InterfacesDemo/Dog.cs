using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesDemo
{
    internal class Dog : AnimalBase
    {
        internal Dog() : base(1)
        {

        }

        internal Dog(int age) : base(age, "Anna")
        {

        }

        internal Dog(string name) : base(1, name)
        {

        }

        internal Dog(int age, string name) : base(age, name)
        {

        }
        
        internal void PrintName()
        {
            Console.WriteLine(this.Name);
        }



    }
}
