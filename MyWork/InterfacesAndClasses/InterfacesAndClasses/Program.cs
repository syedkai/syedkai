using System;

namespace InterfacesAndClasses
{
    /// <summary>
    /// Exercise 8 demonstrates two classes which implement an interface
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //Student A
            IStudent studA = new StudentA();
            studA.name("Sabeen");
            studA.age(23);
            studA.marks(76.7);

            //Student B
            IStudent studB = new StudentB();
            studB.name("Angela");
            studB.age(25);
            studB.marks(70);

        }
    }
}
