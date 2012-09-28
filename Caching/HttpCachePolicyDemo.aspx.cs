using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class HttpCachePolicyDemo : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Page.Response.Cache.SetCacheability(HttpCacheability.Public);
        Page.Response.Cache.SetExpires(DateTime.Now.AddSeconds(60));
        Page.Response.Cache.SetValidUntilExpires(true);
        Label1.Text = DateTime.Now.ToString();
    }
}