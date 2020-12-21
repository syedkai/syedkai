using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace InterfaceSamples
{
    public class Multiplication : IMyMLAlgorithm

    {
        public double mult;
        public double mul { get; set; }


        public Multiplication()
        {
            this.mult = 1;
        }

        public object GetResult()
        {
            return this.mult;
        }

        public void Train(double[] multdata)
        {
            foreach (var number in multdata)
            {
                mult = this.mult * number;
            }
        }




        public void save()
        {

            Multiplication mul1 = new Multiplication();
            mul1.mul = this.mult;
            var xs1 = new XmlSerializer(typeof(Multiplication));

            using (TextWriter text = new StreamWriter(@"result.xml" ))
            {

                xs1.Serialize(text, mul1);
                text.Close();
            }

            
        }

        public void load()
        {
            var xs = new XmlSerializer(typeof(Multiplication));
            using (TextReader load_res = new StreamReader(@"result.xml"))
            {
                var tempRes = (Multiplication)xs.Deserialize(load_res);
                mult = tempRes.mul;
                load_res.Close();

                Console.WriteLine("mult read value is: " + this.mult);
            }
        }
    }
}

    




