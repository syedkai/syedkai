using System;
using System.Collections.Generic;
using System.Text;

namespace MyNugetLibrary
{
    public class SimpleInterest
    {
        public double SI(double Rate, double Period, Double Percentage)
        {
            double result = 0;
            result = Rate * Period * Percentage / 100;
            return result;
        }
    }
}
