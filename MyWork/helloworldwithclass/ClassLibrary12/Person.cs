﻿using System;

namespace ClassLibrary12
{
    public class Person
    {
        public string Name { get; private set; }

        public Person(string name)
        {
            Name = name;
        }
    }
}
