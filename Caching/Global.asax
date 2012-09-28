<%@ Application Language="C#" %>

<script runat="server">

    public override string GetOutputCacheProviderName(HttpContext context)
    {
        // Get the page.
        string pageAndQuery = System.IO.Path.GetFileName(context.Request.Path);
        if (pageAndQuery.StartsWith("CustomPageForFileBasedCaching.aspx"))
            return "FileCache";
        else
            return base.GetOutputCacheProviderName(context);
    }

    public override string GetVaryByCustomString(HttpContext context, string arg)
    {
        if (arg == "nash")
        {
            string browserName;
            browserName = Context.Request.Browser.Browser;
            browserName += Context.Request.Browser.MajorVersion.ToString();
            return browserName;
        }
        else
        {
            return base.GetVaryByCustomString(context, arg);
        }
    }

    void Application_Start(object sender, EventArgs e)
    {
        // Code that runs on application startup

    }
    
    void Application_End(object sender, EventArgs e) 
    {
        //  Code that runs on application shutdown

    }
        
    void Application_Error(object sender, EventArgs e) 
    { 
        // Code that runs when an unhandled error occurs

    }

    void Session_Start(object sender, EventArgs e) 
    {
        // Code that runs when a new session is started

    }

    void Session_End(object sender, EventArgs e) 
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.

    }
       
</script>
