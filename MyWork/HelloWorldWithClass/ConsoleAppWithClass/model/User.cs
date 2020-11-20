using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppWithClass
{
    internal class User
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public User() { }

        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public string AgeMessage()
        {
            if (Age <= 10)
            {
                return "Du bist ein Kind";
            } 
            else if (Age < 20)
            {
                return "Du bist ein Junge order ein Mädchen";
            } 
            else if (Age <= 40)
            {
                return "Sie sind ein Mann oder eine Frau";
            }
            else
            {
                return "Sie sind ein Opa oder eine Oma";
            }
        }
    }
}
