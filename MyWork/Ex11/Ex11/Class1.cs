using System;
using System.Collections.Generic;
using System.Text;

namespace Ex11
{
    public class Class1
    {
        int[] ABC;
        public Class1(int[] XYZ) //constructor should be AS a Class1 name here Class1 name from class is using as a constructor
        {
            ABC = XYZ;
        }

        public void binarySort()
        {
            for (int i = 0; i < ABC.Length - 1; i++)
                for (int j = i + 1; j < ABC.Length; j++)
                    if (ABC[i] > ABC[j])
                    {
                        int temp = ABC[i];
                        ABC[i] = ABC[j];
                        ABC[j] = temp;
                    }
        }
    }
}

