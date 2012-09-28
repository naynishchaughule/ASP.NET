<%@ Application Language="C#" %>

<script runat="server">

    //class Global : System.Web.HttpApplication
    
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

    void Application_OnEndRequest()
    {
        //before the page is sent to the browser
        Response.Write("<hr />" + DateTime.Now.ToLongDateString());
    }

    void Application_Error()
    {
        //before the page is sent to the browser
        Response.Write("Server.GetLastError().Message.ToString() <br /> <br />");
        Response.Write(Server.GetLastError().Message.ToString());
        Response.Write("<hr />");
        Response.Write(Server.GetLastError().ToString());
        Server.ClearError();
    }
       
</script>
