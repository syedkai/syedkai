using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesDemo
{
    internal abstract class AnimalBase
    {
        public int Age { get; set; }

        public string Name { get; set; }

        public AnimalBase():this(1)
        {

        }

        public AnimalBase(string name) : this(1,name)
        {
            this.Name = name;
        }

        public AnimalBase(int age) : this(age, "Anna")
        {
            this.Age = age;
        }

        public AnimalBase(int age, string name)
        {
            this.Age = age;
            this.Name = name;
        }

    }
}
