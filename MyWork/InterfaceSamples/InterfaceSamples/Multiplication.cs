using System;
using System.Collections.Generic;
using System.Text;


namespace InterfaceSamples
{
    public class Multiplication : IMyMLAlgorithm
    
    
        private double mult;


        public Multiplication()
        {
            this.mult = 1;
        }

        public object GetResult()
        {
            return this.mult;
        }

        public void Train(double[] multdata)
        {
            foreach (var number in multdata)
            {
                mult = this.mult * number;
            }
        }
    }
}
