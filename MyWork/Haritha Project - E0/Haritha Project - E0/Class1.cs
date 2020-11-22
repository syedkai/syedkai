using System;
using System.Collections.Generic;
using System.Text;

namespace Haritha_Project___E0
{
    class Car  // Parent class
    {
        public void Information()
        {
            Console.WriteLine("The available models are : ");
        }
    }
    class Ford : Car  // Derived class 1
    {
        public void Model()
        {
            Console.WriteLine("\n Mustang &\n Fiesta \n ");
        }
    }
    class Benz : Car   // Derived class 2
    {
        public void Model()
        {
            Console.WriteLine("\n C class &\n A class \n ");
        }
    }
    class BMW : Car  // Derived class 3
    {
        public void Model()
        {
            Console.WriteLine("\n X1 &\n X3 \n ");
        }
    }
}
