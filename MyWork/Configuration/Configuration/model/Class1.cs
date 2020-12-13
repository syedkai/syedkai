using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Configuration.model
{
    class UserData
    {
        public string Name { get; set; }
        public string Dob { get; set;}

        public UserData(string name, string dob)
        {
            Name = name;
            Dob = dob;
        }
    }
}
