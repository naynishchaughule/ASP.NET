using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

/// <summary>
/// Summary description for Personal
/// </summary>
public class Personal : System.Configuration.ConfigurationElement
{
	public Personal()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    [ConfigurationProperty("fname")]
    public string fname
    {
        get
        {
            return (string)base["fname"];
        }

        set
        {
            base["fname"] = value;
        }
    }

    [ConfigurationProperty("salary")]
    public double salary
    {
        get
        {
            return (double)base["fname"];
        }

        set
        {
            base["fname"] = value;
        }
    }
}