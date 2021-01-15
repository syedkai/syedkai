using System;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace Interfaceandclasses
{
    public class Average : IMyInterface
    {
        private double m_sum;
        public double sum { get; set; }

        // private double med;

        public Average()
        {
            this.m_sum = 0;

            // this.med = 0;
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
            m_sum = m_sum / data.Length;

            /*   Array.Sort(data);

               if (n % 2 != 0)
               {
                   med = data[n / 2];
               }

               else

               {
                  med = (data[(n - 1) / 2] + data[n / 2]) / 2.0;
               }
           */
        }
            public void save()
            {

                Average obj_sum = new Average();
                obj_sum.sum = this.m_sum;
                var xs = new XmlSerializer(typeof(Average));

                using (TextWriter text = new StreamWriter(@"result_avg.xml"))
                {

                    xs.Serialize(text, obj_sum);
                    text.Close();
                }


            }

            public void load()
            {
                var xs = new XmlSerializer(typeof(Average));
                using (TextReader load_res = new StreamReader(@"result_avg.xml"))
                {
                    var tempRes = (Average)xs.Deserialize(load_res);
                    m_sum = tempRes.sum;
                    load_res.Close();

                    Console.WriteLine("m_sum read value is: " + this.m_sum);
                }
            }
        


    }
}