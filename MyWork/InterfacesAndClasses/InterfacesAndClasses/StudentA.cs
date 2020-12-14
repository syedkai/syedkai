using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndClasses
{
    class StudentA : IStudent
    {
        public void age(int a)
        {
            Console.WriteLine($"My age is {a}");
        }

        public void marks(double m)
        {
            Console.WriteLine($"My marks are {m}");
        }

        public void name(string n)
        {
            Console.WriteLine($"My name is {n}");
        }
    }
}
