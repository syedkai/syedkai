using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_implementation
{
    public class Student
    {
        public string Name;
        public int Age;
        public int MattNo;

        public void Information()
        {
           Console.WriteLine("Hello! I am " + Name + " and my age is " + Age + " My mattriculation no is " + MattNo)
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "susmita";
            student.Age = 25;
            student.MattNo = 1234;

            student.Information();

        }
    }
}
