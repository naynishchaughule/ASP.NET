using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Runtime.Remoting.Messaging;
using System.Threading;
public partial class _Default : System.Web.UI.Page
{    
    protected void Page_Load(object sender, EventArgs e)
    {
        NashService.Service svc = new NashService.Service();
        IAsyncResult result = svc.BeginHelloWorld(null, null);

        result.AsyncWaitHandle.WaitOne();
        Page.Response.Write(svc.EndHelloWorld(result));
    }
}