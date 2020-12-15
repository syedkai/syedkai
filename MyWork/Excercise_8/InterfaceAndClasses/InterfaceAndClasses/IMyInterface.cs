using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAndClasses
{
    public interface IMyInterface
    {
        /// <summary>
        /// Interface which defines how model training should
        /// </summary>
        /// <returns></returns>
        /// Get and print result
        object GetResult();

        /// <summary>
        /// Model Training
        /// </summary>
        /// <param name="data"></param>
        void Train(double[] data);
    }

}
