using System;
using System.Collections.Generic;
using System.Text;

namespace E8
{
    public interface ITrainInterface
    {
        object GetResult();
        void Train(double[] data);

    }

    public interface IFileInterface : ITrainInterface
    {
        void Load();
        void Save();
       
    }
}
