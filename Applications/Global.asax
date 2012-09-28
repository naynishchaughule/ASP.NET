<%@ Application Language="C#" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e) 
    {
        // Code that runs on application startup
        //Response is not available
    }
    
    void Application_End(object sender, EventArgs e) 
    {
        //  Code that runs on application shutdown
        //Response is not available
    }
        
    void Application_Error(object sender, EventArgs e) 
    { 
        // Code that runs when an unhandled error occurs
        //Response.Write("<b>");
        //Response.Write("Oops! Looks like an error occurred!!</b><hr />");
        //Response.Write(Server.GetLastError().Message.ToString());
        //Response.Write("<hr />" + Server.GetLastError().ToString());
        //Server.ClearError();
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
        //after event handling code
        //just before the page is sent to the browser
        //application class derives from HttpApplication
        Response.Write(DateTime.Now.ToLongDateString());
    }
       
</script>
