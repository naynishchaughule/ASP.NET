using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ThreadingBasics
{
    [Serializable]
    public class Product
    {
        public int PID;
        public string PName;

        [NonSerialized]
        private double Price;

        public Product()
        {

        }

        public Product(int id, string name, double price)
        {
            PID = id; PName = name; Price = price;
        }

        public override string ToString()
        {
            return String.Format("Product ID: {0}, Name: {1}, Price: {2}", PID, PName, Price);
        }
    }
}
