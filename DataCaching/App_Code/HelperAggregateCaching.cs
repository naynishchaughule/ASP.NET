using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Caching;

/// <summary>
/// Summary description for HelperAggregateCaching
/// </summary>
public class HelperAggregateCaching
{
	public HelperAggregateCaching()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public AggregateCacheDependency GetAggregateDependency(HttpContext context)
    {
        CacheDependency dependency1 = new CacheDependency(context.Server.MapPath("~/test1.txt"));
        CacheDependency dependency2 = new CacheDependency(context.Server.MapPath("~/test2.txt"));
        CacheDependency dependency3 = new CacheDependency(null, new string[] {"key1"});
        AggregateCacheDependency aggDependency = new AggregateCacheDependency();
        aggDependency.Add(new CacheDependency[] {dependency1, dependency2, dependency3 });
        return aggDependency;
    }
}