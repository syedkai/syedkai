using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesDemo
{
    internal class Cat : AnimalBase, IAnimal
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

        internal Cat(int age, string name) : base(age, name)
        {

        }

        public void Eat()
        {
            Console.WriteLine($"{Name} eats angry.");
        }

        public void Move()
        {
            Console.WriteLine($"{Name} lies angry on the shelf");
        }
    }
}
