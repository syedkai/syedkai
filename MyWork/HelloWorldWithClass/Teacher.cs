using System;
using System.Collections.Generic;
using System.Text;

namespace school
{
    class Teacher
    {
        public string Name;
        public int idno;
        public int Age;
        public string Bloodgroup;
        public string subject;

        public void setTeacher(string Name, int idno, int Age, string Bloodgroup, string subject)
        {
            this.Name = Name;
            this.idno = idno;
            this.Age = Age;
            this.Bloodgroup = Bloodgroup;
            this.subject = subject;
        }
        public void getTeacher()
        {
            Console.WriteLine("ID no :  " + this.idno);
            Console.WriteLine("Name :  " + this.Name);
            Console.WriteLine("Age :  " + this.Age);
            Console.WriteLine("Subject :  " + this.subject);
            Console.WriteLine("Blood Group :  " + this.Bloodgroup);
        }
    }
}
