using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndClasses
{
    class Female: IPerson
    {
        public void hair()
        {
            Console.WriteLine("Female usually have longer and shiny hair");
        }

        public void height()
        {
            Console.WriteLine("FeMale are usually shorter or average in terms of height.");
        }

        public void voice()
        {
            Console.WriteLine("Female usually have beautiful and soft voice");
        }
    }
}
