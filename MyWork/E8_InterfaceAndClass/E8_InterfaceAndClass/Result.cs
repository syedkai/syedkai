using System;
using System.Collections.Generic;
using System.Text;

namespace E8_InterfaceAndClass
{
    class Result
    {
        public double average;
        public double median;
        public double variance;

        public Result(double average, double median, double variance)
        {
            this.average = average;
            this.median = median;
            this.variance = variance;
        }

        public override string ToString()
        {
            return "Avarage: "+this.average+" Median: "+this.median+" Variance: "+this.variance;
        }

    }
}
