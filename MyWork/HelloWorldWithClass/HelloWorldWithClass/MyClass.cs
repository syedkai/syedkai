using System;
namespace HelloWorldWithClass
{
    public class School
    {
        string school;

        public School(string b)
        {
            this.school = b;
        }

        public string getschool()
        {
            return school;
        }

        public string aboutschool()
        {
            return ("I am studying in " + this.getschool() + "." );
        }
    }
}