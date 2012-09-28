using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1
{
	public Class1()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public void MyHttpContext(HttpContext obj)
    {
        obj.Trace.Warn("http context from a component");
    }
}