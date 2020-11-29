using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldWithClass
{
    public class ClassAutomotive
    {
        string carBrand;
        string carColour;
        int carManfactureYear;

        public ClassAutomotive( string brand, string colour, int yearOfManufacture)
        {
            this.carBrand = brand;
            this.carColour = colour;
            this.carManfactureYear = yearOfManufacture;
        }

        public string getCarBrand()
        {
            return carBrand;
        }

        public string getCarColour()
        {
            return carColour;
        }

        public int getYearOfManufacture()
        {
            return carManfactureYear;
        }

        public string getTheCarDetails()
        {
            return ("This is a " + this.getCarBrand() + " in colour " + this.getCarColour() + " and it was manufactured in the year " + this.getYearOfManufacture() );
        }


    }
}
