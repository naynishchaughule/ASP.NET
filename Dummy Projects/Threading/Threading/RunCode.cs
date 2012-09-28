using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml.Serialization;

namespace ThreadingBasics
{
    class RunCode
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Binary");
            Binary();

            Console.WriteLine();
            Console.WriteLine("Soap");
            Soap();

            Console.WriteLine();
            Console.WriteLine("XML");
            XML();
            Console.ReadLine();
        }

        private static void XML()
        {
            Product p1 = new Product(14, "water", 1.23);
            XmlSerializer xf = new XmlSerializer(typeof(Product));

            using (FileStream fs = File.Create("XmlSerializer"))
            {
                xf.Serialize(fs, p1);
            }

            using (FileStream fs = File.Open("XmlSerializer", FileMode.Open))
            {
                Console.WriteLine((Product)xf.Deserialize(fs));
            }
        }

        static void Binary()
        {
            Product p1 = new Product(12, "brush", 2.92);
            BinaryFormatter bf = new BinaryFormatter();

            using (FileStream fs = File.Create("BinaryFormatter"))
            {
                bf.Serialize(fs, p1);
            }

            using (FileStream fs = File.Open("BinaryFormatter", FileMode.Open))
            {
                Console.WriteLine((Product)bf.Deserialize(fs));
            }
        }

        static void Soap()
        {
            Product p1 = new Product(13, "toothpaste", 3.98);
            SoapFormatter sf = new SoapFormatter();

            using (FileStream fs = File.Create("SoapFormatter"))
            {
                sf.Serialize(fs, p1);
            }

            using (FileStream fs = File.Open("SoapFormatter", FileMode.Open))
            {
                Console.WriteLine((Product)sf.Deserialize(fs));
            }
        }
    }
}
