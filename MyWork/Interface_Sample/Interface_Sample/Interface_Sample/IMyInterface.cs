using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Sample
{
    interface IMyInterface
    {
        /// <summary>
        /// Get result of the model
        /// </summary>

        object GetResult();

        /// <summary>
        /// Train the model
        /// </summary>

        void Train(double[] data);

        void save();

        void load();
    }
}
