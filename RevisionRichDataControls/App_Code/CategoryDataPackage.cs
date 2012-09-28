using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CategoryDataPackage
/// </summary>
public class CategoryDataPackage
{
    public int CategoryID { get; set; }
    public string CategoryName { get; set; }
	public CategoryDataPackage()
	{
	    
	}
    public CategoryDataPackage(int categoryID, string categoryName)
    {
        CategoryID = categoryID;
        CategoryName = categoryName;
    }
}