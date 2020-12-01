using System;
namespace HelloWorldWithClass
{
    public class Car
    {
        string color;

        public Car(string a)
        {
            this.color = a;
        }

        public string getcolor()
        {
            return color;
        }

        public string aboutcar()
        {
            return ("My car color is " + this.getcolor() + "." );
        }
    }
}
