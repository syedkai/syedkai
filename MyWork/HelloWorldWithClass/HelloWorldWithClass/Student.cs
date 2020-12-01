using System;
using System.Text;

namespace HelloWorldWithClass
{

    public class Student
    {

        string name;
        int age;
        string nationality;

        public Student(String x, int y, string z)

        {
            this.name = x;
            this.age = y;
            this.nationality = z;
        }

        public string getname()
        {
            return name;

        }

        public int getage()
        {
            return age;

        }

        public string getnationality()
        {
            return nationality;
        }

        public string toString()
        {
           return ("Hi my name is " + this.getname() + ".\nMy age is " + this.getage() + " and my nationality is " + this.getnationality() + ".");
        }
      


    }
}