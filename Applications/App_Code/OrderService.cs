using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

/// <summary>
/// Summary description for OrderService
/// </summary>
public class OrderService : System.Configuration.ConfigurationSection
{
	public OrderService()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    [ConfigurationProperty("location", IsRequired = true, DefaultValue = @"C:\ASP")]
    public string Location
    {
        get
        {
            return (string)base["location"];
        }
        set
        {
            base["location"] = value;            
        }
    }
}