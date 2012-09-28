using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Basic;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Basic.Service svc = new Service();
        Basic.ServiceWse ws = new ServiceWse();
        ws.SetPolicy("509Policy");        
        Label1.Text = svc.HelloWorld();
    }
}