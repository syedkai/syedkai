using System;
using System.Collections.Generic;
using System.Text;

namespace E11
{
    public class Wage
    {
        public static int CalculateHoursOfWork(double itemPrice, double hourlyRate)
        {
            double hours = itemPrice / hourlyRate;
            return (int)Math.Ceiling(hours);
        }
    }
}
