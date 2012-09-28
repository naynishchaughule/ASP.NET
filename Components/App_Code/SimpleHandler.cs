using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.SessionState;

/// <summary>
/// Summary description for SimpleHandler
/// </summary>
public class SimpleHandler : IHttpHandler, IReadOnlySessionState
{
	public SimpleHandler()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public bool IsReusable
    {
        get { return true; }
    }

    public void ProcessRequest(HttpContext context)
    {        
        HttpContext.Current.Response.Write("public void ProcessRequest(HttpContext context)");        
    }
}