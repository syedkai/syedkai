using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StructureofApplication.Person;

namespace StructureofApplication
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
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.Name = "Susmita";
            student.MattNo = 1234;

            student.Information();
        }
    }
}
