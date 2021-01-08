using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesandClasses
{
    interface IMyMLAlgorithm
    {

        object GetResult();

        /// <summary>
        /// Train the model
        /// </summary>
        /// <param name="data">Trainng data</param>
        void Train(int[] data);
    }
}
