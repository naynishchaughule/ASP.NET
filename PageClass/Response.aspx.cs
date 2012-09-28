using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Response : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //System.Web.HttpResponse
        if(Page.Response.IsClientConnected)
        {
            Page.Response.Write("naynish");
            //Page.Response.Redirect("~/Transfer.aspx");
            //http status code 301, permanent redirect
            //Page.Response.RedirectPermanent("~/Transfer.aspx");
            
        }
    }
}