using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for CustomerDataPackage
/// </summary>
public class CustomerDataPackage
{
    public int ID { get; set; }
    public string Comments { get; set; }    

	public CustomerDataPackage()
	{
	    
	}

    public CustomerDataPackage(int id, string comments)
    {
        ID = id; Comments = comments;
    }
}