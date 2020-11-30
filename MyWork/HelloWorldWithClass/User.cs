using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldWithClass
{
    class User
    {
        private string Name;
        private int Age;

        public User()
        {
            Name = " ";
            Age = 0;
        }

        public string getName()
        {
            Name = Console.ReadLine();
            return Name;
        }

        public int getAge()
        {
            Age = int.Parse(Console.ReadLine());
            return Age;
        }
    }
}
