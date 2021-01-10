using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesDemo
{
    internal abstract class AnimalBase
    {
        private int _someFiled;

        public void SetSomeField(int value)
        {
            this._someFiled = value;
        }

        public int GetSomeField()
        {
            return _someFiled;
        }

        internal int Age { get; set; }
        internal string Name { get; set; }

        internal AnimalBase() : this(1)
        {

        }

        internal AnimalBase(string name) : this(1, name)
        {
        }

        internal AnimalBase(int age) : this(age, "Anna")
        {
        }

        internal AnimalBase(int age, string name)
        {
            this.Name = name;
            this.Age = age;

        }

        internal void PrintName()
        {
            Console.WriteLine(this.Name);
        }
    }
}
