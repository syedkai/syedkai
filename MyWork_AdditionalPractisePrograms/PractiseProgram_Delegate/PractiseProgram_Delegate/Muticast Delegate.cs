using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseProgram_Delegate
{
    public delegate void FinalAreaWidth(double Width, double Height);

    class Muticast_Delegate
    {
        public  void Area(double Width, double Height)

        {
            double CalculatedArea = Width * Height;
            Console.WriteLine(CalculatedArea);

        }

        public void Parameter(double Width, double Height)

        {

            double CalculatedParmeter = (2*(Width + Height));
            Console.WriteLine(CalculatedParmeter);
        }
        static void Main()
        {
            Muticast_Delegate obj2 = new Muticast_Delegate();
            //FinalAreaWidth obj1 = new FinalAreaWidth(obj2.Area); // can be either used this by this line or next line
            FinalAreaWidth obj1 = obj2.Area;
            obj1 += obj2.Parameter;
            obj1.Invoke(298.55, 974.62);
           
            Console.ReadLine();

        }
    }
}
