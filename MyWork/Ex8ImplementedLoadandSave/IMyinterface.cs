using System;
namespace Interfaceandclasses
{
    public interface IMyInterface
    {
        object GetResult();
        void Train(double[] data);
        void save();

        void load();
    }
}