using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BasicService;

public partial class _Default : System.Web.UI.Page
{
    
    protected void Page_Load(object sender, EventArgs e)
    {
        Service svc = new Service();
        IAsyncResult iResult = svc.BeginGetProducts(null, null);
        iResult.AsyncWaitHandle.WaitOne();
        GridView1.DataSource = svc.EndGetProducts(iResult);
        GridView1.DataBind();
    }
}