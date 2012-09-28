using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for EmployeeSubset
/// </summary>
public class EmployeeSubset
{
    public int Id { get; set; }
    public string Fname { get; set; }
	public EmployeeSubset(int id, string fname)
	{
        Id = id; Fname = fname;
	}
}