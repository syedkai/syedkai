using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace InterfaceEmplementation
{
    class OddNumber : ISeriseInterface
    {
        public int[] oddserise = new int[100];
        int iterationnumber = 0;

        public (int[], int) Serise()
        {
            //using (StreamReader fr = new StreamReader("OddSerise.txt"))
            //{
            //    while (fr.BaseStream.Length > fr.BaseStream.Length - 2)
            //    {
            //        var lastnumber = fr.
            //    }
            //}
            oddserise[0] = 1;

            for (int i = 1; i < 100; i++)
            {
                oddserise[i] = oddserise[i - 1] + 2;
            }
            iterationnumber += 1;

            return (oddserise, iterationnumber);
        }

        public void SavingOutput(int[] serise, int iteration)
        {
            using (StreamWriter sw = new StreamWriter("OddSerise.txt", true))
            {
                sw.WriteLine(iteration);
                sw.Close();
            }

            //FileStream savedoutput = new FileStream("OddSerise.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
            //savedoutput.WriteByte((byte)iteration);
            using (StreamWriter sw = new StreamWriter("OddSerise.txt", true))
            {
                for (int i = 0; i < serise.Length; i++)
                {

                    sw.Write(Convert.ToString(serise[i]) + ", ");
                }
                sw.Close();
            }
            //savedoutput.Close();

            //using (StreamWriter sw = new StreamWriter("OddSerise.txt", append=True))
            //{
            //    sw.WriteLine("");
            //}

            //savedoutput.Position = 0;
        }
    }
}
