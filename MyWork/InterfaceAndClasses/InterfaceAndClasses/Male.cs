using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndClasses
{
    class Male : IPerson
    {
        public void hair()
        {
            Console.WriteLine("Male usually have short hair");
        }

        public void height()
        {
            Console.WriteLine("Male are usually taller.");
        }

        public void voice()
        {
            Console.WriteLine("Male usually have husky voice");
        }
    }
}
