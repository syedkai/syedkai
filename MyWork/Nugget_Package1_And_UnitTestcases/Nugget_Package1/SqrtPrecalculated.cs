using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nuget_Package1
{
    public static class SqrtPrecalculated
    {
        public const int MaxValue = 100000;

        private static int[] sqrtValues;

        static SqrtPrecalculated()
        {
            sqrtValues = new int[MaxValue + 1];
            for (int i = 0; i < sqrtValues.Length; i++)
            {
                sqrtValues[i] = (int)Math.Sqrt(i);
            }
        }

        public static int GetSqrt(int value)
        {
            if ((value < 0) || (value > MaxValue))
            {
                throw new ArgumentOutOfRangeException(string.Format("The argument should be in range [0..{0}].", MaxValue));
            }
            return sqrtValues[value];
        }
    }
}
