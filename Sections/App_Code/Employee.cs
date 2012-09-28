using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

/// <summary>
/// Summary description for Employee
/// </summary>
public class Employee : ConfigurationSection
{
	public Employee()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    [ConfigurationProperty("Id", IsRequired = true)]
    public int Id
    {
        get
        {
            return (int)base["Id"];
        }
        set
        {
            base["Id"] = value;
        }
    }
}