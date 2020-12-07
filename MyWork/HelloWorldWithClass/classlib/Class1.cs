using System;

namespace classlib
{
    public class Class1
    {
       
        
            string color;

            public Class1(string a)
            {
                this.color = a;
            }

            public string getcolor()
            {
                return color;
            }

            public string aboutcar()
            {
                return ("My car color is " + this.getcolor() + ".");
            }
        
    }


}
