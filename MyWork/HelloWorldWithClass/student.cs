using System;
using System.Collections.Generic;
using System.Text;

namespace school
{
    class student
    {
        public int rollno;
        public string name;
        public int age;
        public int standard;
        public string fathername;
        public string mothername;
        public string bloodgroup;

        public void setstudent(int rollno, string name, int age, int standard, string fathername, string mothername, string bloodgroup)
        {
            this.rollno = rollno;
            this.name = name;
            this.age = age;
            this.standard = standard;
            this.fathername = fathername;
            this.mothername = mothername;
            this.bloodgroup = bloodgroup;
        }
        public void getstudent()
        {
            Console.WriteLine("Roll no :  " + this.rollno);
            Console.WriteLine("Name :  " + this.name);
            Console.WriteLine("Age :  " + this.age);
            Console.WriteLine("Class :  " + this.standard);
            Console.WriteLine("Father Name :  " + this.fathername);
            Console.WriteLine("Mother Name:  " + this.mothername);
            Console.WriteLine("Blood Group :  " + this.bloodgroup);

        }
    }
}
