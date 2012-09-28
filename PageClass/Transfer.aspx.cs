using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Transfer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.Response.Write("<br />" + Page.Request.CurrentExecutionFilePath);
        Page.Response.Write("<br />" + Page.Request.UrlReferrer);
    }
}