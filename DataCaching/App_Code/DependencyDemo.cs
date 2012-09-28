using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;
/// <summary>
/// Summary description for DependencyDemo
/// </summary>
public class DependencyDemo
{
	public DependencyDemo()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public CacheDependency GetCacheDependencyInstance(HttpContext context) 
    {
        CacheDependency dependency = new CacheDependency(context.Server.MapPath("~/test.txt"));
        return dependency;
        //CacheDependency dependency = new CacheDependency(null, new string[1] { "key1" });
        //return dependency;
    }
}