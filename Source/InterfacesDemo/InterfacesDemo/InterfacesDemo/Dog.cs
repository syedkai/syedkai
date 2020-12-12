using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesDemo
{
    internal class Dog : AnimalBase, IAnimal
    {
        internal Dog()
        {
        }

        internal Dog(string name) : base(name)
        {
        }

        internal Dog(int age) : base(age)
        {
        }

        internal Dog(int age, string name) : base(age, name)
        {
        }

        public void Eat()
        {
            Console.WriteLine($"{Name} eats happy.");
        }

        public void Move()
        {
            Console.WriteLine($"{Name} jumps around in joy.");
        }
    }
}
