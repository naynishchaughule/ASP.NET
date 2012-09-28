using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyProjects
{
    class Product
    {
        int ID { get; set; }
        string Name { get; set; }
        double UnitPrice { get; set; }
        int StockCount { get; set; }

        public Product(int id, string name, double price, int count)
        {
            ID = id; Name = name; UnitPrice = price; StockCount = count;
        }

        public override string ToString()
        {
            return String.Format("Product ID: {0}, Name: {1}, UnitPrice: {2}, StockCount: {3}", ID, Name, UnitPrice, StockCount);
        }
    }
}
