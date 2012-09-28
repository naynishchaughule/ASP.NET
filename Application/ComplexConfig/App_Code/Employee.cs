using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

/// <summary>
/// Summary description for Employee
/// </summary>
public class Employee : System.Configuration.ConfigurationSection
{
	public Employee()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    [ConfigurationProperty("organizationCode")]
    public int organizationCode
    {
        get
        {
            return (int)base["organizationCode"];
        }

        set
        {
            base["organizationCode"] = value;
        }
    }

    [ConfigurationProperty("personal")]
    public Personal personal
    {
        get
        {
            return (Personal)base["personal"];
        }

        set
        {
            base["personal"] = value;
        }
    }
}