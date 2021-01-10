using System;
using System.Collections.Generic;
using System.Text;

namespace StructureofApplication.Person
{
    public class Student
    {

        public string Name;
        public int MattNo;

        public void Information()
        {
            Console.WriteLine("Hello! I am " + Name + " My mattriculation no is " + MattNo);
        }
    }
}
