using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

/// <summary>
/// Summary description for Product
/// </summary>
public class Product : System.Configuration.ConfigurationSection
{
	public Product()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    [ConfigurationProperty("id")]
    public int id
    {
        get
        {
            return (int)base["id"];
        }

        set
        {
            base["id"] = value;
        }
    }

    [ConfigurationProperty("name")]
    public string name
    {
        get
        {
            return (string)base["name"];
        }

        set
        {
            base["name"] = value;
        }
    }
}