using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseProgram_Delegate
{
    /*
    public delegate double AddNum1Delegate(int x, float y, double z);
    public delegate void AddNum2Delegate(int x, float y, double z);
    public delegate bool StrLengthDelegate(string str);
    */

    class FuncDeligate
    {
/*
        public static double AddNum1(int x , float y , double z )
        {
            double Result = x + y + z;
            return Result;
           
        }
*/
        public static void AddNum2(int x , float y , double z )
        {

            double Result = x + y + z;
            Console.WriteLine(Result);
        }

        public static bool StrLength(string str)

        {
            if (str.Length > 5)
            
                return true;
                return false;
            

        }



        static void Main()

        {  /*
            AddNum1Delegate obj1 = AddNum1;
            double FinalResult = obj1.Invoke(10, 52.57f, 72.95);
            Console.WriteLine(FinalResult);


            AddNum2Delegate obj2 = AddNum2;
            obj2.Invoke(20, 92.78f, 95.78);

            StrLengthDelegate obj3 = StrLength;
            bool status = obj3.Invoke("How Are You");
            Console.WriteLine(status);

            */

            /*
            Func< int, float, double, double > obj1 = AddNum1;
            double FinalResult = obj1.Invoke(10, 52.57f, 72.95);
            Console.WriteLine(FinalResult);
            */


            Func<int, float, double, double> obj1 = (x, y, z) =>

            {
                double Result = x + y + z;
                return Result;

            };
             
            double FinalResult = obj1.Invoke(10, 52.57f, 72.95);
            Console.WriteLine(FinalResult);
           

            Action< int, float,double> obj2 = AddNum2;
            obj2.Invoke(20, 92.78f, 95.78);

            Predicate<string> obj3 = StrLength;
            bool status = obj3.Invoke("How");
            Console.WriteLine(status);

        }
       


    }
}
