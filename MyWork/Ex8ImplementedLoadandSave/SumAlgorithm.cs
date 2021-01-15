using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace Interfaceandclasses
{
    public class SumAlgorithm : IMyInterface
    {
        private double m_sum;
        public double sum1 { get; set; }
        public SumAlgorithm()
        {
            this.m_sum = 0;
        }
        public object GetResult()
        {
            return m_sum;
        }

        public void Train(double[] data)
        {

            foreach (var number in data)
            {
                this.m_sum = m_sum + number;
            }
            if (this.m_sum > 100)
            {
                this.m_sum = 1;
            }
            else

            {
                this.m_sum = 0;
            }


        }
        public void save()
        {

            SumAlgorithm sum = new SumAlgorithm();
            sum.sum1 = this.m_sum;
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
                m_sum = tempRes.sum1;
                load_res.Close();

                Console.WriteLine("Add read value is: " + this.m_sum);
            }
        }



    }
}
