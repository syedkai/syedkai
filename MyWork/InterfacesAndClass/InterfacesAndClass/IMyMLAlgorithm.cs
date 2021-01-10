using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAndClass
{
    /// <summary>
    /// Interfaces which defines how to train model
    /// </summary>
    interface IMyMLAlgorithm
    {
        /// <summary>
        /// Get result of the trained model.
        /// </summary>
        /// <returns></returns>
        object GetResult();

        /// <summary>
        /// Train the model
        /// </summary>
        /// <param name="data">Training data</param>
        void Train(double[] data);
    }
}
