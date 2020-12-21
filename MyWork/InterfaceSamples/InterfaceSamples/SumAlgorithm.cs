using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace InterfaceSamples
{
    public class SumAlgorithm : IMyMLAlgorithm
    {
        private double m_Sum;
        public double sum1 { get; set; }

        public SumAlgorithm()
        {
            this.m_Sum = 0;

        }

        public object SomeOtherMethod()
        {
            return this.m_Sum;
        }

        public object GetResult()
        {
            return this.m_Sum;
        }

        public void Train(double[] data)
        {
            foreach (var number in data)
            {
                this.m_Sum += number;
            }
        }




        public void save()
        {

            SumAlgorithm sum = new SumAlgorithm();
            sum.sum1 = this.m_Sum;
            var xs1 = new XmlSerializer(typeof(SumAlgorithm));

            using (TextWriter text = new StreamWriter(@"result.xml"))
            {

                xs1.Serialize(text, sum);
                text.Close();
            }


        }





        public void load()
        {
            var xs1 = new XmlSerializer(typeof(SumAlgorithm));
            using (TextReader load_res = new StreamReader(@"result.xml"))
            {
                var tempRes = (SumAlgorithm)xs1.Deserialize(load_res);
                m_Sum = tempRes.sum1;
                load_res.Close();

                Console.WriteLine("Add read value is: " + this.m_Sum);
            }
        }
    }
}


       

    
