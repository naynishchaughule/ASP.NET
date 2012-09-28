using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for EmployeeDetailsDataPackage
/// </summary>
public class EmployeeDetailsDataPackage
{
    public int EmployeeID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string TitleOfCourtesy { get; set; }

	public EmployeeDetailsDataPackage(int id, string fname, string lname, string title)
	{
        EmployeeID = id; FirstName = fname; LastName = lname; TitleOfCourtesy = title;
	}
}