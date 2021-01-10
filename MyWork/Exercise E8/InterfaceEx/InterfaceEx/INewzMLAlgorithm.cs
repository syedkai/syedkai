using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceEx
{
    /// <summary>
    /// Interface that defines how to train the model.
    /// </summary>
    interface INewzMLAlgorithm
    {

        /// <summary>
        /// Obtain result of the Trained model.
        /// </summary>
        /// <returns></returns>
        object GetResult();

        /// <summary>
        /// Train the model
        /// </summary>
        /// <param name="data">Train data</param>
        void Train(double[] data);



    }

}
