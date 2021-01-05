using System;
using System.Collections.Generic;
using System.Text;

namespace ClassProjE4
{
    class Class1
    {

        string city;
        string state;
        string country;

        public Class1(string a, string b, string c)
        {
            this.city = a;
            this.state= b;
            this.country = c;

        }

        public string getCityName()
        {
            return city;
        }

        public string getState()
        {
            return state;
        }

        public string getCountry()
        {
            return country;
        }

        public string Detail()
        {

            return ("City :  " + this.getCityName() + " State : " + this.getState() + " Country :  " + this.getCountry());


        }

    }
}
    
