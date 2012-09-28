using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyProjects
{
    class Catalog
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Lazy<List<Product>> ProductList = new Lazy<List<Product>>();

        public Catalog(int id, string name)
        {
            ID = id; Name = name;
        }

        public string GetCatalogInfo()
        {
            return String.Format("Catalog ID: {0}, Name: {1}", ID, Name);
        }

        public void AddProductsToCatalog(Product myProdList)
        {
            ProductList.Value.Add(myProdList);
        }

        public void DisplayProducts()
        {
            foreach (var item in ProductList.Value)
	        {
                Console.WriteLine(item);
	        }            
        }
    }
}
