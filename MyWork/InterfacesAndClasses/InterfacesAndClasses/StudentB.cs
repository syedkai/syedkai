using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesAndClasses
{
    class StudentB : IStudent
    {
        public void age(int a)
        {
            int b = 5;
            Console.WriteLine($"Age: {a+b}");
        }

        public void marks(double m)
        {
            double n = 1.5;
            Console.WriteLine($"Marks: {m + n}");
        }

        public void name(string n)
        {
            string o = "Trick";
            Console.WriteLine($"Marks: {n} {o}");
        }
    }
}
