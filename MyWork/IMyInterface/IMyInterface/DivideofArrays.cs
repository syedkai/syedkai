using System;
using System.Collections.Generic;
using System.Text;

namespace IMyInterface
{
    class DivideofArrays : InterfaceAlgo
    {

        private double Div;
        private double Mul = 1;

        public DivideofArrays()                             // Default Constructor
        {
            this.Div = 0;
        }

        public void DivideofArraySum(double[] data)        // interface method implementation
        {
            foreach (var m in data)
            {
                this.Div += m;
            }

            this.Div = this.Div / 2;

        }

        public object getResult()                           // interface method implementation
        {
            return this.Div;
        }

        public void SumofArray(double[] data)               // interface method implementation
        {
            throw new NotImplementedException();
        }

        public void MulofArray(double[] data)                   // method only in this class
        {
            foreach (var item in data)
            {
                 this.Mul *= item; 
            }
            this.Div = Mul;
        }
    }
}
