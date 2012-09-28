using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ProductsDataPackage
/// </summary>
public class ProductsDataPackage
{
    public int CategoryID { get; set; }
    public int ProductID { get; set; }
    public string ProductName { get; set; }
    public decimal UnitPrice { get; set; }
    public int UnitsInStock { get; set; }
	public ProductsDataPackage()
	{
		
	}
    public ProductsDataPackage(int categoryID, int productID, string productName, decimal unitPrice, int unitsInStock)
    {
        CategoryID = categoryID; ProductID = productID; ProductName = productName;
        UnitPrice = unitPrice; UnitsInStock = unitsInStock;
    }
}