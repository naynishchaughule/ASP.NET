using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;
using System.Web.SessionState;

/// <summary>
/// Summary description for LogUserModule
/// </summary>
public class LogUserModule : IHttpModule
{
	public LogUserModule()
	{
		//
		// TODO: Add constructor logic here
		//
	}

    public void Dispose()
    {
        
    }

    public void Init(HttpApplication context)
    {
        context.AuthenticateRequest += new EventHandler(context_AuthenticateRequest);
        SessionStateModule sessionMod = (SessionStateModule)context.Modules["Session"];
        sessionMod.Start += new EventHandler(sessionMod_Start);
    }

    void sessionMod_Start(object sender, EventArgs e)
    {
        
    }

    void context_AuthenticateRequest(object sender, EventArgs e)
    {
        string name = HttpContext.Current.User.Identity.Name;
        EventLog log = new EventLog();
        log.Source = "Log User Module";
        log.WriteEntry(name + " was authenticated.");        
    }
}